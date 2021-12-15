using System;

namespace TBD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {

                Console.WriteLine("What do you want to do? Add, Substract, Multiply, Divide.");
                string opt = Console.ReadLine();

                if (opt == "Add")
                {
                    Add();
                }
                else if (opt == "Substract")
                {
                    Substract();
                }
                else if (opt == "Multiply")
                {
                    Multiply();
                }
                else if (opt == "Divide")
                {
                    Divide();
                }

            }
        }

        static void Multiply()
        {
            Console.WriteLine("Enter A Number To Multiply: ");
            string num01 = Console.ReadLine();
            Console.WriteLine("Enter Another Number To Multiply: ");
            string num02 = Console.ReadLine();

            Console.WriteLine("The Answer Is " + Convert.ToDecimal(num01) * Convert.ToDecimal(num02) + ".");

        }

        static void Add()
        {
            Console.WriteLine("Enter A Number To Add: ");
            string num01 = Console.ReadLine();
            Console.WriteLine("Enter Another Number To Add: ");

            string num02 = Console.ReadLine();
            decimal result = Convert.ToDecimal(num01) + Convert.ToDecimal(num02);

            Console.WriteLine("The Answer Is " + result + ".");

        }

        static void Substract()
        {
            Console.WriteLine("Enter A Number To Substract: ");
            string num01 = Console.ReadLine();
            Console.WriteLine("Enter Another Number To Subract: ");
            string num02 = Console.ReadLine();
            decimal _result = Convert.ToDecimal(num01) - Convert.ToDecimal(num02);
            Console.WriteLine("The Answer Is " + _result + ".");

        }

        static void Divide()
        {
            Console.WriteLine("Enter A Number To Divide: ");
            string num01 = Console.ReadLine();
            Console.WriteLine("Enter Another Number To Divide: ");
            string num02 = Console.ReadLine();

            Console.WriteLine("The Answer Is " + Convert.ToDecimal(num01) / Convert.ToDecimal(num02) + ".");

        }
    }
}
