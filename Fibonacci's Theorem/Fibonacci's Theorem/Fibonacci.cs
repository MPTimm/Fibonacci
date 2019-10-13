using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_s_Theorem
{
    class Fibonacci
    {
        private int[] Numeros = new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 };

        public void theorem()
        {
            for(int i = 0; i <= Numeros.Length - 3; i++)
            {
                
                    Numeros[i + 2] = Numeros[i] + Numeros[i + 1];
                

                
            }

            Array.ForEach(Numeros, Console.WriteLine);
        }
    }
}
