using System;

// Объявление типа делегата
delegate double CalcFigure(double R);

class Program
{
    // Метод для вычисления длины окружности
    public static double Get_Length(double R) => 2 * Math.PI * R;

    // Метод для вычисления площади круга
    public static double Get_Area(double R) => Math.PI * Math.Pow(R, 2);

    // Метод для вычисления объема шара
    public static double Get_Volume(double R) => (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);

    static void Main()
    {
        // Ввод радиуса
        Console.Write("Введите радиус: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Создание экземпляра делегата и вызов методов
        CalcFigure CF;

        CF = Get_Length;
        Console.WriteLine($"Длина окружности: {CF(radius):F4}");

        CF = Get_Area;
        Console.WriteLine($"Площадь круга: {CF(radius):F4}");

        CF = Get_Volume;
        Console.WriteLine($"Объем шара: {CF(radius):F4}");
    }
}
