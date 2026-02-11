using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractZavod
{
    internal class Fabrica : IPredpiyatie
    {
        void IPredpiyatie.Realization()
        {
            Console.WriteLine("Если только так");
        }
    }
}
