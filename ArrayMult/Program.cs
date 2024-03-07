using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            float [,] matrix = new float [2,2];

            matrix[0,0] = args[0];
            matrix[0,1] = args[1];
            matrix[1,0] = args[2];
            matrix[1,1] = args[3];

            float [] vector = new float [2];

            vector[0] = args[4];
            vector[1] = args[5];

            float [] vector_final = new float [2];
            float soma = 0.0;

            //for linhas em amtrix
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    float soma += matrix[i,j] * vector[j];
                }
                vector_final[i] = soma;
                soma = 0.0;
            }  
        }
    }
}
