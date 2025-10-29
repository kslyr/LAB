namespace Task2;

using System;

public class Program
{
    public static void Main()
    {
        // Генеруємо масив з 10 випадкових чисел від 1 до 100
        int[] numbers = GenerateRandomArray(10, 1, 100);

        // Виводимо всі числа масиву
        Console.WriteLine("Масив чисел:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        // Обчислюємо та виводимо статистику
        int sum = GetSum(numbers);
        double average = GetAverage(numbers);
        int min = GetMin(numbers);
        int max = GetMax(numbers);

        Console.WriteLine($"Сума: {sum}");
        Console.WriteLine($"Середнє значення: {average:F2}");
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }

    // Генерує масив випадкових чисел
    public static int[] GenerateRandomArray(int size, int min, int max)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(min, max + 1);
        }

        return array;
    }

    // Обчислює суму чисел у масиві
    public static int GetSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    // Обчислює середнє значення чисел у масиві
    public static double GetAverage(int[] numbers)
    {
        int sum = GetSum(numbers);
        return (double)sum / numbers.Length;
    }

    // Знаходить мінімальне значення у масиві
    public static int GetMin(int[] numbers)
    {
        int min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    // Знаходить максимальне значення у масиві
    public static int GetMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}