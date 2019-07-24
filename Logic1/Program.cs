using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer = "Y";
            while (answer.ToUpper() == "Y")
            {
                try
                {
                    TipeSoal();
                    Console.Write("Masukan nomor soal         : ");
                    int soal = int.Parse(Console.ReadLine());

                    Console.Write("Masukan nomor input Lenght : ");
                    int input = int.Parse(Console.ReadLine());

                    int inputNumber = 0;
                    if (soal == 12)
                    {
                        Console.Write("Masukan nomor input Number: ");
                        inputNumber = int.Parse(Console.ReadLine());
                    }
                    switch (soal)
                    {
                        case 1:
                            Soal1 soal1 = new Soal1(input);
                            break;
                        case 2:
                            Soal2 soal2 = new Soal2(input);
                            break;
                        case 3:
                            Soal3 soal3 = new Soal3(input);
                            break;
                        case 4:
                            Soal4 soal4 = new Soal4(input);
                            break;
                        case 5:
                            Soal5 soal5 = new Soal5(input);
                            break;
                        case 6:
                            Soal6 soal6 = new Soal6(input);
                            break;
                        case 7:
                            Soal7 soal7 = new Soal7(input);
                            break;
                        case 8:
                            Soal8 soal8 = new Soal8(input);
                            break;
                        case 9:
                            Soal9 soal9 = new Soal9(input);
                            break;
                        case 10:
                            Soal10 soal10 = new Soal10(input);
                            break;
                        case 11:
                            SoalBonus bonus = new SoalBonus(input);
                            break;
                        case 12:
                            SoalBonus2 bonus2 = new SoalBonus2(input, inputNumber);
                            break;
                        case 13:
                            Soal13 soal13 = new Soal13(input);
                            break;
                        case 14:
                            Soal14 soal14 = new Soal14(input);
                            break;
                        case 15:
                            Soal15 soal15 = new Soal15(input);
                            break;
                        case 16:
                            Soal16 soal16 = new Soal16(input);
                            break;
                        case 17:
                            Soal17 soal17 = new Soal17(input);
                            break;
                        case 18:
                            Soal18 soal18 = new Soal18(input);
                            break;
                        default:
                            Console.WriteLine("no soal tidak ada");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                Console.WriteLine("\n");
                Console.WriteLine("Continue (y)");
                answer = Console.ReadLine();
                Console.Clear();
            }
        }
        public static void TipeSoal()
        {
            Console.WriteLine("================Terdapat beberapa tipe soal=====================");
            Console.WriteLine("Soal 1 ----> 1	3	5	7	9	11	13 ");
            Console.WriteLine("Soal 2 ----> 2	4	6	8	10	12	14 ");
            Console.WriteLine("Soal 3 ----> 1	4	7	10	13	16	19 ");
            Console.WriteLine("Soal 4 ----> 1	4	7	10	13	16	19 ");
            Console.WriteLine("Soal 5 ----> 1	5	*	9	13	*	17 ");
            Console.WriteLine("Soal 6 ----> 1	5	*	13	17	*	25	29	*	37 ");
            Console.WriteLine("Soal 7 ----> 2	4	8	16	32	64	128 ");
            Console.WriteLine("Soal 8 ----> 3	9	27	81	243	729	2187 ");
            Console.WriteLine("Soal 9 ----> 4	16	*	64	256	*	1024 ");
            Console.WriteLine("Soal 10 ---> 3	9	27	XXX	243	729	2187  ");
            Console.WriteLine("Soal 11 ---> 1	2	6	7	11	12	16 ");
            Console.WriteLine("Soal 12 ---> 3	12	*	48	192	*	768 ");
            Console.WriteLine("Soal 13 ---> 1	1	1	3	5	9	17	31	57 ");
            Console.WriteLine("Soal 14 ---> 2	3	5	7	11	13	17	19	23 ");
            Console.WriteLine("Soal 15 ---> A	B	C	D	E	F	G	H	I ");
            Console.WriteLine("Soal 16 ---> 0	1	8	27	64	125	216	343	512 ");
            Console.WriteLine("Soal 17 ---> 1	2	9	4	5	36	7	8	81	10	11	144 ");
            Console.WriteLine("Soal 18 ---> 1	3	25	999	9	121	13	999	289	19	21	999 ");
            Console.WriteLine("Soal 19 --->  ");
            Console.WriteLine("======================================================================");
        }
    }
}
