using System.Collections;

namespace Ejercicio2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            string text = "";
            ArrayList colores = new ArrayList();
            colores.Add("ROJO");
            colores.Add("AZUL");
            colores.Add("MORADO");
            colores.Add("ROSADO");
            colores.Add("GRIS");
            colores.Add("VERDE");
            colores.Add("BLANCO");

            Console.WriteLine("Ingrese un color: ");
            text = Console.ReadLine().ToUpper();

            if (colores.Contains(text))
            {
                Console.WriteLine("El color ingresado es: {0} y existe en la lista", text);
                Console.WriteLine("Ingrese un nuevo dato:");
                string nuevo = Console.ReadLine().ToUpper();

                int i = colores.IndexOf(text);
                colores[i] = nuevo;

                Console.WriteLine("Datos actualizados:");

                foreach (string color in colores)
                {
                    Console.WriteLine(color);
                }
            }
            else {
                Console.WriteLine("El color " + text + " no existe en la lista");
                Console.WriteLine("No se realizaron cambios.");
                Console.WriteLine("Lista de colores: ");
                foreach (string color in colores)
                {
                    Console.WriteLine(color);
                }
            }
        }
    }
}