using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Evaluaciones
    {
        public int IdEvaluacion { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha {  get; set; }   
        public string Indicadores { get; set; }
        public string Resultado {  get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Evaluaciones() { }

        public Evaluaciones(int idEvaluacion, int idEmpleado, DateTime fecha, string indicadores, string resultado, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdEvaluacion = idEvaluacion;
            IdEmpleado = idEmpleado;
            Fecha = fecha;
            Indicadores = indicadores;
            Resultado = resultado;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}