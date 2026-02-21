using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample1
{

    internal class Sipdashboard
    {//Inside one class we can create another class also.it will not throw any compiletime error.
        //if you want access sample class outside you need to create object with
        //parentclassname.childclassname obj=new parentclassname.childclassname();
        public partial class sample
        {
            public void LevngthPartalMethod()
            {
                Console.WriteLine("LevngthPartalMethod");
            }
        }
    }
}
