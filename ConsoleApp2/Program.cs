using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
        //**********REIKIA PATAISYTI***********\\
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.AddMonths(2));
            var LastName ="mangri"
            LastName = 123.ToString();
            Console.WriteLine(LastName + LastName.GetType());
            Console.WriteLine($"{LastName} {LastName.GetType()}");
            Console.WriteLine("{0} {1}", LastName, LastName.GetType());
            Console.WriteLine("enter the first number");
            var first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            var second = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            var third = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Your average is: {(first+second+third)/3}");
        */
            /*   string mokykla = "CodeAcademy";
               string kursas = ".NET_CA.NET3 gr";
               int studentai = 21;
               string data = DateTime.Now.ToString("yyyy-MM-dd");
               DateTime kitasFormatas = DateTime.Parse(data);
               DateTime pradzia = DateTime.Parse("2022-09-05");
               DateTime pabaiga = DateTime.Parse("2023-03-01");
               var dienuSkaicius = (pabaiga - pradzia).Days;
               Console.WriteLine(mokykla);
               Console.WriteLine(data);
               Console.WriteLine(kursas);
               Console.WriteLine(studentai);
               Console.WriteLine(dienuSkaicius);
            */
            //11111111111111111111111111111111111111//
            Console.WriteLine("enter some number");
            var number = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{number} {number} {number} {number}");
            //Console.WriteLine("{0} {0} {0} {0}", number);
            //22222222222222222222222222222222222222//
            int A = 1; int B = 15;
            int C = A; A = B; B = C;
            Console.WriteLine($"A = {A} B = {B}");
            //33333333333333333333333333333333333333//
            Console.WriteLine("enter the first number");
            var first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            var second = Int32.Parse(Console.ReadLine());
            Console.WriteLine(first == second);
            //44444444444444444444444444444444444444//
            Console.WriteLine("enter the first number");
            var Nr1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            var Nr2 = Int32.Parse(Console.ReadLine());
            Nr1++; Nr2--;
            Console.WriteLine($"Nr1 = {Nr1} Nr2 = {Nr2}");
            //55555555555555555555555555555555555555//
            Console.WriteLine("enter the length");
            var length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the width");
            var width = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Area is: {length*width} square units");
            //66666666666666666666666666666666666666//
            Console.WriteLine("First of all, enter something if you want");
            var maybe = Console.ReadLine();

            Console.WriteLine("Is the input empty?");

            Console.WriteLine("According to first method");
            Console.WriteLine(maybe == "");

            Console.WriteLine("According to second method");
            bool ivestis = string.IsNullOrEmpty(maybe);
            Console.WriteLine(ivestis);

            Console.WriteLine("According to third method");
            int stringIlgis = maybe.Length;
            Console.WriteLine("The number of chars: {0}, {1}", stringIlgis, stringIlgis == 0);
            
            //77777777777777777777777777777777777777//
            Console.WriteLine("Enter a random number lower than 0");
            var randomNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Is it lower than 0? {randomNumber<0}");
            //88888888888888888888888888888888888888//
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            var surname = Console.ReadLine();
            Console.WriteLine($"Name: {name}, surname: {surname}");
            //99999999999999999999999999999999999999//
            string miestas = "Oslo";
            string gatve = "Gjettum";
            int numeris = 30;
            int buildYear= 1959;
            
            DateOnly pradzia = DateOnly.Parse("1959-09-01");
            int kiekMetu = 3;
            Console.WriteLine($"city: {miestas}, street: {gatve}, house number: {numeris}, build year: {buildYear}," +
                $"start of construction: {pradzia}, how long: {kiekMetu}");
            //kazkas negerai, pataisyti






        }
    }
}
