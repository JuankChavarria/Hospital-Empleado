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
    public class EvaluacionDAL
    {

        private string connectionString;

        public EvaluacionDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }
        public void CrearDisciplina(Evaluacion evaluacion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearEvaluacion", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", evaluacion.IdEmpleado);                
                    cmd.Parameters.AddWithValue("@Fecha", evaluacion.Fecha);
                    cmd.Parameters.AddWithValue("@Indicadores", evaluacion.Indicadores);
                    cmd.Parameters.AddWithValue("@Resultado", evaluacion.Resultado);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", evaluacion.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", evaluacion.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", evaluacion.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", evaluacion.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear evaluacion: " + ex.Message);
            }
        }

        public List<Evaluacion> LeerAEvaluacion()
        {
            List<Evaluacion> evaluaciones = new List<Evaluacion>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarEvaluaciones", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Evaluacion evaluacion = new Evaluacion
                        {
                            IdEmpleado = (int)reader["IdEmpleado"],
                            Fecha = (DateTime)reader["Fecha"],
                            Indicadores = (string)reader["Indicadores"],
                            Resultado = (string)reader["Resultado"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        evaluaciones.Add(evaluacion);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer evaluacion: " + ex.Message);
            }
            return evaluaciones;
        }

        public void ActualizarDisciplina(Evaluacion evaluacion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarEvaluacion", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", evaluacion.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Fecha", evaluacion.Fecha);
                    cmd.Parameters.AddWithValue("@Indicadores", evaluacion.Indicadores);
                    cmd.Parameters.AddWithValue("@Resultado", evaluacion.Resultado);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", evaluacion.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", evaluacion.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", evaluacion.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", evaluacion.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar evaluacion: " + ex.Message);
            }
        }

        public void EliminarEvaluacion(int idEvaluacion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarDisciplina", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEvaluacion", idEvaluacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar evaluacion: " + ex.Message);
            }
        }
    }
}