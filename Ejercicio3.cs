using System;
using System.Collections.Generic;

class Ejercicio3
{
    static List<string> opciones = new List<string>();

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menu de Opciones");
            Console.WriteLine("a-) Agregar un Nuevo Elemento.");
            Console.WriteLine("b-) Actualizar un Elemento Existente.");
            Console.WriteLine("c-) Eliminar un Elemento Existente.");
            Console.WriteLine("d-) Mostrar Elementgos Alfabeticamente (A-Z).");
            Console.WriteLine("e-) Mostrar Elementos Alfabeticamente y en Orden Inverso (Z-A).");
            Console.WriteLine("f-) Cerrar Programa");
            Console.Write("Seleccione una Opcion: ");
            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case 'a':
                    Console.Write("Ingrese el Nuevo Elemento: ");
                    string nuevoElemento = Console.ReadLine();
                    opciones.Add(nuevoElemento);
                    Console.WriteLine("Elemento Agregado Correctamente.");
                    break;
                case 'b':
                    Console.Write("Ingrese el Elemento que Desea Actualizar: ");
                    string elemento = Console.ReadLine();
                    if (opciones.Contains(elemento))
                    {
                        Console.Write("Ingrese el Nuevo Valor Para el Elemento: ");
                        string nuevoValor = Console.ReadLine();
                        int indice = opciones.IndexOf(elemento);
                        opciones[indice] = nuevoValor;
                        Console.WriteLine("Elemento Actualizado Correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("El Elemento no Existe en la Lista.");
                    }
                    break;
                case 'c':
                    Console.Write("Ingrese el Elemento que Desea Eliminar: ");
                    elemento = Console.ReadLine();
                    if (opciones.Contains(elemento))
                    {
                        opciones.Remove(elemento);
                        Console.WriteLine("Elemento Eliminado Correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("El Elemento no Existe en la Lista.");
                    }
                    break;
                case 'd':
                    opciones.Sort();
                    Console.WriteLine("Elementos Ordenados Alfabeticamente (A-Z):");
                    foreach (var item in opciones)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 'e':
                    opciones.Sort();
                    opciones.Reverse();
                    Console.WriteLine("Elementos Ordenados Alfabeticamente y en Orden Inverso (Z-A):");
                    foreach (var item in opciones)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 'f':
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion no Valida. Por Favor, Seleccione una Opcion Valida.");
                    break;
            }

            Console.WriteLine("\nPresione Cualquier Tecla Para Continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

