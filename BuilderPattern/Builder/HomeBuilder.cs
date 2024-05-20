using BuilderPattern.HomeParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class HomeBuilder : IHomeBuilder
    {
        private Home _home = new Home();

        public HomeBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._home = new Home();
        }

        public void BuildGarage()
        {
            var garage = new Garage();
            this._home.AddPart(garage);
        }

        public void BuildGarden()
        {
            var garden = new Garden();
            this._home.AddPart(garden);
        }

        public void BuildSwimmingPool()
        {
            var swimmingPool = new SwimmingPool();
            this._home.AddPart(swimmingPool);
        }

        public Home GetHome()
        {
            Home home = this._home;
            this.Reset();
            return home;
        }
    }
}
