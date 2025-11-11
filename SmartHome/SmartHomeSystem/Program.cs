using System;

namespace SmartHomeSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SmartHomeController controller = new SmartHomeController();

            Light lamp = new Light { Name = "Лампа у вітальні" };
            AirConditioner ac = new AirConditioner { Name = "Кондиціонер у спальні" };
            CoffeeMachine coffee = new CoffeeMachine { Name = "Кавомашина на кухні" };
            MotionSensor sensor = new MotionSensor { Name = "Датчик руху у коридорі" };

            controller.AddDevice(lamp);
            controller.AddDevice(ac);
            controller.AddDevice(coffee);
            controller.AddDevice(sensor);

            controller.AddEnergyDevice(lamp);
            controller.AddEnergyDevice(ac);
            controller.AddEnergyDevice(coffee);

            controller.TurnAllOn();
            Console.WriteLine();

            lamp.PrintStatus();
            ac.PrintStatus();
            coffee.PrintStatus();
            sensor.PrintStatus();

            controller.ShowEnergyReport(5);
            Console.WriteLine();

            controller.TurnAllOff();
        }
    }
}
