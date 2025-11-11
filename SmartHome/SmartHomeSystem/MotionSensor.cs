using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class MotionSensor : Device
    {
        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine($"{Name} активовано.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine($"{Name} деактивовано.");
        }
    }
}
