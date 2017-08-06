using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    public class MyType : IMyType
    {
        public void DoSomeThing(string str, int i)
        {
            Console.WriteLine(string.Format("MyType.Dosomething execution using '{0} and {1}",str,i));
        }
    }
}
