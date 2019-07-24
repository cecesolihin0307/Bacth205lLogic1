using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal6
    {
        public Soal6(int input)
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number = 1;

            //array variabel yg banyak isi nya
            String[] deret = new String[input];
            for (int i = 0; i < deret.Length; i++)
            {

                if ((i + 1) % 3 == 0)
                {
                    deret[i] = "*";
                    number += 4;
                }
                else
                {
                    deret[i] = number.ToString();
                    number += 4;
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
