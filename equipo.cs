using System;
namespace deporte
{
    public class Equipo : GeneradorAutomaticoIdentificacion
    {
        public string Nombre {get; set;}
        private int NumeroJugadores {get; set;}
        public string Capitan {get; set;}

        public Equipo(): base()
        {
            
        }
        public virtual string PresentarEquipo(){
            return $"# El esquipo es {Nombre} y su capitan es {Capitan}";
        } 
       static  int NumeroIntegrantes(int numero){
           numero = 13;
            return numero;
        }
        
    }
}
