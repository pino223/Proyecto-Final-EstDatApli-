using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_arbol
{
    internal class arbol
    {
        public nodoarbol raiz;
        private nodoarbol obs;

        public void Insertar(int v)
        {
            nodoarbol nuevo, psave;
            Boolean Found=false;
            psave = obs;
            Found = FindKey(v);
            if (Found)
            {
                Console.WriteLine("El nodo ya existe");   
                obs = psave;
            }
            else
            {
               nuevo = new nodoarbol(v);
                if (raiz == null)
                {
                    raiz = nuevo;
                    obs = nuevo;
                }
                else
                {
                    if (v < obs.valor)
                        obs.izq = nuevo;
                    else
                        obs.der = nuevo;
                }
            }

        }
        private bool FindKey(int v)
        {
            Boolean Found=false;
            nodoarbol q;
            q = raiz;
            while (!Found && q != null)
            {
                if(v == q.valor)
                {
                    obs = q;
                    Found = true;
                }
                else
                {
                    if(v < q.valor)
                    {
                        if(q.izq == null)
                            obs = q;
                        q = q.izq;
                    }
                    else
                    {
                        if (q.der == null)
                            obs = q;
                        q = q.der;
                    }
                }
            }
            return Found;
        }
        public void Recorrido(nodoarbol q)
        {
            if(q != null)
            {
                Console.Write($"{q.valor},");
                Recorrido(q.izq);
                Console.Write($"{q.valor},");
                Recorrido(q.der);
                Console.Write($"{q.valor}."); 
            }

        }

        public int Tamaño(nodoarbol q)
        {
            if (q == null)
                return 0;
            else
                return 1 + Tamaño(q.izq) + Tamaño(q.der);
        }


        public int Altura(nodoarbol q)
        {
            if (q == null)
                return 0;
            else
            {
                int alturaIzq = Altura(q.izq);
                int alturaDer = Altura(q.der);
                return 1 + Math.Max(alturaIzq, alturaDer);
            }
        }
        public double LRP()
        {
            var resultado = CalcularLRP(raiz, 1); 
            return resultado.TotalLongitud / resultado.TotalNodos;
        }

        private (double TotalLongitud, int TotalNodos) CalcularLRP(nodoarbol q, int nivel)
        {
            if (q == null)
                return (0, 0);

            var nodosIzq = CalcularLRP(q.izq, nivel + 1);
            var nodosDer = CalcularLRP(q.der, nivel + 1);

            return (
                nivel + nodosIzq.TotalLongitud + nodosDer.TotalLongitud,
                1 + nodosIzq.TotalNodos + nodosDer.TotalNodos
            );
        }



    }
}
