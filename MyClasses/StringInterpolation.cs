using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyClasses
{
    /*
     * The text inside the { and } characters for a string interpolation can now span multiple lines. 
     * The text between the { and } markers is parsed as C#. Any legal C#, including newlines, is allowed.
     * Any valid C# code is now valid in string interpolation, including line breaks and whitespace
     * 
     * well, that's what it says. However I was unable to get this to work with more complex features like a foreach loop.
    */

    public static class StringInterpolation
    {
        public static StringBuilder RunMe()
        {
            StringBuilder returnValue = new StringBuilder();



            //Allows formatting
            const int myNumber = 20;
            returnValue.AppendLine($"{Math.PI, myNumber} - default formatting of the pi number");
            returnValue.AppendLine($"{Math.PI, myNumber:F3} - display only three decimal digits of the pi number");


            //This is allowed, but more complex logic (like a foreach) is not
            int myAge = 3;
            returnValue.AppendLine($"I am {myAge} year{(myAge == 1 ? "" : "s")} old.");


            //But we can use a switch
            int myValue = 38;
            returnValue.AppendLine($"myValue is {myValue}. Which means it is {
                    myValue switch
                    {
                        > 90 => "greater than 90",
                        > 80 => "greater than 80",
                        > 70 => "greater than 70",
                        > 50 => "greater than 50",
                        _ => "less than or equal to 50",
                    }}.");



            return returnValue;
        }
    }
}
