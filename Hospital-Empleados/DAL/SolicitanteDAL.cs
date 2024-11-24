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
    public class SolicitanteDAL
    {
        private string connectionString;

        public SolicitanteDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }
        public void CrearSolicitante(Solicitante solicitante)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearSolicitante", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@Nombre", solicitante.Nombre);
                    cmd.Parameters.AddWithValue("@Curriculo", solicitante.Curriculo);
                    cmd.Parameters.AddWithValue("@Correo", solicitante.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", solicitante.Telefono);
                    cmd.Parameters.AddWithValue("@Sexo", solicitante.Sexo);
                    cmd.Parameters.AddWithValue("@Direccion", solicitante.Direccion);
                    cmd.Parameters.AddWithValue("@IdVacante", solicitante.IdVacante);
                    cmd.Parameters.AddWithValue("@Estado", solicitante.Estado);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", solicitante.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", solicitante.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", solicitante.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", solicitante.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear solicitante: " + ex.Message);
            }
        }

        public List<Solicitante> LeerASolicitante()
        {
            List<Solicitante> solicitantes = new List<Solicitante>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarSolicitantes", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Solicitante solicitante = new Solicitante
                        {
                            IdSolicitante = (int)reader["IdDisciplina"],
                            Nombre = (string)reader["Nombre"],
                            Curriculo = (string)reader["Curriculo"],
                            Correo = (string)reader["Correo"],
                            Telefono = (string)reader["Telefono"],
                            Sexo = (string)reader["Sexo"],
                            Direccion = (string)reader["Direccion"],
                            IdVacante = (int)reader["IdVacante"],
                            Estado = (string)reader["Estado"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        solicitantes.Add(solicitante);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer solicitante: " + ex.Message);
            }
            return solicitantes;
        }

        public void ActualizarSolicitante( Solicitante solicitante)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarSolicitante", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@Nombre", solicitante.Nombre);
                    cmd.Parameters.AddWithValue("@Curriculo", solicitante.Curriculo);
                    cmd.Parameters.AddWithValue("@Correo", solicitante.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", solicitante.Telefono);
                    cmd.Parameters.AddWithValue("@Sexo", solicitante.Sexo);
                    cmd.Parameters.AddWithValue("@Direccion", solicitante.Direccion);
                    cmd.Parameters.AddWithValue("@IdVacante", solicitante.IdVacante);
                    cmd.Parameters.AddWithValue("@Estado", solicitante.Estado);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", solicitante.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", solicitante.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", solicitante.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", solicitante.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar solicitante: " + ex.Message);
            }
        }

        public void EliminarDisciplina(int idSolicitante)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarSolicitante", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdSolicitante", idSolicitante);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar solicitante: " + ex.Message);
            }
        }
    }
}