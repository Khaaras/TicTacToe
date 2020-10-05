using System;
using System.Runtime.CompilerServices;

namespace TicTacToe
{
    public class Program
    {
        static string[] tablica = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string ImieGracza1 = null;
        static string ImieGracza2 = null;
        static bool Winner = false;
        static string CurrentPlayer = null;
       

        public static void Main(string[] args)
        {
            UstawienieImion();          
            Gra();          
            
        }
        static void Gra()
        {
            while (Winner == false)
            {
                if (CurrentPlayer == null)
                {
                    CurrentPlayer = ImieGracza1;
                }

                Ruch();
                SprawdzenieCzyWygrana();
                ZmianaGracza();


            }
            PonownaGra();

        }

        private static void ZmianaGracza()
        {
            if (CurrentPlayer == ImieGracza2)
            {
                CurrentPlayer = ImieGracza1;

            }
            else
            {
                CurrentPlayer = ImieGracza2;
            }
        }

        static void WyswietlTablice()
        {
            Console.WriteLine(" " + tablica[0] + "|" + tablica[1] + "|" + tablica[2]);
            Console.WriteLine(" -----");
            Console.WriteLine(" " + tablica[3] + "|" + tablica[4] + "|" + tablica[5]);
            Console.WriteLine(" -----");
            Console.WriteLine(" " + tablica[6] + "|" + tablica[7] + "|" + tablica[8]);
            
        }

        static void Ruch()
        {
            if (CurrentPlayer == ImieGracza1)
            {
                WyswietlTablice();
                Console.WriteLine("Wybierz pole na, które chcesz postawić X");
                int a = Convert.ToInt32(Console.ReadLine());                
                if (SprawdzenieCzyPoleZajete(a) == false)
                {
                    tablica[a - 1] = "x";
                }
                else
                {
                    Ruch();
                }        

            }
            else
            {
                WyswietlTablice();
                Console.WriteLine("Wybierz pole na, które chcesz postawić O");
                int a = Convert.ToInt32(Console.ReadLine());
                if (SprawdzenieCzyPoleZajete(a) == false)
                {
                    tablica[a - 1] = "o";
                }
                else
                {
                    Ruch();
                }


            }
        }

        static void UstawienieImion()
        {
            Console.WriteLine("Podaj imię gracza pierwszego:");
            ImieGracza1 = Console.ReadLine();

            Console.WriteLine("Podaj imię gracza drugiego:");
            ImieGracza2 = Console.ReadLine();

            Console.WriteLine("Witaj : " + ImieGracza1 + " i " + ImieGracza2);
            Console.WriteLine("Gracz " + ImieGracza1 + " to X a " + ImieGracza2 + "to O");
        }

        static bool SprawdzenieCzyPoleZajete(int pole)
        {
            if (tablica[pole-1] == "x" || tablica[pole-1] == "o")
            {
                Console.WriteLine("Niestety te pole jest już zajęte, spróbuj ponownie");
                return true;
                
            }
            else
            {
                
                return false;
                
            }
        }

        static void SprawdzenieCzyWygrana()
        {
            if (tablica[0] == tablica[1] && tablica[1] == tablica[2])
            {
                Winner = true;
                Console.WriteLine("Wygral gracz : " + CurrentPlayer);
                
            }
            else if (tablica[3] == tablica[4] && tablica[4] == tablica[5])
            {
                Console.WriteLine("Wygral gracz : " + CurrentPlayer);
                Winner = true;
            }
            else if (tablica[6] == tablica[7] && tablica[7] == tablica[8])
            {
                Console.WriteLine("Wygral gracz : " + CurrentPlayer);
                Winner = true;
            }
            else if (tablica[6] == tablica[7] && tablica[7] == tablica[8])
            {
                Console.WriteLine("Wygral gracz : " + CurrentPlayer);
                Winner = true;
            }
            else if (tablica[0] == tablica[3] && tablica[3] == tablica[6])
            {
                Console.WriteLine("Wygral gracz : " + CurrentPlayer);
                Winner = true;
            }
            else if (tablica[1] == tablica[4] && tablica[4] == tablica[7])
            {
                Console.WriteLine("Wygral gracz : " + CurrentPlayer);
                Winner = true;
            }
            else if (tablica[2] == tablica[5] && tablica[5] == tablica[8])
            {
                Console.WriteLine("Wygral gracz : " + CurrentPlayer);
                Winner = true;
            }
            else if (tablica[0] == tablica[4] && tablica[4] == tablica[8])
            {
                Console.WriteLine("Wygral gracz : " + CurrentPlayer);
                Winner = true;
            }
            else if (tablica[2] == tablica[4] && tablica[4] == tablica[6])
            {
                Console.WriteLine("Wygral gracz : " + CurrentPlayer);
                Winner = true;
            }
        }

        static void ResetGry()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = Convert.ToString(i+1);
            }
            CurrentPlayer = null;
            Winner = false;
        }

        static void PonownaGra()
        {
            Console.WriteLine("Chcecie zagrać ponownie? T / N");
            string b = Console.ReadLine();
            if (b == "t")
            {
                Console.WriteLine("Ci sami gracze? T / N");
                b = Console.ReadLine();
                if (b == "t")
                {
                    ResetGry();
                    Gra();
                }
                else if (b == "n")
                {
                    Console.WriteLine("Dzięki za gre" + ImieGracza1 + " " + ImieGracza2);
                    UstawienieImion();
                    ResetGry();
                    Gra();
                    
                }
                else
                {
                    Console.WriteLine("Wciśnij T lub N");
                    PonownaGra();
                }
            }
            else if(b == "n")
            {
                Console.WriteLine("Dzięki za gre");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wciśnij T lub N");
                PonownaGra();
            }
        }

    }

     

}
