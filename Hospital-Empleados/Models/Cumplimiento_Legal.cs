using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Cumplimiento_Legal
    {

        public int IdCumplimiento { get; set; }
        public int IdEmpleado { get; set; }
        public string Documento { get; set; }
        public DateTime FechaPresentacion { get; set; }
        public string Descripcion { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;

        public Cumplimiento_Legal() { }

        public Cumplimiento_Legal(int idCumplimiento, int idEmpleado, string documento, DateTime fechaPresentacion, string descripcion, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdCumplimiento = idCumplimiento;
            IdEmpleado = idEmpleado;
            Documento = documento;
            FechaPresentacion = fechaPresentacion;
            Descripcion = descripcion;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}