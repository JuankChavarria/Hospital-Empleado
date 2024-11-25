using Hospital_Empleados.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Hospital_Empleados.Pages;

namespace Hospital_Empleados.DAL
{
    public class CapacitacionesDAL
    {

        private string connectionString;

        public CapacitacionesDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }
        public void CrearCapacitacion(Capa capacitacion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearCapacitacion", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", capacitacion.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Curso", capacitacion.Curso);
                    cmd.Parameters.AddWithValue("@FechaInicio", capacitacion.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", capacitacion.FechaFin);
                    cmd.Parameters.AddWithValue("@Certificacion", capacitacion.Certificacion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", capacitacion.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", capacitacion.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", capacitacion.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", capacitacion.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear capacitacion: " + ex.Message);
            }
        }

        public List<Capa> LeerCapacitacion()
        {
            List<Capa> capas = new List<Capa>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarCapacitaciones", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Capa capa = new Capa
                        {
                            IdCapacitacion = (int)reader["IdAsistencia"],
                            IdEmpleado = (int)reader["IdEmpleado"],
                            Curso = (string)reader["Curso"],
                            FechaInicio = (DateTime)reader["FechaInicio"],
                            FechaFin = (DateTime)reader["FechaFin"],
                            Certificacion = (string)reader["Certificaion"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        capas.Add(capa);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer Capacitacion: " + ex.Message);
            }
            return capas;
        }

        public void ActualizarCertificacion(Capa capa)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarCapacitacion", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", capa.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Curso", capa.Curso);
                    cmd.Parameters.AddWithValue("@FechaInicio", capa.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", capa.FechaFin);
                    cmd.Parameters.AddWithValue("@Certificacion", capa.Certificacion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", capa.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", capa.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", capa.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", capa.FechaModificacion);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar capacitacion: " + ex.Message);
            }
        }

        public void EliminarUsuario(int idCapacitacion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarCapacitacion", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdCapacitacion", idCapacitacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar capacitacion: " + ex.Message);
            }
        }
    }
}