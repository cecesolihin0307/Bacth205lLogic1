using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Soal10
    {
        public Soal10(int input)// constructor== menampung input dari class lain, menjalankan method void
        {
            Hasil(input);
        }
        static void Hasil(int input)
        {
            int number = 3;

            //array variabel yg banyak isi nya
            String[] deret = new String[input];
            for (int i = 0; i < deret.Length; i++)
            {

                if ((i + 1) % 4 == 0)
                {

                    deret[i] = "XXX";
                    number *= 3;

                }
                else
                {
                    deret[i] = number.ToString();
                    number *= 3;
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
