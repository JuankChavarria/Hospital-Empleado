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
    public class EmpleadoDAL
    {

        private string connectionString;

        public EmpleadoDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HOSPITAL"].ConnectionString;
        }
        public void CrearEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_CrearEmpleado", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
                    cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                    cmd.Parameters.AddWithValue("@Departamento", empleado.Departamento);
                    cmd.Parameters.AddWithValue("@Salario", empleado.Salario);
                    cmd.Parameters.AddWithValue("@EstadoLaboral", empleado.EstadoLaboral);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", empleado.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", empleado.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", empleado.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", empleado.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear empleado: " + ex.Message);
            }
        }

        public List<Empleado> LeerEmpleado()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarEmpleados", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Empleado empleado = new Empleado
                        {
                            IdEmpleado = (int)reader["IdEmpleado"],
                            Nombre = (string)reader["IdEmpleado"],
                            Direccion = (string)reader["IdEmpleado"],
                            Correo = (string)reader["IdEmpleado"],
                            Telefono = (string)reader["IdEmpleado"],
                            FechaIngreso = (DateTime)reader["Fecha"],
                            Cargo = (string)reader["HoraEntrada"],
                            Departamento = (string)reader["HoraSalida"],
                            Salario = (decimal)reader["HorasTrabajadas"],
                            EstadoLaboral = (string)reader["HorasTrabajadas"],
                            AdicionadoPor = (string)reader["AdicionadoPor"],
                            FechaAdicion = (DateTime)reader["FechaAdicion"],
                            ModificadoPor = reader["ModificadoPor"] as string,
                            FechaModificacion = reader["FechaModificacion"] as DateTime?
                        };
                        empleados.Add(empleado);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer empleado: " + ex.Message);
            }
            return empleados;
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarEmpleado", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@Correo", empleado.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso);
                    cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                    cmd.Parameters.AddWithValue("@Departamento", empleado.Departamento);
                    cmd.Parameters.AddWithValue("@Salario", empleado.Salario);
                    cmd.Parameters.AddWithValue("@EstadoLaboral", empleado.EstadoLaboral);
                    cmd.Parameters.AddWithValue("@AdicionadoPor", empleado.AdicionadoPor);
                    cmd.Parameters.AddWithValue("@FechaAdicion", empleado.FechaAdicion);
                    cmd.Parameters.AddWithValue("@ModificadoPor", empleado.ModificadoPor);
                    cmd.Parameters.AddWithValue("@FechaModificacion", empleado.FechaModificacion);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar empleado: " + ex.Message);
            }
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarEmpleado", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Empleado: " + ex.Message);
            }
        }
    }
}