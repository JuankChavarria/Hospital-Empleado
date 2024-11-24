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
    public class PermisoDAL
    {
        private string connectionString;

        public PermisoDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }
        public void CrearPermiso(Permisos_Legales permiso)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearPermiso", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", permiso.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Tipo", permiso.Tipo);
                    cmd.Parameters.AddWithValue("@FechaInicio", permiso.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", permiso.FechaFin);
                    cmd.Parameters.AddWithValue("@Descripcion", permiso.Descripcion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", permiso.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", permiso.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", permiso.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", permiso.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear permiso: " + ex.Message);
            }
        }

        public List<Permisos_Legales> LeerAPermiso()
        {
            List<Permisos_Legales> permis = new List<Permisos_Legales>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarPermisos", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Permisos_Legales permiso = new Permisos_Legales
                        {
                            IdEmpleado = (int)reader["IdEmpleado"],
                            Tipo= (string)reader["Tipos"],
                            FechaInicio = (DateTime)reader["FechaInicio"],
                            FechaFin = (DateTime)reader["FechaFin"],
                            Descripcion = (string)reader["Descripcion"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        permis.Add(permiso);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer el permiso: " + ex.Message);
            }
            return permis;
        }

        public void ActualizarPermiso(Permisos_Legales permiso)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarPermiso", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", permiso.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Tipo", permiso.Tipo);
                    cmd.Parameters.AddWithValue("@FechaInicio", permiso.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", permiso.FechaFin);
                    cmd.Parameters.AddWithValue("@Descripcion", permiso.Descripcion);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", permiso.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", permiso.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", permiso.ModificadoPor);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar permiso: " + ex.Message);
            }
        }

        public void EliminarPermiso(int idPermiso)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarPermiso", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdPermiso", idPermiso);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar permiso: " + ex.Message);
            }
        }

    }
}