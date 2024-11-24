using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Recibos_Pagos
    { 
        public int IdReciboPago { get; set; }
        public int IdNomina { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaEmision {  get; set; }
        public string Detalles {  get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Recibos_Pagos() { }
    }
}