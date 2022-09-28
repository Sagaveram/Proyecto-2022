using System;

namespace ClassLibrary
{
    public class Persona
    {
        public string Nombre{get;set;}
        //Tener Nombre
        public string Apellido{get;set;}
        //Tener Apellido
        public string Email{get;set;}
        //Tener Email
        public virtual void CrearPersona()
        {

        }
        //CRUD Rol
        public virtual void ActualizarPersona()
        {

        }
        public virtual void BorrarPersona()
        {

        }
        //Registrar Rol
        public virtual void RegistrarPersona()
        {

        }
    }
}