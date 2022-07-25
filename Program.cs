using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Привет, как тебя зовут?");
            string Name = Console.ReadLine();
            Console.WriteLine(Name);
            Console.ReadKey();

        }
    }
}
