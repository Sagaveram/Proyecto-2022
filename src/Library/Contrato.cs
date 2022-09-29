using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Contrato
    {
        public Trabajador trabajador{get;set;}
        public Empleador empleador{get;set;}
        public Servicio servicio{get;set;}
        public decimal CostoTotal{get;set;}
        public DateTime FechaFirma{get;set;}
        public DateTime FechaCierre{get;set;}

        public List<Calificacion> calificaciones=new List<Calificacion>();
        public Contrato CrearContrato(Servicio servicio, Empleador empleador)
        {
            return new Contrato();
        }

        public Calificacion AgregarCalificacion()
        {
            return new Calificacion();
        }
        public decimal CalcularCosto()
        {
            return 0m;
        }


    }
}