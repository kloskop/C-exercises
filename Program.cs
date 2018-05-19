using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKloskoHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1(); 

            //Zadanie2();

            //Zadanie3();

            //Zadanie4();

            //Zadanie5();

            //Zadanie6(); //dokończyć!

            //Zadanie7(); //nie działa
           
            Console.ReadKey();    
        }

        private static void Zadanie7()
        {
            List<int> List1 = new List<int>();
            List<int> List2 = new List<int>();

            Console.WriteLine("Podaj kolejne elementy pierwszej listy:");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("podaj liczbę: ");
                List1.Add(int.Parse(Console.ReadLine()));

            }
            List<int> updatedList1 = new List<int>();
            for (int i = 0; i < 9; i++)
            {

                if (List1[i] < 2)
                {
                    updatedList1.Remove(List1[i]);
                }
            }

            foreach (var elem in updatedList1)
            {
                Console.Write(elem + " ");
            }
        } 
        
        private static void Zadanie6()
        {
            try
            {
                Console.Write("Rozmiar tablicy: ");
                int size = int.Parse(Console.ReadLine());
                Console.Write("Maksymalna wartość: ");
                int max = int.Parse(Console.ReadLine());
                int[] Ints = new int[size];

                foreach (var elem in SortingBubble(Ints, max))
                {
                    Console.Write(elem + " ");
                }
            }
            catch
            {
                Console.WriteLine("Nieprawidłowe dane");
            }
        }
          
       private static int[] SortingBubble(int[] tab, int max){
        Random random = new Random();
                try
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        int value = random.Next(0, max - 1);
                        tab[i] = value;

                    }
                    for (int i = 0; i < tab.Length; i++)
                    {
                        for (int j = 0; j < tab.Length - 1; j++)
                        {
                            if (tab[j] > tab[j + 1])
                            {
                                tab = swap(tab, j, j + 1);


                            }
                        }
                    }
                    
                }
                catch { Console.WriteLine("Nieprawidłowe dane"); } return tab; ;

            }
         

        private static int[] swap(int[] tab, int i, int j)
        {
            int temp = tab[i];
            tab[i]=tab[j];
            tab[j] = temp;
            return tab;
        }

        private static void Zadanie5()
        {
            Console.Write("Podaj rozmiar tablicy: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Podaj górny limit wartości w tablicy: ");
            int max = int.Parse(Console.ReadLine());
            int[] Ints = new int[size];

            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                int value = random.Next(0, max - 1);
                Ints[i] = value;

            }
            foreach (var elem in Ints)
            {
                Console.Write(elem + " ");
            }
            
        }

        private static int PowerRecurent(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * PowerRecurent(number - 1);
        }


        private static void Zadanie4()
        {
            //Zad 4 a-b
            string blocker = null;
            Console.WriteLine("Start programu");
            while (blocker != "q")
            {
                Console.WriteLine("\nWpisz q aby zatrzymać program");
                blocker = Console.ReadLine();
            }
            Console.WriteLine("\nPętla Zatrzymana");
            //Zad 4 c

            Console.Write("\nPodaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            int result = 1;
            int n = number;
            while (n > 0)
            {
                result = result * n;
                n--;

            }
            Console.WriteLine("Silnia " + number + "! =" + result);
            Console.WriteLine("Wynik z metody rekurencyjnej: " + PowerRecurent(number));
        }

        private static void Zadanie3()
        {
            try
            {
                Console.Write("Podaj pierwszą liczbę: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Podaj znak operacji [+/-/:/*]: ");
                string sign = Console.ReadLine();

                switch (sign)
                {
                    case "+":
                        int c = a + b;
                        Console.WriteLine(a + "+" + b + "=" + c);
                        break;
                    case "-":
                        int d = a - b;
                        Console.WriteLine(a + "-" + b + "=" + d);
                        break;
                    case ":":
                        int e = a / b;
                        Console.WriteLine(a + ":" + b + "=" + e);
                        break;
                    case "*":
                        int f = a * b;
                        Console.WriteLine(a + "*" + b + "=" + f);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Podano błędną wartość");
            }
        }

        private static void Zadanie2()
        {
            //Zad 2a-d
            Console.Write("Podaj imię: ");
            string Name = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string Surname = Console.ReadLine();
            Console.WriteLine("\nImię: " + Name + "\nNazwisko: " + Surname + "\n");

            //Zad 2e
            try
            {
                Console.Write("Podaj liczbę całkowitą: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Podaj liczbę całkowitą: ");
                int b = int.Parse(Console.ReadLine());
                int c = a + b;
                Console.WriteLine("Suma: " + a + "+" + b + "=" + c + "\n");
            }
            catch
            {
                Console.WriteLine("Podano zmienną nieprawidłowego typu\n");
            }

            //Zad 2f-g
            try
            {
                Console.Write("Podaj liczbę zmiennoprzecinkową: ");
                double d = double.Parse(Console.ReadLine());
                Console.Write("Podaj liczbę zmiennoprzecinkową: ");
                double e = double.Parse(Console.ReadLine());
                double f = d + e;
                Console.WriteLine("Suma: " + d + "+" + e + "=" + f);
            }
            catch
            {
                Console.WriteLine("Podano zmienną nieprawidłowego typu\n");

            }
        }

        private static void Zadanie1()
        {
            double d = 0.25;
            decimal dec = 20000;
            int i = 1;
            char c = 'A';
            string s = "Tekst";
            long l = -2;
            //Zad 1a
            Console.WriteLine("HelloWorld\n");
            //Zad 1b
            Console.WriteLine("Zmienna typu double: d= " + d);
            Console.WriteLine("Wartość max: " + double.MaxValue + "\nWartość min: " + double.MinValue + "\n");
            Console.WriteLine("Zmienna typu decimal: dec= " + dec);
            Console.WriteLine("Wartość max: " + decimal.MaxValue + "\nWartość min: " + decimal.MinValue + "\n");
            Console.WriteLine("Zmienna typu int: i= " + i);
            Console.WriteLine("Wartość max: " + int.MaxValue + "\nWartość min: " + int.MinValue + "\n");
            Console.WriteLine("Zmienna typu char: c= " + c + "\n");
            Console.WriteLine("Zmienna typu string: s= " + s + "\n");
            Console.WriteLine("Zmienna typu long: l= " + l);
            Console.WriteLine("Wartość max: " + long.MaxValue + "\nWartość min: " + long.MinValue + "\n");

        }
    }
}
