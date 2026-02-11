using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractZavod
{
    internal abstract class Zavod : IPredpiyatie
    {
        public void Realization()
        {
            Console.WriteLine("Я РЕАЛИЗУЮ МЕТАЛЛ");
        }
        
        public abstract void Proizvodit();
    }
}
