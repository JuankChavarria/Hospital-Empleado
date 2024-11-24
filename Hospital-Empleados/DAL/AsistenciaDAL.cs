using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Hospital_Empleados.Models;

namespace Hospital_Empleados.DAL
{
    public class AsistenciaDAL
    {
        private string connectionString;

        public AsistenciaDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }
        public void CrearAsistencia(Asistencia asistencia)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarAsistencia", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", asistencia.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha);
                    cmd.Parameters.AddWithValue("@HoraEntrada", asistencia.HoraEntrada);
                    cmd.Parameters.AddWithValue("@HoraSalida", asistencia.HoraSalida);
                    cmd.Parameters.AddWithValue("@HorasTrabajadas", asistencia.HorasTrabajadas);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", asistencia.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", asistencia.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", asistencia.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", asistencia.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear asistencia: " + ex.Message);
            }
        }

        public List<Asistencia> LeerAsistencia()
        {
            List<Asistencia> asistencias = new List<Asistencia>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarAsistencias", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Asistencia asistencia = new Asistencia
                        {
                            IdAsistencia = (int)reader["IdAsistencia"],
                            IdEmpleado = (int)reader["IdEmpleado"],
                            Fecha = (DateTime)reader["Fecha"],
                            HoraEntrada = (DateTime)reader["HoraEntrada"],
                            HoraSalida = (DateTime)reader["HoraSalida"],
                            HorasTrabajadas = (DateTime)reader["HorasTrabajadas"],                          
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        asistencias.Add(asistencia);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer asistencia: " + ex.Message);
            }
            return asistencias;
        }

        public void ActualizarAsistencia(Asistencia asistencia)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarAsistencia", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", asistencia.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha);
                    cmd.Parameters.AddWithValue("@HoraEntrada", asistencia.HoraEntrada);
                    cmd.Parameters.AddWithValue("@HoraSalida", asistencia.HoraSalida);
                    cmd.Parameters.AddWithValue("@HorasTrabajadas", asistencia.HorasTrabajadas);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", asistencia.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", asistencia.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", asistencia.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", asistencia.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar asistencia: " + ex.Message);
            }
        }

        public void EliminarUsuario(int idAsistencia)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarAsistencia", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdAsistencia", idAsistencia);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar asistencia: " + ex.Message);
            }
        }



    }
}