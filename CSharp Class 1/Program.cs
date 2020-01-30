//adott "funkcióhalmazt" használni szeretnénk
using System;

//a mi "funkcióhalmazunk"
namespace CSharp_Class_1
{
    //"funkcióhalmazon" belül egy "elem"
    class Program
    {
        //belépési pont
        static void Main(string[] args)
        {
            /*kiírás aztán
              új sor */
            Console.WriteLine("Hello World!");

            //kiírás új sor nélkül
            Console.Write("Hello World!");

            //32 bites egész szám
            int szam32 = 10;
            //64 bites egész szám
            long szam64 = 20L;

            //32 bites tört
            float tort32 = 10.0f;
            //64 bites tört
            double tort64 = 10.0d;

            //16 bites karakter
            char karakter = 'a';
            //tetszőleges hosszúságú karaktersorozat
            string karaktersorozat = "Hello World!";

            //logikai
            bool logikaiIgaz = true;
            bool logikaiHamis = false;

            //egyszerre több változó létrehozása (deklaráció és definíció)
            int a, b = 10, c = 20, d;

            //konstans
            const float PI = 3.14f;

            //var használata
            var v1 = 10;
            var v2 = 10.0;
            var v3 = "Hello";

            //Implicit típuskonverzió
            var v4 = 'a';
            int v5 = v4;
            long v6 = v5;
            float v7 = v6;
            double v8 = v7;

            //Típuskényszerítés
            var v9 = (float)v8;
            var v10 = (long) v9;
            var v11 = (int)v10;
            var v12 = (char)v11;

            //Explicit típuskonverzió
            var v13 = int.Parse("5");
            var v14 = Convert.ToBoolean("true");

            //Bemenet
            var bemenet = Console.ReadLine();
            var bemenetSzam = int.Parse(Console.ReadLine());

            //Operátorok
            var pozitiv = +10;
            var negativ = -10;

            var v15 = 10 + 10;
            var v16 = 10 - 10;
            var v17 = 10 * 10;
            var v18 = 10 / 10;
            var v19 = 10 % 10;

            var v20 = 10;
            v20 += 2;
            v20 -= 2;
            v20 *= 2;
            v20 /= 2;
            v20 %= 2;

            var v21 = 10;
            ++v21;
            --v21;
            v21++;
            v21--;

            var v22 = 10 > 9;
            var v23 = 10 < 9;
            var v24 = 10 >= 9;
            var v25 = 10 <= 9;

            var v26 = 10 == 10;
            var v27 = 10 != 11;

            var v28 = !true;

            var v29 = 10 == 10 || 9 == 8;
            var v30 = 10 == 10 && 9 == 8;
            var v31 = 10 == 6 || (v15 > v16 && v19 < v18 && true) || false;

            //Math
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Pow(2, 3));

            //Stringek
            Console.WriteLine("asd".Length);
            Console.WriteLine("asd".ToUpper());
            Console.WriteLine("asd".ToLower());

            var nev = "Dani";
            var napszak = "estét";
            Console.WriteLine("Hello {0}! Szép {1}!\n", nev, napszak);

            Console.WriteLine($"Hello \"{nev}\"!\t Szép {napszak}!");
        }
    }
}
