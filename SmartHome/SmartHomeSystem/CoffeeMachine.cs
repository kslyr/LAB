using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public string DeviceName => Name;
        public int PowerConsumption => 1000;
        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine($"{Name} почала готувати каву.");
        }
        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine($"{Name} завершила роботу.");
        }
        public double GetEnergyUsage(int hours)
        {
            if (!IsOn)
            {
                return 0;
            }
            return (double)PowerConsumption * hours / 1000.0;
        }
    }
}
