﻿using System.Text;

namespace _18July22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] masyvas = { 5, 3, 7, 6, 8, 7, 10 };
            //Rykiavimas(masyvas);
            var input = Console.ReadLine();
            var mas = input.Split("");
            var character = Console.ReadKey();
            var character1 = Console.ReadKey();
            var character2 = Console.ReadKey();
            //char[] mas = { character , character2, character1 };
            ABCsort(mas);


        }

        /*   1.    Duotas vienatis sveikų skaičių masyvas.
      Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
      { 5, 3, 7, 6, 8, 7, 10 }
      rezultatas:  3 */

        public static int MaziausiasSkaicius(int[] mas)
        {

            int min = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];

                }

            }
            return min;
        }
        /* 2. ## Rasti didžiausią ##
       Duotas vienatis sveikų skaičių masyvas. 
       Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
       { 5, 3, 7, 6, 8, 7, 10 }
       rezultatas:  10 */

        public static int DidziausiasSkaicius(int[] mas)
        {

            int max = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];

                }

            }
            return max;
        }
        public static int[] Rykiavimas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }


            Console.WriteLine(String.Join(",", mas)); 
            return mas;
        }

        public static string[] ABCsort(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }

            string mas2 = String.Join(",", mas);
            var mas3 = mas2.Split(',');
            Console.WriteLine(mas3);
            return mas3;
        }





    }
}