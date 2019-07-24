using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal4
    {
        public Soal4(int input)// constructor== menampung input dari class lain, menjalankan method void
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number = 1;
            //array variabel yg banyak isi nya
            int[] arrayInt = new int[input];
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = number;
                number += 3;
                Console.Write(arrayInt[i] + "\t");
            }
            
            Console.WriteLine("\n");
        }
    }
}
