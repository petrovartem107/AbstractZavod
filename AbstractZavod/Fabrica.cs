using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractZavod
{
    internal class Fabrica : IPredpiyatie
    {
        public void Realization()
        {
            Console.WriteLine("Фабрика делает из ткани одежду");
        }
    }
}
