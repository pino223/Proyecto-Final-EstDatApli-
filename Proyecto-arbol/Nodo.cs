using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_arbol
{
    internal class Nodo
    {
        private int valor;
        private Nodo sig;
        public Nodo(int valor)
        {
            Valor = valor;
            sig = null;
        }
        public int Valor { get => valor; set => valor = value; }
        internal Nodo Sig { get => sig; set => sig = value; }
    }
}
