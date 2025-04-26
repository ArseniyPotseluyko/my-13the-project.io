using System;

// Объявление типа делегата
delegate string StringDelegate(string input);

class StringProcessor
{
    // Метод для преобразования строки в верхний регистр
    public static string ToUpperCase(string input) => input.ToUpper();

    // Метод для переворачивания строки
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Метод для получения длины строки (преобразует длину в строку)
    public static string GetLength(string input) => $"Длина строки: {input.Length}";
}

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string userInput = Console.ReadLine();

        // Создание экземпляра делегата и вызов методов
        StringDelegate strDelegate;

        strDelegate = StringProcessor.ToUpperCase;
        Console.WriteLine($"Верхний регистр: {strDelegate(userInput)}");

        strDelegate = StringProcessor.ReverseString;
        Console.WriteLine($"Перевёрнутая строка: {strDelegate(userInput)}");

        strDelegate = StringProcessor.GetLength;
        Console.WriteLine($"{strDelegate(userInput)}");
    }
}
