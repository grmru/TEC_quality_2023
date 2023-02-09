using System;

namespace TEC.Exmple.One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1:");
            string val1 = Console.ReadLine();
            Console.WriteLine("Введите число 2:");
            string val2 = Console.ReadLine();

            Console.WriteLine("Введите что нужно сделать:");
            string action = Console.ReadLine();

            string result = Compute(val1, val2, action);
            Console.WriteLine(result);
        }

        static string Compute(string val1, string val2, string action)
        {
            string result = "... программа в разработке ...";

            if (action == "+") { result = MakeAddition(val1, val2); }
            else if (action == "-") { result = MakeSubtraction(val1, val2); }
            else if (action == "*") { result = MakeMultiplication(val1, val2); }
            else if (action == "/") { result = MakeDivision(val1, val2); }

            return "Результат: " + val1 + " " + action + " " + val2 + " = " + result;
        }

        static string MakeAddition(string val1, string val2)
        {
            int v1 = int.Parse(val1);
            int v2 = int.Parse(val2);
            int res = v1 + v2;
            return res.ToString();
        }

        static string MakeMultiplication(string val1, string val2)
        {
            int v1 = int.Parse(val1);
            int v2 = int.Parse(val2);
            int res = v1 * v2;
            return res.ToString();
        }

        static string MakeSubtraction(string val1, string val2)
        {
            int v1 = int.Parse(val1);
            int v2 = int.Parse(val2);
            int res = v1 - v2;
            return res.ToString();
        }

        static string MakeDivision(string val1, string val2)
        {
            int v1 = int.Parse(val1);
            int v2 = int.Parse(val2);
            int res = v1 / v2;
            return res.ToString();
        }
    }
}

