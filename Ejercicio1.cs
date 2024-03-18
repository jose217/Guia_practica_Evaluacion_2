namespace Ejercicio1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Digite un numero {0}", i+1);
                string nIngresado = Console.ReadLine();
                int numero = 0;
                if (int.TryParse(nIngresado, out numero))
                {
                    array1[i] = numero;
                    array2[i] = array1[i] * 3;
                }
                else {
                    Console.WriteLine("Error: ingrese un numero");
                    i--;
                }

            }

            string textoArray1 = String.Join(", ", array1);
            string textoArray2 = String.Join(", ", array2);
            Console.WriteLine("Array 1: "+textoArray1+"\n"+"Array 2: "+textoArray2);
        }
    }
}