using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Beneficio
    {
        public int IdBeneficio { get; set; }
        public int IdEmpleado { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public string Descripcion { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Beneficio() { }

        public Beneficio(int idBeneficio, int idEmpleado, string tipo, decimal valor, string descripcion, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdBeneficio = idBeneficio;
            IdEmpleado = idEmpleado;
            Tipo = tipo;
            Valor = valor;
            Descripcion = descripcion;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}