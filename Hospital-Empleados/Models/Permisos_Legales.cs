using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Permisos_Legales
    {
        public int IdPermiso { get; set; }
        public int IdEmpleado { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;


        public Permisos_Legales() { }

        public Permisos_Legales(int idPermiso, int idEmpleado, string tipo, DateTime fechaInicio, DateTime fechaFin, string descripcion, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdPermiso = idPermiso;
            IdEmpleado = idEmpleado;
            Tipo = tipo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Descripcion = descripcion;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}