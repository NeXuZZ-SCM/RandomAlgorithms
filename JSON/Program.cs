using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var Persona1 = new Persona()
            {
                DNI = 33488779,
                Nombre = "Juan",
                Apellido = "Lopez",
                Datos = new DatosProfesionales()
                {
                    Carrera = "Analista De Sistemas",
                    Secundario = "Economia y gestion de las organizaciones",
                    ExperienciaEnAños = 10,
                    Nivel = "Semi-Senior"
                }

            };
            var json = JsonConvert.SerializeObject(Persona1);
            Console.WriteLine("ESTO ESTA SERIALIZADO A JSON");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(json);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ahora esta Deserializado");
            Console.ForegroundColor = ConsoleColor.Green;
            var jsonDeserializado = JsonConvert.DeserializeObject(json).ToString();
            Console.WriteLine(jsonDeserializado);


            var JsonToObject = JsonConvert.DeserializeObject<Persona>(json); //(json).ToString();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ahora El JSON vuelve a convertirse a objeto Persona");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(JsonToObject);
            Console.WriteLine("La persona tiene el DNI:{0} Y Su carrera es: {1}", JsonToObject.DNI.ToString(), JsonToObject.Datos.Carrera.ToString());
            

            Console.ReadKey();

        }

    }
    class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DatosProfesionales Datos { get; set; }
    }
    class DatosProfesionales
    {
        public string Carrera { get; set; }
        public string Secundario { get; set; }
        public int ExperienciaEnAños { get; set; }
        public string Nivel { get; set; }
    }
}
