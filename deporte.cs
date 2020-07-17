namespace deporte
{
    public class Deporte : GeneradorAutomaticoIdentificacion
    { 
        public string Nombre {get; set;}
        public string TipoDeporte {get; set;}
        public string TiempoJuego {get; set;}
        public Deporte(): base()
        {
            
        }
        public Deporte( string nombre, string tipo, string TiempoJuego): base()
        {
            this.Nombre = nombre;
            this.TipoDeporte = tipo;
            this.TiempoJuego = TiempoJuego;
        }

        public virtual string PresentarDeporte(){
            return $"# El id del{Nombre} es {Id};este es un deporte clasificado como {TipoDeporte} y dura {TiempoJuego}";
        }

    }
}