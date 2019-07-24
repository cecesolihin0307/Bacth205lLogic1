using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class SoalBonus2
    {
        public SoalBonus2(int input, int inputNumber)// constructor== menampung input dari class lain, menjalankan method void
        {
            Hasil(input, inputNumber);
        }
        static void Hasil(int input, int inputNumber)
        {
            //int number = 4;

            //array variabel yg banyak isi nya
            String[] deret = new String[input];
            for (int i = 0; i < deret.Length; i++)
            {

                if ((i + 1) % 3 == 0)
                {
                    deret[i] = "*";
                }
                else
                {
                    deret[i] = inputNumber.ToString();
                    inputNumber *= 4;
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
