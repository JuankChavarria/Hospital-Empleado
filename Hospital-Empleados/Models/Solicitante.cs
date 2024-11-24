using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace Hospital_Empleados.Models
{
    public class Solicitante
    {
        public int IdSolicitante { get; set; }
        public string Nombre { get; set; }
        public string Curriculo { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Direccion {  get; set; }
        public int IdVacante { get; set; }
        public string Estado { get; set; }
        public string AdicionadoPor { get; set; }
        public DateTime FechaAdicion { get; set; } = DateTime.Now;
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
        public Solicitante() { }

        public Solicitante(int idSolicitante, string nombre, string curriculo, string correo, string telefono, string sexo, string direccion, int idVacante, string estado, string adicionadoPor, DateTime fechaAdicion, string modificadoPor, DateTime? fechaModificacion)
        {
            IdSolicitante = idSolicitante;
            Nombre = nombre;
            Curriculo = curriculo;
            Correo = correo;
            Telefono = telefono;
            Sexo = sexo;
            Direccion = direccion;
            IdVacante = idVacante;
            Estado = estado;
            AdicionadoPor = adicionadoPor;
            FechaAdicion = fechaAdicion;
            ModificadoPor = modificadoPor;
            FechaModificacion = fechaModificacion;
        }
    }
}