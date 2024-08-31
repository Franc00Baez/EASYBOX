using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dominio;
using Helpers;

namespace Servicio
{
    public class UsuarioService
    {
        public List<Usuario> getAllUsers()
        {
            List<Usuario> users = new List<Usuario>();
            string query = "Select * from USUARIOS";
            
            using (SqlDbManager dbManager = new SqlDbManager())
            {
                try
                {
                    dbManager.OpenConnection();
                    DataTable resultTable = dbManager.ExecuteQuery(query);

                    foreach(DataRow row in resultTable.Rows)
                    {
                        Usuario aux = ConvertDataRowToUsuario(row);
                        users.Add(aux);
                    }

                    return users;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbManager.CloseConnection();
                }
            }
        }

        public Usuario GetUsuarioById(int id)
        {
            string query = "Select * from USUARIOS Where id_usuario = @id";

            using (SqlDbManager dbManager = new SqlDbManager())
            {
                try
                {
                    dbManager.OpenConnection();
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@id", id)
                    };

                    DataTable resultTable = dbManager.ExecuteQuery(query, parameters);

                    Usuario aux = ConvertDataRowToUsuario(resultTable.Rows[0]);

                    return aux;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbManager.CloseConnection();
                }
            }
        }

        public int InsertUsuario(Usuario user)
        {
            string query = @"INSERT INTO USUARIOS (nombre, email, contraseña, rol, img_perfil) 
                            VALUES (@nombre, @email, @contraseña, @rol, @img_perfil);";
            string hash_password = PasswordHasher.HashPassword(user.Password);
            int affected_rows;

            using (SqlDbManager dbManager = new SqlDbManager())
            {
                try
                {
                    dbManager.OpenConnection();
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@nombre", user.Name),
                        new SqlParameter("@email", user.Email),
                        new SqlParameter("@contrasea", hash_password),
                        new SqlParameter("@rol", user.IdRol),
                        new SqlParameter("@img_perfil", (object)user.ImgPerfil ?? DBNull.Value),
                        
                    };

                    affected_rows = dbManager.ExecuteNonQuery(query);

                    return affected_rows;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    dbManager.CloseConnection();
                }
            }
        }

        private Usuario ConvertDataRowToUsuario(DataRow dataRow)
        {
            var id = Convert.ToInt32(dataRow["id_usuario"]);
            var name = dataRow["nombre"].ToString();
            var email = dataRow["email"].ToString();
            var password = dataRow["password"].ToString();
            var idrol = Convert.ToInt32(dataRow["rol"]);
            var imgPerfil = dataRow["img_perfil"] != DBNull.Value ? dataRow["img_perfil"].ToString() : null;
            var eliminated = Convert.ToBoolean(dataRow["eliminado"]);
            var fecha_creacion = Convert.ToDateTime(dataRow["fecha_creacion"]);

            return new Usuario(id, name, email, password, idrol, imgPerfil, eliminated, fecha_creacion);
        }
    }
}
