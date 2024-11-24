using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Vacaciones
    { 
        public int IdVacaciones { get; set; }
        public int IdEmpleado { get; set; }
        public int DiasDisponibles { get; set; }
        public int DiasUsados { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado {  get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Vacaciones() { }

        public Vacaciones(int idVacaciones, int idEmpleado, int diasDisponibles, int diasUsados, DateTime fechaSolicitud, DateTime fechaInicio, DateTime fechaFin, string estado, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdVacaciones = idVacaciones;
            IdEmpleado = idEmpleado;
            DiasDisponibles = diasDisponibles;
            DiasUsados = diasUsados;
            FechaSolicitud = fechaSolicitud;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Estado = estado;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}