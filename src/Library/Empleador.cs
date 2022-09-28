
using System;

namespace ClassLibrary
{
    public class Empleador:IUsuario, ICalificacion
    {
        
        public string Telefono{get;set;}
        //Tener Direccion
        public string Direccion{get;set;}
        
        //Tener CalificacionTotal
        public int CalificacionTotal{get;set;}
        //Tener lista de Calificaciones
        
        public void AgregarCalificacion(Calificacion)
        {
            Calificaciones.Add(Calificacion)
            //Agregar Calificacion
        }
        
        public void CalcularCalificacionTotal()
        {
            //Calcular CalificacionTotal
        }
    }
}