using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class AirConditioner : Device, IEnergyConsumer
    {
        public string DeviceName => Name;
        public int PowerConsumption => 2000;
        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine($"{Name} почав охолодження.");
        }
        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine($"{Name} зупинено.");
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
