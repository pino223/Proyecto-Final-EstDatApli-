using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_arbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arbol miArbol = new arbol();
            Cola cola = null;
            Pila stack = null;
            Lista lista = new Lista();
            int opcionPrincipal;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU PROYECTO FINAL\r\n---------------------------------------\r\n1.- Listas\r\n2.- Pilas\r\n3.- Colas\r\n4.- Árboles\r\n5.- Salir\r\n_________________________\r\nSelecciónar Opción => ");
                opcionPrincipal = int.Parse(Console.ReadLine());

                switch (opcionPrincipal)
                {
                    case 1:
                        int opcionListas;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("MENU LISTAS\r\n---------------------------------\r\n1.- Insertar Nodo\r\n2.- Imprimir Tamaño\r\n3.- Buscar Nodo\r\n4.- Borrar Nodo\r\n5.- Modificar Nodo\r\n6.- Buscar Valor\r\n7.- Imprimir Lista\r\n8.- Regresar\r\n_____________________\r\nSelecciónar Opción => ");
                            opcionListas = int.Parse(Console.ReadLine());

                            switch (opcionListas)
                            {
                                case 1:
                                    Console.Write("Teclear valor del nodo: ");
                                    int valor = Convert.ToInt32(Console.ReadLine());
                                    lista.Teclear_Nodo(valor);
                                    break;

                                case 2:
                                    lista.Imprimir_Tamaño();
                                    break;

                                case 3:
                                    Console.Write("Dame la posición del nodo a buscar: ");
                                    int posicionBuscar = Convert.ToInt32(Console.ReadLine());
                                    lista.Buscar_Nodo(posicionBuscar);
                                    break;

                                case 4:
                                    Console.Write("Dame la posición del nodo a borrar: ");
                                    int posicionBorrar = Convert.ToInt32(Console.ReadLine());
                                    lista.Borrar_Nodo(posicionBorrar);
                                    break;

                                case 5:
                                    Console.Write("Dame la posición del nodo a modificar: ");
                                    int posicionModificar = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Dame el nuevo valor: ");
                                    int nuevoValor = Convert.ToInt32(Console.ReadLine());
                                    lista.Modificar_Nodo(posicionModificar, nuevoValor);
                                    break;

                                case 6:
                                    Console.Write("Dame el valor del nodo a buscar: ");
                                    int valorBuscar = Convert.ToInt32(Console.ReadLine());
                                    lista.Buscar_Valor(valorBuscar);
                                    break;
                                case 7:
                                    lista.Imprimir_Lista();
                                    break;
                                case 8:
                                    Console.WriteLine("Regresando al menú principal...");
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                                    break;
                            }

                            if (opcionListas != 8)
                            {
                                Console.WriteLine("Presione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                        } while (opcionListas != 8);
                        break;

                    case 2:
                        int opcionPilas;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("MENU Pilas\r\n---------------------------------\r\n1.- Establecer Tamaño\r\n2.- Push\r\n3.- Pop\r\n4.- Imprimir \r\n5.- Regresar\r\n_____________________\r\nSelecciónar Opción => ");
                            opcionPilas = int.Parse(Console.ReadLine());

                            switch (opcionPilas)
                            {
                                case 1:
                                    Console.Write("Ingresa el tamaño de la pila: ");
                                    int tope = Convert.ToInt32(Console.ReadLine());
                                    stack = new Pila(tope);
                                    Console.WriteLine();
                                    break;

                                case 2:
                                    if (stack == null)
                                    {
                                        Console.WriteLine("Primero llena la pila");
                                    }
                                    else
                                    {
                                        Console.Write("Ingresa el número que quieres insertar: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        if (stack.Push(num))
                                            Console.WriteLine("Elemento insertado correctamente");
                                    }
                                    break;

                                case 3:
                                    if (stack == null)
                                    {
                                        Console.WriteLine("Primero llena la pila");
                                    }
                                    else
                                    {
                                        int popValue = stack.Pop();
                                        if (popValue == -1)
                                            Console.WriteLine("La pila está vacía");
                                        else
                                            Console.WriteLine($"Elemento extraído correctamente: {popValue}");
                                    }
                                    break;

                                case 4:
                                    if (stack == null)
                                    {
                                        Console.WriteLine("Primero llena la pila");
                                    }
                                    else
                                    {
                                        stack.PrintStack();
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("Regresando al menú principal...");
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                                    break;
                            }

                            if (opcionPilas != 5)
                            {
                                Console.WriteLine("Presione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                        } while (opcionPilas != 5);
                        break;

                    case 3:
                        int opcionColas;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("MENU Colas\r\n---------------------------------\r\n1.- Establecer Tamaño\r\n2.- Insert\r\n3.- Extract\r\n4.- Imprimir \r\n5.- Regresar\r\n_____________________\r\nSelecciónar Opción =>");
                            opcionColas = int.Parse(Console.ReadLine());

                            switch (opcionColas)
                            {
                                case 1:
                                    Console.Write("Ingresa el tamaño de la cola: ");
                                    int count = Convert.ToInt32(Console.ReadLine());
                                    cola = new Cola(count);
                                    Console.WriteLine();
                                    break;

                                case 2:
                                    if (cola == null)
                                    {
                                        Console.WriteLine("Primero establece el tamaño de la cola");
                                    }
                                    else
                                    {
                                        Console.Write("Ingresa el número que quieres insertar: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        if (cola.Insert(num))
                                            Console.WriteLine("El elemento se inserto");
                                    }
                                    break;

                                case 3:
                                    if (cola == null)
                                    {
                                        Console.WriteLine("La cola esta vacia");
                                    }
                                    else
                                    {
                                        cola.Extract();
                                        Console.ReadKey();
                                    }
                                    break;

                                case 4:
                                    if (cola == null)
                                    {
                                        Console.WriteLine("La cola está vacía");
                                    }
                                    else
                                    {
                                        cola.Count(); // Llama al método solo si `cola` no es null
                                    }
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    if (cola == null)
                                    {
                                        Console.WriteLine("Primero llena la cola");
                                    }
                                    else
                                    {
                                        cola.Print();
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                                    break;
                            }

                            if (opcionColas != 5)
                            {
                                Console.WriteLine("Presione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                        } while (opcionColas != 5);
                        break;

                    case 4:
                        int opcionArboles;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("MENÚ ÁRBOLES\r\n---------------------------------------\r\n1.- Insertar nodo\r\n2.- Tamaño\r\n3.- Altura\r\n4.- LRP\r\n5.- Recorrido\r\n6.- Regresar\r\n---------------------------------------\r\nSelecciónar Opción => ");
                            opcionArboles = int.Parse(Console.ReadLine());

                            switch (opcionArboles)
                            {
                                case 1:
                                    Console.Write("Ingrese el valor del nodo a insertar: ");
                                    int valor = int.Parse(Console.ReadLine());
                                    miArbol.Insertar(valor);
                                    Console.WriteLine("Nodo insertado correctamente.");
                                    break;
                                case 2:
                                    if (miArbol.raiz == null)
                                    {
                                        Console.WriteLine("Primero inserta nodos en el arbol.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"El tamaño del árbol es: {miArbol.Tamaño(miArbol.raiz)}");
                                    }
                                    break;

                                case 3:
                                    if (miArbol.raiz == null)
                                    {
                                        Console.WriteLine("Primero inserta nodos en el arbol.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"La altura del árbol es: {miArbol.Altura(miArbol.raiz)}");
                                    }
                                    break;

                                case 4:
                                    if (miArbol.raiz == null)
                                    {
                                        Console.WriteLine("Primero inserta nodos en el arbol.");
                                    }
                                    else
                                    {
                                        double lrp = miArbol.LRP();
                                        Console.WriteLine($"La Longitud de Ruta Promedio (LRP) del árbol es: {lrp}");
                                    }
                                    break;

                                case 5:
                                    if (miArbol.raiz == null)
                                    {
                                        Console.WriteLine("Primero inserta nodos en el arbol.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Recorrido en Preorden:");
                                        miArbol.Recorrido(miArbol.raiz);
                                        Console.WriteLine();
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("Regresando al menú principal...");
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                                    break;
                            }

                            if (opcionArboles != 6)
                            {
                                Console.WriteLine("Presione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                        } while (opcionArboles != 6);
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                if (opcionPrincipal != 5)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcionPrincipal != 5);
        }

    }
}
