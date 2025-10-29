using System;

namespace Task5;
public class Program
{
    public static void Main()
    {
        // Створюємо зубчастий масив з оцінками для 3 груп
        int[][] groups = new int[3][];

        // Група 1: 10-30 студентів
        groups[0] = new int[] { 85, 92, 78, 96, 88, 91, 83, 89, 94, 87, 90, 85, 93, 88, 86 };

        // Група 2: 10-30 студентів  
        groups[1] = new int[] { 75, 82, 68, 88, 72, 79, 85, 91, 77, 83, 89, 76, 84, 80, 78, 87, 74, 81, 86, 79 };

        // Група 3: 10-30 студентів
        groups[2] = new int[] { 95, 98, 92, 96, 94, 97, 93, 99, 91, 95, 98, 96, 94, 97, 92, 99, 95, 96, 98, 97, 94, 96, 99, 95, 98 };

        // Виводимо статистику для всіх груп
        PrintGroupStatistics(groups);
    }

    // Обчислює середню оцінку для групи
    public static double GetAverage(int[] marks)
    {
        int sum = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }
        return (double)sum / marks.Length;
    }

    // Знаходить мінімальну оцінку в групі
    public static int GetMin(int[] marks)
    {
        int min = marks[0];
        for (int i = 1; i < marks.Length; i++)
        {
            if (marks[i] < min)
            {
                min = marks[i];
            }
        }
        return min;
    }

    // Знаходить максимальну оцінку в групі
    public static int GetMax(int[] marks)
    {
        int max = marks[0];
        for (int i = 1; i < marks.Length; i++)
        {
            if (marks[i] > max)
            {
                max = marks[i];
            }
        }
        return max;
    }

    // Виводить статистику для всіх груп
    public static void PrintGroupStatistics(int[][] groups)
    {
        for (int i = 0; i < groups.Length; i++)
        {
            double average = GetAverage(groups[i]);
            int min = GetMin(groups[i]);
            int max = GetMax(groups[i]);

            Console.WriteLine($"Група {i + 1}: Середня = {average:F0}, Мінімум = {min}, Максимум = {max}");
        }
    }
}
