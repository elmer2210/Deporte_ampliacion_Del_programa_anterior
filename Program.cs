using System;

namespace deporte
{
    public class GeneradorAutomaticoIdentificacion
    {
        readonly Random random = new Random();
        public int Id {get; set;}
        public GeneradorAutomaticoIdentificacion()
        {
            Id = random.Next();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Deportes");

            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey();            

            Jugadores jugador = new Jugadores{
                NombreApellido = "Juan Palmiño",
                Edad = 19,
                Estatura = 1.89,
                PosicionJuego = "Delantero Central",
            };

            Console.WriteLine(jugador.Presentarse());
            Console.WriteLine(jugador.EquipoPertenece());
            Console.WriteLine(jugador.DeportePractica());

            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey();

            Tecnicos entrenador = new Tecnicos{
                NombreApellido = "Pablo Parez",
                AñosProfesión = 15, 
                Edad = 45,
            };

            Console.WriteLine (entrenador.Saludar());
            Console.WriteLine (entrenador.DeporteEnseña());
            Console.WriteLine (entrenador.EquiposCargo());
            Console.WriteLine  (entrenador.EstuiantesCargo(jugador.NombreApellido));

            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey();

            Deporte deportes = new Deporte("Futbol", "Balonpie", "90 minutos");

            Console.WriteLine(deportes.PresentarDeporte()); 

            Equipo equipos = new Equipo {
                Nombre = "Los pollitos criollos",
                Capitan = "Leone Messi"
            };

            Console.WriteLine(equipos.PresentarEquipo());
         



        }
        
    }


}
