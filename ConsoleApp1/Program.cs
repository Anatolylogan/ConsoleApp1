using System;
class Program
{ 
    static void Main()
    {
        Console.WriteLine("Введите ваш возраст");
        string input = Console.ReadLine();
        int age =int.Parse(input);
        Console.WriteLine($"Ваш возраст: {age}");
    }
}
