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
    public class DiciplinaDaL
    {

        private string connectionString;

        public DiciplinaDaL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }
        public void CrearDisciplina(Disciplina disciplina)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearDiciplina", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", disciplina.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Tipo", disciplina.Tipo);
                    cmd.Parameters.AddWithValue("@Fecha", disciplina.Fecha);
                    cmd.Parameters.AddWithValue("@Descripcion", disciplina.Descripcion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", disciplina.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", disciplina.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", disciplina.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", disciplina.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear disciplina: " + ex.Message);
            }
        }

        public List<Disciplina> LeerADisciplina()
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarDiciplinas", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Disciplina disciplina = new Disciplina
                        {
                            IdDisciplina = (int)reader["IdDisciplina"],
                            IdEmpleado = (int)reader["IdEmpleado"],
                            Fecha = (DateTime)reader["Fecha"],
                            Descripcion = (string)reader["Descripcion"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        disciplinas.Add(disciplina);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer disciplina: " + ex.Message);
            }
            return disciplinas;
        }

        public void ActualizarDisciplina(Disciplina disciplina)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarDisciplina", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", disciplina.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Tipo", disciplina.Tipo);
                    cmd.Parameters.AddWithValue("@Fecha", disciplina.Fecha);
                    cmd.Parameters.AddWithValue("@Descripcion", disciplina.Descripcion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", disciplina.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", disciplina.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", disciplina.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", disciplina.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar disciplina: " + ex.Message);
            }
        }

        public void EliminarDisciplina(int idDisciplina)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarDisciplina", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdDiscplina", idDisciplina);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar disciplina: " + ex.Message);
            }
        }

    }
    }