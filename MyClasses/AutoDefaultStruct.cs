using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class AutoDefaultStruct
    {
        /*
         * Structs now set the default value for all fields upon construction
         * any field or auto property not initialized by a constructor is automatically initialized by the compiler
         * below we declare a struct and although we set no default values we can use the values in our string
        */

        private struct DefaultStructTest
        {
            public string someString;
            public int someInt;
            public bool someBool;
        }

        public static string RunMe()
        {
            string returnValue = "";

            DefaultStructTest myStruct = new DefaultStructTest();
            returnValue = $$"""
                myStruct
                {
                    someString = {{myStruct.someString}};
                    someInt = {{myStruct.someInt}};
                    someBool = {{myStruct.someBool}};
                }
                """;

            return returnValue;
        }
    }
}
