using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.WriteLine("Number:");
            int numer = int.Parse(Console.ReadLine());
            Console.WriteLine("Date (dd/MM/yyyy):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Contract value:");
            double contractValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of installments:");
            int installments = int.Parse(Console.ReadLine());



        }
    }
}
