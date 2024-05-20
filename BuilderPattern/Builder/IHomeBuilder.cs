using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public interface IHomeBuilder
    {
        public void BuildGarden();
        public void BuildGarage();

        public void BuildSwimmingPool();
    }
}
