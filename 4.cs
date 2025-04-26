using System;

class Program
{
    // Определение делегата, который возвращает случайное число типа int
    delegate int RandomNumberDelegate();

    static void Main()
    {
        Random rand = new Random();

        // Создание массива делегатов
        RandomNumberDelegate[] delegates = new RandomNumberDelegate[5];

        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = delegate () { return rand.Next(1, 101); }; // Анонимный метод, возвращающий случайное число от 1 до 100
        }

        // Анонимный метод для вычисления среднего арифметического
        Func<RandomNumberDelegate[], double> calculateAverage = delegate (RandomNumberDelegate[] delArray)
        {
            int sum = 0;
            foreach (var del in delArray)
            {
                sum += del();
            }
            return (double)sum / delArray.Length;
        };

        // Вычисление среднего значения
        double average = calculateAverage(delegates);

        // Вывод результатов
        Console.WriteLine($"Среднее арифметическое: {average:F2}");
    }
}
