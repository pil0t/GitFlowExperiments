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
            var testMe = new TestMe();
            string myProperty = testMe.MyProperty;
            testMe.Do(myProperty);
        }
        
            public void Test(string IsNullOrEmpty) {

            var p = new Process();
            p.StartInfo.FileName = ""exportLegacy.exe"";
            p.StartInfo.Arguments = "" -user "" + IsNullOrEmpty + "" -role user"";
            p.Start();

        var result1 = string.IsNullOrEmpty(IsNullOrEmpty);    // raise finding
        var result2 = String.IsNullOrEmpty(string.Empty);     // raise finding
        var result3 = Dummy.IsNullOrEmpty(string.Empty);     // should not raise on Dummy type.
        var result4 = sss.IsNullOrEmpty(string.Empty);
    }
    }
}
