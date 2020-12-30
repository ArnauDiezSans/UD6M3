using System;

namespace UD6M3
{
    class Program
    {
        public static string Voltear(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static void Milestone1()
        {
            //FASE1
            string cad1 = "", cad2 = "", cad3 = "", cad4 = "", cad5 = "", cad6 = "";
            Console.WriteLine("Introdueix d'un en un els següents noms: (Barcelona, Madrid, Valencia, Malaga, Cadis, Santander)");
            cad1 = Console.ReadLine();
            cad2 = Console.ReadLine();
            cad3 = Console.ReadLine();
            cad4 = Console.ReadLine();
            cad5 = Console.ReadLine();
            cad6 = Console.ReadLine();
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", cad1, cad2, cad3, cad4, cad5, cad6);
            Console.WriteLine("");
            //FASE2
            string[] arrayCiutats = new string[6] { cad1, cad2, cad3, cad4, cad5, cad6 };
            Array.Sort(arrayCiutats);
            Console.WriteLine(string.Join(" ,", arrayCiutats));
            Console.WriteLine("");
            //FASE3
            //cad1=cad1.Replace("a", "4");
            string[] arrayCiutatsMod = new string[6];
            //arrayCiutatsMod = arrayCiutats; no funciona perque no copio els valor, sino que faig un punter
            Array.Copy(arrayCiutats, arrayCiutatsMod, arrayCiutats.Length);
            for (int i = 0; i < 6; i++)
            {
                arrayCiutatsMod[i] = arrayCiutatsMod[i].Replace("a", "4");
            }
            //arrayCiutats = new string[6] { cad1, cad2, cad3, cad4, cad5, cad6 };
            Console.WriteLine(string.Join(" ,", arrayCiutatsMod));
            Console.WriteLine("");
            //FASE4
            string[] arrayCiutatsInv = new string[6];
            Array.Copy(arrayCiutats, arrayCiutatsInv, arrayCiutats.Length);
            for (int i = 0; i < 6; i++)
            {
                arrayCiutatsInv[i] = Voltear(arrayCiutatsInv[i]);
            }
            //Console.WriteLine("");
            //Console.WriteLine(arrayCiutatsInv[1]);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ex:" + arrayCiutats[i] + " " + arrayCiutatsInv[i]);
            }
        }
        public static void Milestone2()
        {
            int[,] notes = new int[5, 3];
            for(int i = 0; i < 5; i++)
            {
                for(int x = 0; x < 3; x++)
                {
                    Console.WriteLine("Introdueix la nota {0} de l'alumne {1}", x + 1, i + 1);
                    notes[i, x] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int mitja = 0;
            for (int i = 0; i < 5; i++)
            {
                mitja = (notes[i, 0] + notes[i, 1] + notes[i, 2]) / 3;
                if (mitja >= 5)
                {
                    Console.WriteLine("L'alumne {0} ha aprobat", i + 1);
                }
                else
                {
                    Console.WriteLine("L'alumne {0} ha suspès", i + 1);
                }
            }
        }
        public static void Milestone3()
        {
            int n1=0, n2=1,n3,N;
            Console.WriteLine("Entra la N per a fer la succesió de Fibonacci");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                n3 = n1;
                n1 = n2;
                n2 = n3 + n1;
                Console.WriteLine(n1);
            }

        }
        static void Main(string[] args)
        {
            //Milestone1();
            //Milestone2();
            Milestone3();
        }
    }
}
