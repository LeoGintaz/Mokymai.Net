﻿namespace Metodai___
{
    internal class Program
    {
        public static void Main(string[] args)
        {/*
            Sveikinimas();
            Linkejimas();
            Console.WriteLine("enter name : ");
            string vardas = Console.ReadLine();
            Vardenis(vardas);
            Vardenis2(vardas);*/
            /*
            Console.WriteLine("iveskite 2 skaicius");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int sk2 = Convert.ToInt32(Console.ReadLine());
            bool sk1t = int.TryParse(sk1, out sk1);
            Console.WriteLine($" suma {suma(sk1, sk2)}");*/


            Console.WriteLine("iveskite sakini");
            var tarpai = Console.ReadLine();
            Console.Write(Tarpai(tarpai));
            Console.Write(TekstoIlgis(tarpai));

        }

        public static void Sveikinimas()
        {
            Console.WriteLine("Sveiki visi");
        }
        public static void Linkejimas()
        {
            Console.WriteLine("linkiu jum geros dienos");


        }
        public static void Vardenis(string vardas)
        {
            Console.WriteLine("Labas " + vardas);
        }

        public static void Vardenis2(string vardas)
        {
            Console.WriteLine("Linkiu " + vardas + " geros dienos");
        }

        public static int suma(int sk1, int sk2)
        {
           
           return sk1 + sk2;


        }
        public static int Tarpai(string tarpai)
        {     
            string pakitimas = tarpai.Replace(" ","");
            var atimtis = tarpai.Length - pakitimas.Length;
            return atimtis;
                 
        }
        public static int TekstoIlgis(string tarpai)
        {
            string pakitimas = tarpai.Replace(" ", "");
            var atimtis = pakitimas.Length;
            return atimtis;
        }



        }
}