using System;
namespace prog
{
    class Matriz
    {
        public static void Main(String[] args)
        {

            int n = 0;
            Console.WriteLine("¿Cuantas Filas?");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantas Columnas?");
            int c = int.Parse(Console.ReadLine());
            int[,] sum = new int[f, c];


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("Introduce Dato en la fila " + i + " columna " + j);
                    sum[i, j] = int.Parse(Console.ReadLine());
                }
            }



            for (int i = 0; i < f; i++)
            {
                Console.WriteLine("   ");
                for (int j = 0; j < c; j++)
                {
                    Console.Write(" " + sum[i, j]);

                }
            }


            for (int i = 0; i < f; i++)
            {

                for (int j = 0; j < c; j++)
                {

                    if (i == j)
                    {
                        n += sum[i, j];
                    }
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine("Suma de la diagonal = " + n);



            Console.ReadKey();
        }

    }
}