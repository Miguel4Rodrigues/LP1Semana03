using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float [,] A = new float [2,2];
            float [,] B = new float [2,1];
            float [,] result = new float [2,1];

            int index = 0;

            // preencher matriz A
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A [i,j] = float.Parse(args[index]);
                    index++;
                }
            
            }
            // preencher vetor B
            for (int i = 0; i < 2; i++)
            {
                B[i,0] = float.Parse(args[index]);
                index++;
            }

            // multiplicação A * B
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                   result[i,j] = 0;

                   for(int k = 0; k < 2; k++)
                    {
                        result[i,j] += A[i,k] * B[k,j];
                    } 
                }
            }
            
            // imprimir resultado
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine($"| {result[i,0],7:F2} |");   
            }
        }
    }
}
