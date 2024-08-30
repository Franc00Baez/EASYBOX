-- Trigger para mantener el historial de transacciones al insertar una nueva transacción
CREATE TRIGGER TRG_INS_TRANSACCION
ON TRANSACCIONES
AFTER INSERT
AS
BEGIN
	INSERT INTO HISTORIAL_TRANSACCIONES (id_transaccion, descripcion, categoria, monto, tipo_movimiento, fecha_movimiento, accion)
	SELECT id_transaccion, descripcion, categoria, monto, tipo_movimiento, fecha_movimiento, 'CREACION'
	FROM INSERTED
END
GO

-- Trigger para mantener el historial de transacciones al modificar una transacción
CREATE TRIGGER TRG_UPD_TRANSACCION
ON TRANSACCIONES
AFTER UPDATE
AS
BEGIN
	INSERT INTO HISTORIAL_TRANSACCIONES (id_transaccion, descripcion, categoria, monto, tipo_movimiento, fecha_movimiento, accion)
	SELECT id_transaccion, descripcion, categoria, monto, tipo_movimiento, fecha_movimiento, 'MODIFICACION'
	FROM INSERTED
END
GO

-- Trigger para mantener el historial de transacciones al eliminar una transacción lógicamente
CREATE TRIGGER TRG_DEL_TRANSACCION
ON TRANSACCIONES
INSTEAD OF DELETE
AS
BEGIN
	UPDATE TRANSACCIONES
	SET eliminado = 1
	WHERE id_transaccion IN (SELECT id_transaccion FROM DELETED)

	INSERT INTO HISTORIAL_TRANSACCIONES (id_transaccion, descripcion, categoria, monto, tipo_movimiento, fecha_movimiento, accion)
	SELECT id_transaccion, descripcion, categoria, monto, tipo_movimiento, fecha_movimiento, 'ELIMINACION'
	FROM DELETED
END
GO

-- Trigger para prevenir la eliminación física de cajas, manejando eliminación lógica
CREATE TRIGGER TRG_DEL_CAJA
ON CAJAS
INSTEAD OF DELETE
AS
BEGIN
	UPDATE CAJAS
	SET eliminado = 1
	WHERE id_caja IN (SELECT id_caja FROM DELETED)
END
GO

-- Trigger para sumar/restar el monto de transeferencia la caja despues de un insert
CREATE TRIGGER TRG_AFTER_INSERT_TRANSACCION
ON TRANSACCIONES
AFTER INSERT
AS
BEGIN
    DECLARE @IdCaja INT,
            @Monto DECIMAL(18,2),
            @TipoMovimiento VARCHAR(50);
    
    SELECT @IdCaja = i.caja, 
           @Monto = i.monto, 
           @TipoMovimiento = i.tipo_movimiento
    FROM inserted i;

    IF @TipoMovimiento = 'INGRESO'
    BEGIN
        UPDATE CAJAS
        SET saldo = saldo + @Monto
        WHERE id_caja = @IdCaja;
    END
    ELSE IF @TipoMovimiento = 'RETIRO'
    BEGIN
        UPDATE CAJAS
        SET saldo = saldo - @Monto
        WHERE id_caja = @IdCaja;
    END
END;
GO
-- Trigger para recalcular el saldo de caja cuando se edita una transferencia
CREATE TRIGGER TRG_AFTER_UPDATE_TRANSACCION
ON TRANSACCIONES
AFTER UPDATE
AS
BEGIN
    DECLARE @IdCaja INT,
            @MontoAntiguo DECIMAL(18,2),
            @MontoNuevo DECIMAL(18,2),
            @TipoMovimiento VARCHAR(50);

    SELECT @IdCaja = i.caja, 
           @MontoAntiguo = d.monto, 
           @MontoNuevo = i.monto,
           @TipoMovimiento = i.tipo_movimiento
    FROM inserted i
    INNER JOIN deleted d ON i.id_transaccion = d.id_transaccion;

    IF @TipoMovimiento = 'INGRESO'
    BEGIN
        UPDATE CAJAS
        SET saldo = saldo + (@MontoNuevo - @MontoAntiguo)
        WHERE id_caja = @IdCaja;
    END
    ELSE IF @TipoMovimiento = 'RETIRO'
    BEGIN
        UPDATE CAJAS
        SET saldo = saldo - (@MontoNuevo - @MontoAntiguo)
        WHERE id_caja = @IdCaja;
    END
END;
GO
