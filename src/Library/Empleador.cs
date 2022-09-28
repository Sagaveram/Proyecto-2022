
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Empleador:Persona, IUsuario, ICalificacion
    {
        
        public string Telefono{get;set;}
        //Tener Direccion
        public string Direccion{get;set;}
        
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