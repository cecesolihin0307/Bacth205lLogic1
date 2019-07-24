using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal17
    {
         public Soal17(int input)
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number = 1, number2 =1;
            int[] deret = new int[input];
            for (int i = 0; i < deret.Length; i++)
            {
                if ((i+1)%3==0)
                {
                    number2 = (i+1)*(i+1);
                    deret[i] = number2;
                    number++;
                }
                else
                {
                    deret[i] = number;
                    number++;
                }
                
                
            }
            for (int i = 0; i < deret.Length; i++)
            {
                Console.Write(deret[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
