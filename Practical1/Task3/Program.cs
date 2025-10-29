using System;

namespace Task3;
public class Program
{
    public static void Main()
    {
        Console.Write("Введіть ваш вік: ");
        int age = int.Parse(Console.ReadLine());

        string category = ClassifyAge(age);
        Console.WriteLine(category);
    }

    // Метод для визначення категорії віку
    public static string ClassifyAge(int age)
    {
        if (age < 0 || age > 120)
        {
            return "Нереальний вік";
        }
        else if (age < 12)
        {
            return "Ви дитина";
        }
        else if (age >= 12 && age <= 17)
        {
            return "Підліток";
        }
        else if (age >= 18 && age <= 59)
        {
            return "Дорослий";
        }
        else if (age >= 60)
        {
            return "Пенсіонер";
        }
        else
        {
            return "Ви дитина"; // для віку 12 років
        }
    }
}
