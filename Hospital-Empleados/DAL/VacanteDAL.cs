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
    public class VacanteDAL
    { 

            private string connectionString;

            public VacanteDAL()
            {
                connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
            }
            public void CrearVacante(Vacante vacante)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("sp_CrearVacante", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.AddWithValue("@Departamento", vacante.Departamento);
                        cmd.Parameters.AddWithValue("@Descripcion", vacante.Descripcion);
                        cmd.Parameters.AddWithValue("@Estado", vacante.Estado);
                        cmd.Parameters.AddWithValue("@AdicionadoPor", vacante.AdicionadoPor);
                        cmd.Parameters.AddWithValue("@FechaAdicion", vacante.FechaAdicion);
                        cmd.Parameters.AddWithValue("@ModificadoPor", vacante.ModificadoPor);
                        cmd.Parameters.AddWithValue("@FechaModificacion", vacante.FechaModificacion);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear vacante: " + ex.Message);
                }
            }

            public List<Vacante> LeerAVacante()
            {
                List<Vacante> vacantes = new List<Vacante>();
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("sp_ListarVacantes", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                        Vacante vacante = new Vacante
                        {
                                IdVacante = (int)reader["IdVacante"],
                                Departamento = (string)reader["IdEmpleado"],
                                Descripcion = (string)reader["Descripcion"],
                                Estado = (string)reader["Estado"],
                                AdicionadoPor = (string)reader["AdicionadoPor"],
                                FechaAdicion = (DateTime)reader["FechaAdicion"],
                                ModificadoPor = reader["ModificadoPor"] as string,
                                FechaModificacion = reader["FechaModificacion"] as DateTime?
                            };
                        vacantes.Add(vacante);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al leer vacante: " + ex.Message);
                }
                return vacantes;
            }

            public void ActualizarVacante(Vacante vacante)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("sp_ActualizarVacante", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.AddWithValue("@Departamento", vacante.Departamento);
                    cmd.Parameters.AddWithValue("@Descripcion", vacante.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", vacante.Estado);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", vacante.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", vacante.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", vacante.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", vacante.FechaModificacion);

                    conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar vacante: " + ex.Message);
                }
            }

            public void EliminarVacante(int idVacante)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("sp_EliminarVacante", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.AddWithValue("@IdVacante", idVacante);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar vacante: " + ex.Message);
                }
            }
        }
}