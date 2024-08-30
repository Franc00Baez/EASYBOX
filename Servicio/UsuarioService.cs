using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dominio;

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
                    throw;
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
