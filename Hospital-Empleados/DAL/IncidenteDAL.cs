using Hospital_Empleados.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.DAL
{
    public class IncidenteDAL
    {

        private string connectionString;

        public IncidenteDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }
        public void CrearIncidente(Incidente incidente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearIncidente", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", incidente.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Fecha", incidente.Fecha);
                    cmd.Parameters.AddWithValue("@Tipo", incidente.Tipo);
                    cmd.Parameters.AddWithValue("@Descripcion", incidente.Descripcion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", incidente.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", incidente.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", incidente.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", incidente.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear incidente: " + ex.Message);
            }
        }

        public List<Incidente> LeerAIncidente()
        {
            List<Incidente> incidentes = new List<Incidente>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarIncidentes", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Incidente incidente = new Incidente
                        {  
                            IdIncidente = (int)reader["IdIncidente"],
                            IdEmpleado = (int)reader["IdEmpleado"],
                            Fecha = (DateTime)reader["Fecha"],
                            Tipo = (string)reader["Tipo"],
                            Descripcion = (string)reader["Descripcion"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        incidentes.Add(incidente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer incidente: " + ex.Message);
            }
            return incidentes;
        }

        public void ActualizarIncidente(Incidente incidente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarDisciplina", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", incidente.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Fecha", incidente.Fecha);
                    cmd.Parameters.AddWithValue("@Tipo", incidente.Tipo);
                    cmd.Parameters.AddWithValue("@Descripcion", incidente.Descripcion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", incidente.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", incidente.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", incidente.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", incidente.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar disciplina: " + ex.Message);
            }
        }

        public void EliminarDisciplina(int idIncidente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarIncidente", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdIncidente", idIncidente);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar incidente: " + ex.Message);
            }
        }

    }
}