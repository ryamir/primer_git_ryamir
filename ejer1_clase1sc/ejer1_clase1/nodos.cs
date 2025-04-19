using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1_clase1
{
    public class nodos
    {
        public int Valor {  get; set; }
        public nodos siguientes { get; set; }

        public nodos(int valor)
        {
            Valor = valor;
            siguiente=null;
        }
    }


}
