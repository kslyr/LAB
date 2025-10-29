using System;

namespace Task4;
public class Program
{
    public static void Main()
    {
        Console.Write("Введіть сторону a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть сторону b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введіть сторону c: ");
        double c = double.Parse(Console.ReadLine());

        // Перевіряємо, чи є сторони додатними числами
        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Сторони повинні бути додатними числами!");
            return;
        }

        // Перевіряємо, чи може існувати трикутник
        if (!IsValidTriangle(a, b, c))
        {
            Console.WriteLine("Трикутник з такими сторонами не може існувати!");
            return;
        }

        // Якщо трикутник існує, обчислюємо його характеристики
        double perimeter = GetPerimeter(a, b, c);
        double area = GetArea(a, b, c);
        string triangleType = GetTriangleType(a, b, c);

        Console.WriteLine($"Периметр: {perimeter:F2}");
        Console.WriteLine($"Площа: {area:F2}");
        Console.WriteLine($"Тип трикутника: {triangleType}");
    }

    // Перевіряє, чи може існувати трикутник
    public static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    // Обчислює периметр трикутника
    public static double GetPerimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    // Обчислює площу трикутника за формулою Герона
    public static double GetArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2; // півпериметр
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    // Визначає тип трикутника за сторонами
    public static string GetTriangleType(double a, double b, double c)
    {
        // Рівносторонній (всі сторони рівні)
        if (Math.Abs(a - b) < 0.001 && Math.Abs(b - c) < 0.001)
        {
            return "рівносторонній";
        }

        // Рівнобедрений (дві сторони рівні)
        if (Math.Abs(a - b) < 0.001 || Math.Abs(a - c) < 0.001 || Math.Abs(b - c) < 0.001)
        {
            return "рівнобедрений";
        }

        // Прямокутний (перевірка за теоремою Піфагора)
        double[] sides = { a, b, c };
        Array.Sort(sides);
        if (Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.001)
        {
            return "прямокутний";
        }

        // Довільний
        return "довільний";
    }
}
