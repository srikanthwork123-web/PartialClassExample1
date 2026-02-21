using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample1
{
    //In big projects multiple developers will work on same class we can go for partial classes.
    //If any big task we can divide to multiple persons .they can write the same logic by using partial class.
    //
    public partial class sample
    {
        public void FirstPartalMethod()
        {
            Console.WriteLine("FirstPartalMethod");
        }
        public void DisplayEmployeeData()
        {
            Console.WriteLine("I am DisplayEmployeeddata");
        }

       
    }
}
