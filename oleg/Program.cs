using System;

namespace Test
{
    class Program
    {
       static void Main(string[] args)
       { 
        Console.WriteLine("Введите своё имя: ");
        string Name = Console.ReadLine();
        Console.WriteLine("Сколько тебе лет?");
        string Age = Console.ReadLine();
        FindYear(Age);
       }
       static void FindYear(string Age)
       {
        int YourAge = int.Parse(Age);
        int  CurrentYear = DateTime.Now.Year;
        int result = CurrentYear - YourAge;
        Console.WriteLine($"Ты родился в {result}");
        
       }

    }
}