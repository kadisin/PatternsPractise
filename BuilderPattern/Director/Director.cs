using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Director
{
    public class Director
    {
        private IHomeBuilder _homeBuilder;
        public IHomeBuilder HomeBuilder
        {
            set { _homeBuilder = value; }
        }

        public void BuildMinimalViableHome()
        {
            this._homeBuilder.BuildGarage();
        }

        public void BuildFullFeaturedHome()
        {
            this._homeBuilder.BuildGarage();
            this._homeBuilder.BuildGarden();
            this._homeBuilder.BuildSwimmingPool();
        }

    }
}
