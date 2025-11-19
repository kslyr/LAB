using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Order : IDisplayable
    {
        private static int _nextOrderId = 101;
        public int OrderId { get; }
        public int TableNumber { get; set; }
        public OrderStatus Status { get; private set; }
        private List<MenuItem> _items = new List<MenuItem>();
        public Order(int tableNumber)
        {
            TableNumber = tableNumber;
            Status = OrderStatus.New;
            OrderId = _nextOrderId++;
        }
        public void AddItem(MenuItem item)
        {
            _items.Add(item);
            Console.WriteLine($"Додано позицію: {item.Name}");

        }
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (MenuItem item in _items)
            {
                total += item.Price;

            }
            return total;
        }
        public void ChangeStatus(OrderStatus newStatus)
        { 
            Status = newStatus;
            Console.WriteLine($"> Змінено статус замовлення {OrderId} на: {Status}");
        }
        public void Display()
        {
            Console.WriteLine($"--- Замовлення ID: {OrderId} | Стіл: {TableNumber} | Статус: {Status} ---");
            foreach (MenuItem item in _items)
            {
                item.Display();
            }
            Console.WriteLine($"--- Загальна сума: {GetTotalPrice():C} ---");
        }
    }
}
