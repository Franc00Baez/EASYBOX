CREATE TRIGGER TRG_UPDATE_CAJA_SALDO
ON TRANSACCIONES
AFTER INSERT
AS
BEGIN
    DECLARE @caja_id INT, @monto DECIMAL(18,2), @tipo_movimiento CHAR(6);
    SELECT @caja_id = INSERTED.caja, 
           @monto = INSERTED.monto, 
           @tipo_movimiento = INSERTED.tipo_movimiento
    FROM INSERTED;
    
    IF @tipo_movimiento = 'INGRESO'
        UPDATE CAJAS SET saldo = saldo + @monto WHERE id_caja = @caja_id;
    ELSE IF @tipo_movimiento = 'RETIRO'
        UPDATE CAJAS SET saldo = saldo - @monto WHERE id_caja = @caja_id;
END;