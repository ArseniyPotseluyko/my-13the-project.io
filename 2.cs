using System;

class Program
{
    static void Main()
    {
        // Лямбда-операторы для арифметических действий
        Func<double, double, double> Add = (x, y) => x + y;
        Func<double, double, double> Sub = (x, y) => x - y;
        Func<double, double, double> Mul = (x, y) => x * y;
        Func<double, double, double> Div = (x, y) => y != 0 ? x / y : double.NaN; // Проверка деления на ноль

        try
        {
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите операцию (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = operation switch
            {
                '+' => Add(num1, num2),
                '-' => Sub(num1, num2),
                '*' => Mul(num1, num2),
                '/' => Div(num1, num2),
                _ => throw new InvalidOperationException("Недопустимая операция! Используйте +, -, * или /.")
            };

            // Вывод результата
            if (double.IsNaN(result))
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно.");
            }
            else
            {
                Console.WriteLine($"Результат: {result}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода! Убедитесь, что вводите корректные числа.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
