using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Whenever if you create object for partial class,c#compiler combine all partial classes  as single class .
            //this is happen at compiletime only.due to that if you write any duplicate method it will throw compiletime error.
            //don't write duplicate methods inside partial class.
            sample samObj = new sample();
            samObj.DisplayEmployeeData();//line by line exceution FN+f10.
            samObj.FirstPartalMethod();//going to method inside use FN+F11.
            samObj.SecondPartalMethod();
            samObj.ThirdPartalMethod();
            samObj.FourthPartalMethod();
            samObj.FiFthPartalMethod();
            samObj.SixthPartalMethod();
            samObj.SeventhPartalMethod();
            samObj.EightPartalMethod();
            samObj.NinethPartalMethod();
            samObj.TengthPartalMethod();
            samObj.TwentyPartalMethod();

            //Inside class we can create another class also.if you want to accss those class methods we need to fallow below steps
            //parentclassname.childclassname obj=new parentclassname.childclassname()
            Sipdashboard.sample sipobj = new Sipdashboard.sample();
            sipobj.LevngthPartalMethod();
        }
        /*
         * OUTPUT
         * ============
I am DisplayEmployeeddata
FirstPartalMethod
SecondPartalMethod
ThirdPartalMethod
FourthPartalMethod
FiFthPartalMethod
SixthPartalMethod
SeventhPartalMethod
EightPartalMethod
NinethPartalMethod
TengthPartalMethod
SeventhPartalMethod
LevngthPartalMethod
        */
    }
}
