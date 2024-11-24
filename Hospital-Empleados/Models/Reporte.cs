using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Reporte
    {
        public int IdReporte { get; set; }
        public int IdEmpleado { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaGeneracion { get; set; } = DateTime.Now;
        public string Autor { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Reporte() { }

        public Reporte(int idReporte, int idEmpleado, string titulo, string descripcion, DateTime? fechaGeneracion, string autor, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdReporte = idReporte;
            IdEmpleado = idEmpleado;
            Titulo = titulo;
            Descripcion = descripcion;
            FechaGeneracion = fechaGeneracion;
            Autor = autor;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}