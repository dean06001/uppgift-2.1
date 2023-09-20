using System;
    namespace uppgift_2_1
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken är din favorit bok?");
            string bok = Console.ReadLine();
            Console.WriteLine("din favorite bok är " + bok +".");
            Console.ReadKey();
        }
    }
}