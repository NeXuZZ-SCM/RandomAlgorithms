using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RandomAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string mensaje = "N01234234623ADA_2009P786111234234234OR_234234AQ2333423129U1972727023I";
            var encontrados = Regex.Matches(mensaje, @"([0-9])\d+");

            foreach (Match e in encontrados)
            {
                mensaje = mensaje.Replace(e.Value, " ");
            }
            var saludoFinal = mensaje.Replace(" ","");

            Console.WriteLine(saludoFinal);

            Console.ReadKey();
        }
    }
}
