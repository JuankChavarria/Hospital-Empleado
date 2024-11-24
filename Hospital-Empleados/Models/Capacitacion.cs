using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Capacitacion
    {    
        public int IdCapacitacion {get; set; }
        public int IdEmpleado {get; set; }
        public string Curso { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string Certificacion { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Capacitacion() { }

        public Capacitacion(int idCapacitacion, int idEmpleado, string adicionadoPor, string curso, DateTime horaInicio, DateTime horaFin, string certificacion, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdCapacitacion = idCapacitacion;
            IdEmpleado = idEmpleado;
            Curso = curso;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            Certificacion = certificacion;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}