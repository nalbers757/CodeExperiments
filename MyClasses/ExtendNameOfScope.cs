using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class ExtendNameOfScope
    {
        public static string RunMe()
        {
            string returnValue = "";

            string myVariable = "This is my variable";
            string? myNullVal = null;

            returnValue = $"""
                nameof(myVariable): {nameof(myVariable)}
                nameof(SomeMethod): {nameof(SomeMethod)}

                Here's where it gets extended...
                I can now use nameof() in an attribute

                ExtendExample(string? arg, [CallArgumentExpression(nameof(arg))] string paramName = "")
                -- returns nameof(paramName);

                before [CallerArgumentExpression() required an actual string
                [CallerArgumentExpression("arg")

                now you can use nameof in the attribute so if you refractor your variable, nameof() gets refractored as well

                ExtendExample(myNulLVar): {ExtendExample(myNullVal)}
                """;

            return returnValue;
        }

        private void SomeMethod()
        {

        }

        public static string ExtendExample(string? arg, [CallerArgumentExpression(nameof(arg))] string paramName = "")
        {
            return $"{paramName}";
        }
    }
}
