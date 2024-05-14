using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystems
{
    public class Temperature
    {
        public int TemperatureInside { get; set; } = 20;

        public void SetTemparature(int newTemperature)
        {
            TemperatureInside = newTemperature;
            Console.WriteLine($"Temperature change to {newTemperature}");
        }

    }
}
