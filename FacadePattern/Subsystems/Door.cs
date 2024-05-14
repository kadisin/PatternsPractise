using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystems
{
    public class Door
    {
        public DoorStatus DoorStatus { get; set; } = DoorStatus.Close;

        public void Open()
        {
            DoorStatus = DoorStatus.Open;
            Console.WriteLine("Door open...");
        }

        public void Close()
        {
            DoorStatus = DoorStatus.Close;
            Console.WriteLine("Door close...");
        }
    }

    public enum DoorStatus
    {
        Open = 1,
        Close = 2
    }
}
