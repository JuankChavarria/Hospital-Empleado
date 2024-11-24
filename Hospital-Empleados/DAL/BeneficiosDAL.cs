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
    public class BeneficiosDAL
    {
        private string connectionString;

        public BeneficiosDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }

        public void CrearAsistencia(Beneficio beneficio)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearBeneficio", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", beneficio.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Tipo", beneficio.Tipo);
                    cmd.Parameters.AddWithValue("@Valor", beneficio.Valor);
                    cmd.Parameters.AddWithValue("@Descripcion", beneficio.Descripcion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", beneficio.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", beneficio.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", beneficio.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", beneficio.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear beneficio: " + ex.Message);
            }
        }
        public List<Beneficio> LeerUsuarios()
        {
            List<Beneficio> beneficios = new List<Beneficio>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarBeneficio", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Beneficio beneficio = new Beneficio
                        {
                            IdBeneficio = (int)reader["IdBeneficio"],
                            IdEmpleado = (int)reader["IdEmpleado"],
                            Tipo = (string)reader["Tipo"],
                            Valor = (decimal)reader["Valor"],
                            Descripcion = (string)reader["Descripcion"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        beneficios.Add(beneficio);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer asistencia: " + ex.Message);
            }
            return beneficios;
        }

        public void ActualizarBeneficio(Beneficio beneficio)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarBeneficio", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", beneficio.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Tipo", beneficio.Tipo);
                    cmd.Parameters.AddWithValue("@Valor", beneficio.Valor);
                    cmd.Parameters.AddWithValue("@Descripcion", beneficio.Descripcion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", beneficio.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", beneficio.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", beneficio.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", beneficio.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar beneficio: " + ex.Message);
            }
        }

        public void EliminarUsuario(int idBeneficio)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarAsistencia", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdBeneficio", idBeneficio);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar beneficio: " + ex.Message);
            }
        }

    }
}