using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_arbol
{
    internal class Lista
    {
        Nodo inicio;
        public Lista()
        {
            inicio = null;
        }

        public void Teclear_Nodo(int num)
        {

            Nodo nuevoNodo = new Nodo(num);
            if (inicio == null)
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
            Console.WriteLine($"Nodo con valor {num} insertado.");
        }
       
        public void Imprimir_Tamaño()
        {
            int contador = 0;
            Nodo act = inicio;
            while (act != null) 
            {
                contador++;
                act = act.Sig;
            }
            if (contador == 0)
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                Console.WriteLine($"La lista tiene {contador} nodos.");
            }
        }
        
        public void Buscar_Nodo(int posicionBuscar)
        {
            Nodo act = inicio;
            int contador = 0;   
            while (act != null && contador < posicionBuscar)  
            {
                act = act.Sig;
                contador++;
            }

            if (act == null)
            {
                Console.WriteLine("Posición no encontrada.");
            }
            else 
            {
                Console.WriteLine($"El nodo en la posición {posicionBuscar} tiene el valor {act.Valor}.");
            }
        }
       
        public void Borrar_Nodo(int posicionBorrar)
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (posicionBorrar == 0)
            {
                inicio = inicio.Sig;  
                Console.WriteLine("Nodo en la posición 1 eliminado.");
                return;
            }

            Nodo act = inicio;
            for (int i = 0; act != null && i < posicionBorrar - 1; i++) 
            {
                act = act.Sig;
            }

            if (act == null || act.Sig == null)
            {
                Console.WriteLine("Posición no encontrada.");
                return;
            }

            Nodo siguiente = act.Sig.Sig; 
            act.Sig = siguiente;  
            Console.WriteLine($"Nodo en la posición {posicionBorrar} eliminado.");
        }
       
        public void Modificar_Nodo(int posicionModificar, int nuevoValor)
        {
            Nodo act = inicio;
            int contador = 0;
            while (act != null && contador < posicionModificar) 
            {
                act = act.Sig;
                contador++;
            }

            if (act == null)
            {
                Console.WriteLine("Posición no encontrada.");
            }
            else
            {
                act.Valor = nuevoValor; 
                Console.WriteLine($"Nodo en la posición {posicionModificar} modificado exitosamente al valor {nuevoValor}.");
            }
        }
       
        public void Buscar_Valor(int valorBuscar)
        {
            Nodo act = inicio;
            int posicion = 0;
            while (act != null)
            {
                if (act.Valor == valorBuscar)
                {
                    Console.WriteLine($"El valor {valorBuscar} se encuentra en la posición {posicion}.");
                    return;
                }
                act = act.Sig;  
                posicion++;
            }
            Console.WriteLine("El valor no se encuentra en la lista.");
        }
        public void Imprimir_Lista()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo act = inicio;
            Console.WriteLine("Valores de la lista:");
            while (act != null)
            {
                Console.Write($"{act.Valor}, ");
                act = act.Sig;
            }
            Console.WriteLine();
        }
    }
}
