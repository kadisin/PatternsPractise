using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Service
{
    public class SendService : ISendService
    {
        public void Send(string jsonData)
        {
            //in this example service use string but in json format data...
            //do something with data...
        }
    }
}
