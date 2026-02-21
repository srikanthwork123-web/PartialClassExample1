using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample1
{
   
        public  partial class sample
        { 
        public void EightPartalMethod()
        {
            Console.WriteLine("EightPartalMethod");
        }

        }
        public partial class sample
        {
            public void NinethPartalMethod()
            {
                Console.WriteLine("NinethPartalMethod");
            }
        }

        public partial class sample
        {
            public void TengthPartalMethod()
            {
                Console.WriteLine("TengthPartalMethod");
            }
        }
    
}
