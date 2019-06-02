using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            var algoViejo = new ProbandoAtributos();
            var algo = new ProbandoAtributo();
            Console.WriteLine(algo);

            Console.ReadKey();

        }
    }
    [Atributo_0("ZARLANGA")]
    class ProbandoAtributo
    {
        public ProbandoAtributo()
        {
            Console.WriteLine("LAAAA LALA");
        }
    }
    [Obsolete("ThisClass is obsolete. Use ThisClass2 instead.")]
    class ProbandoAtributos
    {
        public ProbandoAtributos()
        {
            Console.WriteLine("LAAAA LALA");
        }

    }
}
