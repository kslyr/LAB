using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Restaurant
    {
        private List<MenuItem> _menu = new List<MenuItem>();
        private List<Order> _orders = new List<Order>();
        public void SetupMenu()
        {
            _menu.Add(new Dish { Name = "Борщ", Price = 120, Category = "Перше" });
            _menu.Add(new Dish { Name = "Деруни", Price = 90, Category = "Основне" });
            _menu.Add(new Drink { Name = "Кава", Price = 60, VolumeML = 200, IsAlcoholic = false });
            _menu.Add(new Drink { Name = "Сік апельсиновий", Price = 70, VolumeML = 250, IsAlcoholic = false });
        }
        public void DisplayMenu()
        {
            Console.WriteLine("--- МЕНЮ РЕСТОРАНУ ---");
            foreach (IDisplayable item in _menu)
            {
                item.Display();
            }
            Console.WriteLine("----------------------");
        }
        public MenuItem GetMenuItem(int index)
        {
            if (index >= 0 && index < _menu.Count)
            {
                return _menu[index];
            }
            return null;
        }
        public Order CreateOrder(int tableNumber)
        {
            Order order = new Order(tableNumber);
            _orders.Add(order);
            Console.WriteLine($"\nСтворено нове замовлення для столика №{tableNumber}");
            return order;
        }
        public void DisplayAllOrders()
        {
            Console.WriteLine("\n--- УСІ ЗАМОВЛЕННЯ ---");
            foreach (Order order in _orders)
            {
                Console.WriteLine($"ID: {order.OrderId} | Стіл: {order.TableNumber} | Статус: {order.Status} | Сума: {order.GetTotalPrice():C}");
            }
        }
    }
}
