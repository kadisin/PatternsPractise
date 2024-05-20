using BuilderPattern.HomeParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Home
    {
        private List<BasicPart> _parts = new List<BasicPart>();

        public void AddPart(BasicPart part)
        {
            _parts.Add(part);
        }

        public void ShowParts()
        {
            var result = "Parts: ";
            foreach(var part in _parts)
            {
                result += part.ToString() + ", ";
            }
            result = result.Remove(result.Length - 2);
            Console.WriteLine(result);
        }

    }
}
