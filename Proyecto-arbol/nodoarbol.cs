using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_arbol
{
    internal class nodoarbol
    {
        public int valor;
        public nodoarbol izq;
        public nodoarbol der;

        public nodoarbol(int Valor)
        {
            valor = Valor;
            izq = null;
            der = null;
        }
    }
}
