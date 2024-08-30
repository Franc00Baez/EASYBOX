using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Servicio
{
    public class SqlDbManager : IDisposable
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        public SqlDbManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["EBConnection"].ConnectionString;
            _connection = new SqlConnection(_connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al abrir la conexión.", ex);
                throw; // Re-lanza la excepción para que pueda ser manejada más adelante si es necesario
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al cerrar la conexión.", ex);
                throw;
            }
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);
                        return resultTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al ejecutar la consulta.", ex);
                throw;
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al ejecutar la consulta de modificación.", ex);
                throw;
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al ejecutar la consulta de valor escalar.", ex);
                throw;
            }
        }

        private void LogError(string message, Exception ex)
        {
            // Aquí puedes implementar tu lógica de registro de errores
            Console.WriteLine($"{message} Detalles: {ex.Message}");
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }



    }
}
