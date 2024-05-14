using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdapterPattern.Adapter
{
    public class ClientAdapter : IClientAdapter
    {
        public string XmlToJsonConvert(string xml)
        {
            var doc = XDocument.Parse(xml);
            return JsonConvert.SerializeXNode(doc);
        }
    }
}
