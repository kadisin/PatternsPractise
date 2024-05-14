using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystems
{
    public class AirConditioner
    {
        public AirConditionerStatus Status { get; set; } = AirConditionerStatus.Off;

        public void StartConditioner()
        {
            Status = AirConditionerStatus.On;
            Console.WriteLine("Air conditioner start...");
        }

        public void StopConditioner()
        {
            Status -= AirConditionerStatus.Off;
            Console.WriteLine("Air conditioner stop...");
        }
    }

    public enum AirConditionerStatus
    {
        On = 1,
        Off = 2
    }
}
