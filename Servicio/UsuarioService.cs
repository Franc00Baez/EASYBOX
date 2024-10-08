﻿using System;
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

        public bool InsertUsuario(Usuario user)
        {
            string query = "INSERT INTO USUARIOS (nombre, email, password, rol, img_perfil)" +
                            "VALUES (@nombre, @email, @contraseña, @rol, @img_perfil);";
            string hash_password = PasswordHasher.HashPassword(user.Password);
            bool userInserted = false;

            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@nombre", user.Name),
                        new SqlParameter("@email", user.Email),
                        new SqlParameter("@contraseña", hash_password),
                        new SqlParameter("@rol", user.IdRol),
                        new SqlParameter("@img_perfil", (object)user.ImgPerfil ?? DBNull.Value),

                    };

            using (SqlDbManager dbManager = new SqlDbManager())
            {
                try
                {
                    dbManager.OpenConnection();

                    userInserted = dbManager.ExecuteNonQuery(query, parameters) > 0;

                    return userInserted;
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

        public bool ValidateUserName(string username)
        {
            string query = @"SELECT COUNT(1)
                            FROM USUARIOS
                            WHERE UPPER(nombre) = UPPER(@nombre);";

            bool exists;

            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@nombre", username.ToUpper())
                    };

            using (SqlDbManager dbManager = new SqlDbManager())
            {
                try
                {
                    dbManager.OpenConnection();

                    exists = Convert.ToBoolean(dbManager.ExecuteScalar(query, parameters));

                    return exists;
                }catch (Exception ex)
                {
                    throw ex;
                }finally
                {
                    dbManager.CloseConnection();
                }
            }
        }

        public bool ValidateEmail(string email)
        {
            string query = @"SELECT COUNT(1)
                            FROM USUARIOS
                            WHERE UPPER(email) = UPPER(@email);";

            bool exists;

            SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@email", email.ToUpper())
                    };

            using (SqlDbManager dbManager = new SqlDbManager())
            {
                try
                {
                    dbManager.OpenConnection();

                    exists = Convert.ToBoolean(dbManager.ExecuteScalar(query, parameters));

                    return exists;
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
    }
}
