using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFlowExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            string fooBar = nameof(fooBar);
            TestMe tm = new TestMe();
            string mp = tm.MyProperty;
            fooBar += mp;
            Console.WriteLine(fooBar);
        }
    }
}
