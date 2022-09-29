using System;

namespace ClassLibrary
{
    public class Resultado
    {
        //Objeto a implementar en un futuro en métodos void para detectar errores; ya que no podemos utilizar excepciones al momento
        public Resultado(){}
        public bool Estado{get;set;}
        //Resultado de operación (bool)
        public string Mensaje{get;set;}
        //Mensaje de error
    }
}