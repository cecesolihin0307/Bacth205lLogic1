using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal18
    {
        public Soal18(int input)
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number = 1, number2 =1;
            int[] deret = new int[input];
            for (int i = 0; i < deret.Length; i++)
            {
                if ((i + 1) % 3 == 0)
                {
                    number2 = number * number;
                    deret[i] = number2;
                    number += 2;
                }
                else
                {
                    if ((i + 1) % 4 == 0)
                    {
                        deret[i] = 999;
                        number += 2;
                    }
                    else
                    {
                        deret[i] = number;
                        number += 2;
                    }
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
