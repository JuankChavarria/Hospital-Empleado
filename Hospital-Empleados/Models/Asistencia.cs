using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Asistencia
    {
        public int IdAsistencia { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HorasTrabajadas { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;

        public Asistencia() { }

        public Asistencia(int idAsistencia, int idEmpleado, DateTime fecha, DateTime horaEntrada, DateTime horaSalida, DateTime horasTrabajadas, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdAsistencia = idAsistencia;
            IdEmpleado = idEmpleado;
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
            HorasTrabajadas = horasTrabajadas;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}