using System;

namespace TicTacToe
{
    public class Program
    {
        static string[] tablica = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string ImieGracza1 = null;
        static string ImieGracza2 = null;
        static bool Winner = false; 
       

        public static void Main(string[] args)
        {
                 
            

            Console.WriteLine("Podaj imię gracza pierwszego:");
            ImieGracza1 = Console.ReadLine();            

            Console.WriteLine("Podaj imię gracza drugiego:");
            ImieGracza2 = Console.ReadLine();

            Console.WriteLine("Witaj : " + ImieGracza1 + " i " + ImieGracza2);
            Console.WriteLine("Gracz " + ImieGracza1 + " to X a " + ImieGracza2 + "to O");

            asa

            WyswietlTablice();

            //while (Winner == false)
            //{
            //    Console.WriteLine(ImieGracza1 + "Podaj gdzie chcesz postawić X");
            //}
            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    tablica[i] = ".";
            //}

            //Console.WriteLine(tablica[0] + "|" + tablica[1] + "|" + tablica[2]);
            //Console.WriteLine("-----");
            //Console.WriteLine(tablica[3] + "|" + tablica[4] + "|" + tablica[5]);
            //Console.WriteLine("-----");
            //Console.WriteLine(tablica[6] + "|" + tablica[7] + "|" + tablica[8]);
            //Console.ReadKey();

            
            
        }

        public static void WyswietlTablice()
        {
            Console.WriteLine(tablica[0] + "|" + tablica[1] + "|" + tablica[2]);
            Console.WriteLine("-----");
            Console.WriteLine(tablica[3] + "|" + tablica[4] + "|" + tablica[5]);
            Console.WriteLine("-----");
            Console.WriteLine(tablica[6] + "|" + tablica[7] + "|" + tablica[8]);
            Console.ReadKey();
        }

        
    }

}
