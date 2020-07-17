namespace deporte
{
    sealed class Tecnicos :Persona
    {

        public int AñosProfesión {get; set;}

        public Tecnicos():base()
        {
            
        }

        Deporte deporte = new Deporte {
            Nombre = "Basquetboll"
        };

        Equipo equipos = new Equipo {
            Nombre = "Los azules electricos",
            Capitan = "Juan Dionizo",
        };

        public string Saludar (){
            return $"Hola mi nombre es {NombreApellido}, tengo {Edad} y soy tecnico desde hace {AñosProfesión} años ";
        }

        public string DeporteEnseña (){
            return $"Yo ahora imparto conocimintos y estrategias sobre el deporte {deporte.Nombre}";
        }

        public string EquiposCargo(){
            return $"{equipos.Nombre} son los que estan a mi cargo, cuyo capitan es {equipos.Capitan}";
        }

        public string EstuiantesCargo (string nombre){
            return $"{nombre} fue uno de mis alumnos";
        }  
    }
}