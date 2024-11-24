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
    public class NominaDAL
    {

            private string connectionString;

            public NominaDAL()
            {
                connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
            }
            public void CrearNomina(Nomin nomina)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("sp_CrearNomina", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.AddWithValue("@IdEmpleado", nomina.IdEmpleado);
                        cmd.Parameters.AddWithValue("@Mes", nomina.Mes);
                        cmd.Parameters.AddWithValue("@SalarioBase", nomina.SalarioBase);
                        cmd.Parameters.AddWithValue("@HorasExtras", nomina.HorasExtras);
                        cmd.Parameters.AddWithValue("@Deducciones", nomina.Deducciones);
                        cmd.Parameters.AddWithValue("@SalarioNeto", nomina.SalarioNeto);
                        cmd.Parameters.AddWithValue("@AdicionadoPor", nomina.AdicionadoPor);
                        cmd.Parameters.AddWithValue("@FechaAdicion", nomina.FechaAdicion);
                        cmd.Parameters.AddWithValue("@ModificadoPor", nomina.ModificadoPor);
                        cmd.Parameters.AddWithValue("@FechaModificacion", nomina.FechaModificacion);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear nomina: " + ex.Message);
                }
            }

            public List<Nomin> LeerNominas()
            {
                List<Nomin> nomins = new List<Nomin>();
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("sp_ListarNominas", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Nomin nomina = new Nomin
                            {
                                IdEmpleado = (int)reader["IdEmpleado"],
                                Mes = (string)reader["Mes"],
                                SalarioBase = (decimal)reader["SalarioBase"],
                                HorasExtras = (decimal)reader["HorasExtras"],
                                Deducciones = (decimal)reader["Deducciones"],
                                SalarioNeto = (decimal)reader["SalarioNeto"],
                                AdicionadoPor = (string)reader["AdicionadoPor"],
                                FechaAdicion = (DateTime)reader["FechaAdicion"],
                                ModificadoPor = reader["ModificadoPor"] as string,
                                FechaModificacion = reader["FechaModificacion"] as DateTime?
                            };
                        nomins.Add(nomina);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al leer nomina: " + ex.Message);
                }
                return nomins;
            }

            public void ActualizarNomina(Nomin nomina)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("sp_ActualizarNomina", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.AddWithValue("@IdEmpleado", nomina.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Mes", nomina.Mes);
                    cmd.Parameters.AddWithValue("@SalarioBase", nomina.SalarioBase);
                    cmd.Parameters.AddWithValue("@HorasExtras", nomina.HorasExtras);
                    cmd.Parameters.AddWithValue("@Deducciones", nomina.Deducciones);
                    cmd.Parameters.AddWithValue("@SalarioNeto", nomina.SalarioNeto);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", nomina.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", nomina.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", nomina.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", nomina.FechaModificacion);

                    conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar nomina: " + ex.Message);
                }
            }

            public void EliminarNomina(int idNomina)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("sp_EliminarNomina", conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.AddWithValue("@IdNomina", idNomina);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar Nomina: " + ex.Message);
                }
            }
        }
}