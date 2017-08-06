using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Resolve.Initialize();
            var myType = ResolveEventArgs.For<IMyType>();

            myType.DoSomething("testString", 1);

            Console.ReadKey();
        }
    }
}
