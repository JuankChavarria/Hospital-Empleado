using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Vacante
    {
        public int IdVacante { get; set; }
        public string Departamento { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;

        public Vacante() { }

        public Vacante(int idVacante, string departamento, string descripcion, string estado, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdVacante = idVacante;
            Departamento = departamento;
            Descripcion = descripcion;
            Estado = estado;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}