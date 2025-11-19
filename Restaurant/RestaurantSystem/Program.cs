using System;

namespace RestaurantSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.SetupMenu();
            restaurant.DisplayMenu();

            Order order1 = restaurant.CreateOrder(5);

            order1.AddItem(restaurant.GetMenuItem(0)); 
            order1.AddItem(restaurant.GetMenuItem(2)); 
            Console.WriteLine($"Поточна сума: {order1.GetTotalPrice():C}");

            Console.WriteLine($"\nСтатус замовлення: {order1.Status}");
            order1.ChangeStatus(OrderStatus.InProgress);
            order1.ChangeStatus(OrderStatus.Ready);
            order1.ChangeStatus(OrderStatus.Paid);

            restaurant.DisplayAllOrders();
            Console.WriteLine("\n--- ДЕМОНСТРАЦІЯ DOWNCASTING ---");
            MenuItem item = restaurant.GetMenuItem(3); 
            Console.WriteLine($"Отримано позицію: {item.Name}");

            if (item is Drink)
            {
                Drink drink = (Drink)item;
                Console.WriteLine($"Це напій. Об'єм: {drink.VolumeML} мл.");
            }
        }
    }
}