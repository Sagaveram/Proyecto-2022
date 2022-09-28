using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class Trabajador:Persona,IUsuario, ICalificacion
    {
        //Tener Telefono
        public string Telefono{get;set;}
        //Tener Direccion
        public string Direccion{get;set;}
        //Tener lista de Servicios
        public List<Servicio> Servicios=new List<Servicio>();
        
        //Tener CalificacionTotal
        public int CalificacionTotal{get;set;}
        //Tener lista de Calificaciones
        public List<Calificacion> Calificaciones=new List<Calificacion>();

        public void AgregarCalificacion(Calificacion calificacion)
        {
            Calificaciones.Add(calificacion);
            //Agregar Calificacion
        }
        
        public void CalcularCalificacionTotal()
        {
            //Calcular CalificacionTotal
        }
        
    }
}