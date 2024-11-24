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
    public class ReporteDAL
    {

        private string connectionString;

        public ReporteDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }
        public void CrearDisciplina(Reporte reporte)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearReporte", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", reporte.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Titulo", reporte.Titulo);
                    cmd.Parameters.AddWithValue("@Descripcion", reporte.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaGeneracion", reporte.FechaGeneracion);
                    cmd.Parameters.AddWithValue("@Autor", reporte.Autor);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", reporte.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", reporte.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", reporte.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", reporte.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear reporte: " + ex.Message);
            }
        }

        public List<Reporte> LeerAReporte()
        {
            List<Reporte> reportes = new List<Reporte>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarReportes", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Reporte reporte = new Reporte
                        {
                            IdReporte = (int)reader["IdReporte"],
                            IdEmpleado = (int)reader["IdEmpleado"],
                            Titulo = (string)reader["Titulo"],
                            Descripcion = (string)reader["Descripcion"],
                            FechaGeneracion = (DateTime)reader["FechaGeneracion"] as DateTime?,
                            Autor = (string)reader["Autor"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        reportes.Add(reporte);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer reporte: " + ex.Message);
            }
            return reportes;
        }

        public void ActualizarReporte(Reporte reporte)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarReporte", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", reporte.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Titulo", reporte.Titulo);
                    cmd.Parameters.AddWithValue("@Descripcion", reporte.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaGeneracion", reporte.FechaGeneracion);
                    cmd.Parameters.AddWithValue("@Autor", reporte.Autor);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", reporte.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", reporte.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", reporte.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", reporte.FechaModificacion);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { 
           
                throw new Exception("Error al actualizar reporte: " + ex.Message);
            }
        }

        public void EliminarDisciplina(int idReporte)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarReporte", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdReporte", idReporte);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar reporte: " + ex.Message);
            }
        }
    }
}