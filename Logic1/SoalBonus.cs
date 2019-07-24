using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class SoalBonus
    {
        public SoalBonus(int input)
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {

            int[] deret = new int[input];

            int number = 1, number2 = 2;

            for (int i = 0; i < deret.Length; i++)
            {
                if (i % 2 == 0)
                {
                    deret[i] = number;
                    number += 5;
                }
                else
                {
                    deret[i] = number2;
                    number2 += 5;
                }
            }
            for (int i = 0; i < deret.Length; i++)
            {
                Console.Write(deret[i] + "\t");
            }
            Console.WriteLine("\n");
        }
    }
}
