using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractZavod
{
    internal class ChainikovZavod : Zavod
    {
        public override void Proizvodit()
        {
            Console.WriteLine("Завод производит Чайники");
        }
    }
}
