using System;
using System.Collections.Generic;
using System.Text;

namespace Övningsuppgifter_1___Grunden
{
    class Övningar1
    {
        public static void Add2()
        {
            // 1. Skriv en konsolapplikation som adderar två heltal och skriver ut resultatet.
            
            Console.Write("Vad är ditt första heltal? ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Vad är ditt andra heltal? ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        }
        public static void Add3()
        {
            // 2.Skriv en konsolapplikation som adderar 3 heltal och dubblar resultatet innan det skrivs ut.
            
            Console.Write("Vad är ditt första nummer? ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vad är ditt andra nummer? ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vad är ditt tredje nummer? ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"({num1} + {num2} + {num3}) * 2 = {(num1 + num2 + num3) * 2}");
        }
        public static void NamnInput()
        {
            
            // 3.Skriv en konsolapplikation som frågar efter användarens namn och sedan använder namnet 
            // för att skriva ut ”Hej Johan” då man anger Johan som användarens namn.
            Console.WriteLine("Vad är ditt namn?");
            String namn = Console.ReadLine();
            Console.WriteLine($"Hej {namn}");
        }
        public static void TriArea()
        {
            // 4.Skriv ett program som beräknar arean av en triangel med mått som användaren matat in.
            // area = 0.5 * b * h
            // where b is the length of the base of the triangle, and h is the height
            
            float bas, height;

            Console.WriteLine("Vad är triangelns bas?");
            bas = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Vad är triangelsn höjd?");
            height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Triangelns area är (0.5 * bas * höjd): 0.5 * {bas} * {height} = {(bas * height) * 0.5}");
        }
        public static void MultTre()
        {
            // 5.Skriv en applikation som tar TRE nummer från användare, 
            // multiplicerar dessa och sedan skriver hela formeln. Ex ”1 x 2 x 3 = 6”

            Console.WriteLine("Vad är ditt första nummer?");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vad är ditt andra nummer?");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vad är ditt tredje nummer?");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Interpolation
            Console.WriteLine($"{num1} * {num2} * {num3} = {num1 * num2 * num3}");
            // Concatination
            Console.WriteLine(num1 + " * " + num2 + " * " + num3 + " = " + num1 * num2 * num3);
            // Placeholders
            Console.WriteLine("{0} * {1} * {2} = " + num1 * num2 * num3, num1, num2, num3);

        }
        public static void Medel()
        {
            // 6.Skriv ett program som beräknar medeltalet för 4 tal användaren matar in.

            Console.WriteLine("Vad är ditt första nummer?");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Vad är ditt andra nummer?");
            float num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Vad är ditt tredje nummer?");
            float num3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Vad är ditt fjärdje nummer?");
            float num4 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Medelvärdet av {num1}, {num2}, {num3}, {num4} = {(num1 + num2 + num3 + num4) / 4}");

        }
        public static void MatteParentes()
        {
            // 7.Skriv ett program som tar 3 tal från användaren och sedan visar resultatet av beräkningen
            // (tal1 + tal2) * tal3, 
            // samt även resultatet av beräkningen tal1*tal3 + tal2 * tal3.

            Console.WriteLine("Vad är ditt första nummer?");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Vad är ditt andra nummer?");
            float num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Vad är ditt tredje nummer?");
            float num3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"(tal1 + tal2) * tal3 = {(num1 + num2) * num3}");
            Console.WriteLine($"(tal1 * tal3) + (tal2 * tal3) = {(num1 * num3) + (num2 * num3)}");

        }
        public static void TreBokstaver()
        {
            // 8. Skriv ett program som ber användaren om tre bokstäver (en i taget) 
            // och sedan skriver ut dessa i omvänd ordning från hur användaren matade in dessa.

            Console.WriteLine("Vad är din första bokstav?");
            char bokst1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Vad är din andra bokstav??");
            char bokst2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Vad är din tredje bokstav??");
            char bokst3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Orginal ordning: {bokst1}, {bokst2}, {bokst3}");
            Console.WriteLine($"Omvänd ordning: {bokst3}, {bokst2}, {bokst1}");
        }
        public static void BytValue()
        {
            // 9. Skriv ett program som ber användaren mata in två tal som sparas ner i varsin variabel 
            // och sedan skriver ut båda talen i konsolfönstret. Sedan ska variablerna byta värde med 
            // varandra och sedan skriva ut sina tal till konsolfönstret igen.

            Console.WriteLine("Vad är ditt första nummer?");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Vad är ditt andra nummer?");
            float num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Skriver ut talen: num1 = {num1}, num2 = {num2}");

            float temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"Nu har de bytt ställen: num1 = {num1}, num2 = {num2}");
        }
        public static void MultiTabell()
        {
            // 10.Skriv ett program som ber användaren mata in ett tal som sedan ska få sin multiplikationstabell 
            // från 0 till 10 utskriven i konsolfönstret.
            
            Console.WriteLine("Vilken multiplikationstabell önskar du dig?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Här finns din multiplikationstabell ({num1}):"); 

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num1 * i);
            }
        }
        public static void AllOperators()
        {
            // 11.Skriv ett program som ber användaren mata in två tal som sedan kommer att 
            // adderas, subtraheras, multipliceras, divideras, restprodukt uträknad, och presenterad i konsolfönstret.
           
            Console.WriteLine("Vad är ditt första nummer?");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Vad är ditt andra nummer?");
            float num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Addition:\t{num1} + {num2} = {num1+num2}");
            Console.WriteLine($"Subtraktion:\t{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplikation:\t{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"Division:\t{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"Modulus:\t{num1} modulos {num2} = {num1 % num2}");
        }
        public static void TreStrings()
        {
            // 12.Skriv ett program som ber användaren mata in en valfri sträng som sedan skriver 
            // ut strängen tre gånger efter varandra på två olika rader. 
            // Den ena gången utan mellanslag mellan strängarna, 
            // den andra helt utan mellanslag mellan.
            // a.Skriv en lösning där du använder Console.WriteLine().
            // b.Skriv en lösning där du använder $().
            
            Console.WriteLine("Vad väljer du för sträng?");
            String myString = Console.ReadLine();
            Console.WriteLine($"{myString}{myString}{myString}");
            Console.WriteLine(myString + " " + myString + " " + myString);

        }
        public static void Temperatur()
        {
            // 13.Skriv ett program som ber användaren mata in ett tal som representerar grader i celsius 
            // och sedan konverterar värdet till både Fahrenheit och Kevlin. Presentera resultatet i konsolfönstret.
            
            Console.WriteLine("Vilken temperatur i Celcius vill du konvertera?");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double farenheit = (celcius * 1.8000) + 32.00;
            Console.WriteLine($"{celcius} degrees Celcius = {farenheit} degrees Farenheit");

            double kelvin = celcius + 273.15;
            Console.WriteLine($"{celcius} degrees Celcius = {kelvin} degrees Kelvin");

        }
        public static void SkrivPi()
        {
            // 14.Med hjälp av Math - bibliotektet; skriv ut PI i konsolfönstret.

            double pi = Math.PI;
            Console.WriteLine($"Värdet på PI är: {Math.Round(pi, 4)}");
        }

    }
}
