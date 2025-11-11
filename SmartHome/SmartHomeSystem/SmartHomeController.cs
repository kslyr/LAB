using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        private List<ISwitchable> switchableDevices = new List<ISwitchable>();
        private List<IEnergyConsumer> energyConsumers = new List<IEnergyConsumer>();
        public void AddDevice(ISwitchable device)
        {
            switchableDevices.Add(device);
        }
        public void AddEnergyDevice(IEnergyConsumer consumer)
        {
            energyConsumers.Add(consumer);
        }
        public void TurnAllOn()
        {
            foreach (ISwitchable device in switchableDevices)
            {
                device.TurnOn();
            }
        }
        public void TurnAllOff()
        {
            foreach (ISwitchable device in switchableDevices)
            {
                device.TurnOff();
            }
        }
        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"\nЗвіт про споживання енергії за {hours} год:");
            double totalConsumption = 0;

            foreach (IEnergyConsumer consumer in energyConsumers)
            {
                double consumption = consumer.GetEnergyUsage(hours);
                totalConsumption += consumption;

                Console.WriteLine($"- {consumer.DeviceName}: {consumption:F2} кВт·год (потужність: {consumer.PowerConsumption} Вт)");
            }
            Console.WriteLine($"Загальне споживання: {totalConsumption:F2} кВт·год");
        }
    }
}
