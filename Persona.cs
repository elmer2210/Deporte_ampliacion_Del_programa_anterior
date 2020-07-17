namespace deporte
{
    abstract class Persona : GeneradorAutomaticoIdentificacion
    {
        public string NombreApellido {get; set; }
        public int Edad {get; set;}
        public Persona():base()
        {
            
        }
        public virtual string Hablar ( ){
            return $"Hola mi id es {Id} y soy conocido como {NombreApellido} tengo {Edad} un gusto";
        }
    }
}