using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_arbol
{
    internal class Cola
    {

        private Nodo inicio;
        private int count = 0;
        private int MAX;

        public Cola(int max)
        {
            MAX = max;
            inicio = null;
        }

        private bool underflow()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        private bool overflow()
        {
            if (count == MAX)
                return true;
            else
                return false;
        }

        public void Print()
        {
            if (underflow())
            {
                Console.WriteLine("La cola esta vacia");
                return;
            }
            Nodo act = inicio;
            Console.WriteLine("Los elementos de la cola son:");
            while (act != null)
            {
                Console.Write(act.Valor + " ");
                act = act.Sig;
            }
            Console.WriteLine();

        }

        public int Count()
        {
            Nodo act = inicio;
            count = 0;
            while (act != null)
            {
                count++;
                act = act.Sig;
            }
            Console.WriteLine($"La cola tiene {count} Nodos");
            return count;
        }

        public bool Insert(int num)
        {
            if (overflow())
            {
                Console.WriteLine("La cola esta llena");
                return false;
            }
            else
            {
                Nodo nuevoNodo = new Nodo(num);
                if (underflow())
                {
                    inicio = nuevoNodo;
                }
                else
                {
                    Nodo act = inicio;
                    while (act.Sig != null)
                    {
                        act = act.Sig;
                    }
                    act.Sig = nuevoNodo;
                }
                count++;
                return true;
            }
        }

        public int Extract()
        {
            if (underflow())
            {
                Console.WriteLine("No se pudo extraer");
                return -1;
            }

            int valor = inicio.Valor;
            inicio = inicio.Sig;
            count--;
            Console.WriteLine($"Elemento extraído: {valor}");
            return valor;
        }
    }
}
