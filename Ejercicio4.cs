using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            //Es la arraylits que pedira los 5 numeros 
            ArrayList num = new ArrayList() { 25, 5, 1, 12, 3, 50};

            //para buscar el valor o numero mayor
            int mayor = int.MinValue;
            int posMar = -1;
            for (int i = 0; i < num.Count; i++)
            {
                int numeroActual = (int)num[i];
                if (numeroActual > mayor)
                {
                    mayor = numeroActual;
                    posMar = i;
                }
            }

            // para buscar el valor o numero menor
            int menor = int.MaxValue;
            int posMer = -1;
            for (int i = 0; i < num.Count; i++)
            {
                int numeroActual = (int)num[i];
                if (numeroActual < menor)
                {
                    menor = numeroActual;
                    posMer = i;
                }
            }

            // para buscar el valor o numero numero de en medio
            num.Sort();
            int numMedio = (int)num[num.Count / 2];
            int posMed = num.Count / 2;

            //como todo programa aqui mostrara los resultados ya predeterminados 
            Console.WriteLine("Número mayor: {0}, encontrado en índice {1}", mayor, posMar);
            Console.WriteLine("Número intermedio {0}, encontrado en el indice {1}", numMedio, posMed);Console.WriteLine("Número menor: {0}, encontrado en indice {1}", menor, posMer);

            //para que muestre los programas :)
            Console.ReadKey();
        }
    }
}
