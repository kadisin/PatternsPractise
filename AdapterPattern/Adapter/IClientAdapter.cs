using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public interface IClientAdapter
    {
        //this is basic example string -> stirng but change format (in more specyfic case that method convert someType1 -> someType2)
        public string XmlToJsonConvert(string xml);
    }
}
