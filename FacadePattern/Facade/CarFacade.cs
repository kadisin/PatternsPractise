using FacadePattern.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facade
{
    public class CarFacade : ICarFacade
    {
        private Door _door {  get; set; }
        private Temperature _temperature {  get; set; } 
        private AirConditioner _airConditioner {  get; set; }

        public CarFacade()
        {
            _door = new Door();
            _temperature = new Temperature();
            _airConditioner = new AirConditioner();
        }

        public void Open()
        {
            _door.Open();
            _temperature.SetTemparature(21);
            _airConditioner.StartConditioner();
        }

        public void Close()
        {
            _temperature.SetTemparature(19);
            _airConditioner.StopConditioner();
            _door.Close();
        }

    }
}
