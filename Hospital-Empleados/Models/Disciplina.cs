using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Disciplina
    {
        public int IdDisciplina { get; set; }
        public int IdEmpleado { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Disciplina() { }

        public Disciplina(int idDisciplina, int idEmpleado, string tipo, DateTime fecha, string descripcion, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdDisciplina = idDisciplina;
            IdEmpleado = idEmpleado;
            Tipo = tipo;
            Fecha = fecha;
            Descripcion = descripcion;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}