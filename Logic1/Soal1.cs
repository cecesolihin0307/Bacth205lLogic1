using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal1
    {
        public Soal1(int input)
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number = 1;
            //array variabel yg banyak isi nya
            int[] deret = new int[input];
            for (int i = 0; i < deret.Length; i++)
            {
                deret[i] = number;
                number += 2;
                Console.Write(deret[i] + "\t");
            }


            Console.WriteLine("\n");
        }
    }
}