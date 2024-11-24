using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Nomin
    {
        public int IdNomina { get; set; }
        public int IdEmpleado { get; set; }
        public string Mes { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal Deducciones { get; set; }
        public decimal SalarioNeto { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Nomin() { }

        public Nomin(int idNomina, int idEmpleado, string mes, decimal salarioBase, decimal horasExtras, decimal deducciones, decimal salarioNeto, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdNomina = idNomina;
            IdEmpleado = idEmpleado;
            Mes = mes;
            SalarioBase = salarioBase;
            HorasExtras = horasExtras;
            Deducciones = deducciones;
            SalarioNeto = salarioNeto;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}