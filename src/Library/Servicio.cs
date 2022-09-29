using System;

namespace ClassLibrary
{
    public class Servicio
    {
        //Tener enum de Categorias
        public Category categoria{get;set;}
        public Payment pago{get;set;}
        public Costo cost{get;set;}

        public decimal costo{get;set;}
        public virtual void CrearServicio()
        {

        }
        //CRUD Rol
        public virtual void ActualizarServicio()
        {

        }
        public virtual void BorrarServicio()
        {

        }
        //Registrar Rol
        public virtual void AgregarCategoria(Category categoria)
        {

        }

    }
}