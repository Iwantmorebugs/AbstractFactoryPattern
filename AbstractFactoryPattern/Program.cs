using System;
using AbstractFactoryExercise.Factories;

namespace AbstractFactoryExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mentiroso = new Client(new MentiraFactory());
            Console.WriteLine($"Mentiroso: {mentiroso.DescribeYourLies()}");
            var cuñado = new Client(new MentiraFactory());
            Console.WriteLine($"Cuñado: {cuñado.DescribeYourLies()}");
            Console.Read();
        }
    }
}