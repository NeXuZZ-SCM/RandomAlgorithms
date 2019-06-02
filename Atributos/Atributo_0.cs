using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
    public sealed class Atributo_0 : System.Attribute
    {
        string dato = "";
        public string Dato { get; set; }

        public Atributo_0()
        {
           
        }
        public Atributo_0(string pDato)
        {
            this.dato = pDato;
        }

    }
}
