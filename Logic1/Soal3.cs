using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal3
    {
        public Soal3(int input)// constructor== menampung input dari class lain, menjalankan method void
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number = 1;
            int[] deret = new int[input];
            for (int i = 0; i < deret.Length; i++)
            {
                deret[i] = number;
                number += 3;
            }
            for (int i = 0; i < deret.Length; i++)
            {
                Console.Write(deret[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
