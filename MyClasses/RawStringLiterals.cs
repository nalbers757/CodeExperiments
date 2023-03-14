using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class RawStringLiterals
    {
        public static string RunMe()
        {
            string returnValue = "";

            string lastName = "Smith";
            string firstName = "John";

            returnValue = $$"""
                RawStringLiterals start with 3 double quotes.
                It allows you to have several lines without the need for line breaks.
                You can also indent
                    Which is cool.
                You can even put "quoted text" inside without escaping the quotes.
                You can even use string inerpolation.
                $ characters denote how many consecutive braces start and stop the interpolation.
                This string has $$ so it takes two { to start the interpolation.
                {{{lastName}}, {{firstName}}}
                """;

            return returnValue;
        }
    }
}
