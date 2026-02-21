using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample1
{

    //Inside class we can write another class also.it is possible in c# programmming.
    public partial class sample
    {
        public void SecondPartalMethod()
        {
            Console.WriteLine("SecondPartalMethod");
        }
    }
    public partial class sample
    {
        public void ThirdPartalMethod()
        {
            Console.WriteLine("ThirdPartalMethod");
        }
    }
    public partial class sample
    {
        public void FourthPartalMethod()
        {
            Console.WriteLine("FourthPartalMethod");
        }
//in partaila class you can't write a duplicate methods.if you write duplicate methods it will throw compiletime error.
        //public void ThirdPartalMethod()
        //{
        //    Console.WriteLine("ThirdPartalMethod");
        //}
    }
    public partial class sample
    {
        public void FiFthPartalMethod()
        {
            Console.WriteLine("FiFthPartalMethod");
        }
    }
    public partial class sample
    {
        //Instane variables or non static variables.
        public int employeeId;
        public string employeeName;
        public int employeeAge;
        public string companyName;

        //this is the userdefined default constructor ,it doesn't conatin any values.
        //default constructor assign the data to userdefined default data to instance variables.
        public sample()
        {
            employeeId = 1;
            employeeAge = 20;
            employeeName = "sachin";
            companyName = "Jntu";
        }
        public void SixthPartalMethod()
        {
            Console.WriteLine("SixthPartalMethod");
        }
    }
    public partial class sample
    {
        public void SeventhPartalMethod()
        {
            Console.WriteLine("SeventhPartalMethod");
        }
    }
    public partial class sample
    {
        public void TwentyPartalMethod()
        {
            Console.WriteLine("SeventhPartalMethod");
        }
    }



}
