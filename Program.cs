using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling_new
{



    internal class ProgramNew



    {
       // private static readonly object CzyPusty;

        class Sprawdzenia
        {
            public string str;
            public int points;

            public void CzyPusty()
            {

                //str = Console.ReadLine();
                while (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Nic nie wprowadzono!");
                    str = Console.ReadLine();

                }
            }



            public void CzyLiczba()
            {
                str = Console.ReadLine();

                CzyPusty();
                int i = 0;

                while (i <= str.Length - 1)
                {

                    if (!char.IsNumber(str, i)) // jesli jest literą
                    {
                        Console.WriteLine("Podałeś niewłaściwą wartość. Podaj liczbę całkowitą");
                        str = Console.ReadLine();

                        CzyPusty();
                        i = 0;
                    }

                    else
                    {
                        i++;
                    }
                }
            }


            public void Max10()
            {

                points = Convert.ToInt32(str);

                while(points > 10)
                {
                    Console.WriteLine("Jest 10 kręgli. Nie oszukuj!:) Wpisz poprawną wartość");
                    str = Console.ReadLine();
                    CzyPusty();
                    CzyLiczba();
                    points = Convert.ToInt16(Console.ReadLine());


                  
                }

            }


        }


        


        static void Main(string[] args)
        {

            string tablicagora = ("----------------------------------- TABLICA WYNIKÓW ----------------------------------------");
            string tablicalinia = ("--------------------------------------------------------------------------------------------");

            Console.WriteLine("Witamy w programie do zapisywania wyników gry w kręgle");

            Console.ReadLine();

            Console.WriteLine("Wprowadź imię gracza");

           
            Sprawdzenia n = new Sprawdzenia();

            n.str = Console.ReadLine();
            n.CzyPusty();
            string imie = n.str;

            Console.WriteLine("Witaj " + imie + " zaczynamy grę w kręgle. Oddaj pierwszy rzut i wpisz poniżej, liczbę zbitych kręgli");

            n.CzyLiczba();
            n.Max10();

            Console.ReadLine();

            /*

            Console.WriteLine(tablicagora);
            Console.WriteLine(tablicalinia);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(tablicalinia);

            Console.WriteLine("Oddaj kolejny rzut");

            var rzut2 = Console.ReadLine();

            Console.WriteLine(tablicagora);
            Console.WriteLine(tablicalinia);
            Console.WriteLine(rzut1 +" | "+ rzut2);
            Console.WriteLine();
            Console.WriteLine(tablicalinia);

            */





        }
    }
}
