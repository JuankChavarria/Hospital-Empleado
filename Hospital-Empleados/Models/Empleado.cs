using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Departamento  { get; set; }
        public string EstadoLaboral { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;

        public Empleado() { }

        public Empleado(int idEmpleado, string nombre, string direccion, string correo, string telefono, DateTime fechaIngreso, string cargo, decimal salario, string departamento, string estadoLaboral, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Direccion = direccion;
            Correo = correo;
            Telefono = telefono;
            FechaIngreso = fechaIngreso;
            Cargo = cargo;
            Salario = salario;
            Departamento = departamento;
            EstadoLaboral = estadoLaboral;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}