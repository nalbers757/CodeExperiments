using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    /*
     * We can now check arrays for patterns
     * We can check for a specific pattern (1,2,3,4,5)
     * We can check for simple logic stateents (0 or 1, <= 2, >= 3)
     * We can use the _ to skip a character (1, _, 3, 4, _, 6)
     * You can declare variables and use them in the following logic (1, var x, 3) { $"number was {x}"
     * You can use .. to split to the end of the list (1, .., 5)
    */


    public class ListPatterns
    {
        public static string RunMe()
        {
            StringBuilder returnValue = new();

            int[] numbers = { 1, 2, 3 };


            //Standard Pattern Matching
            bool test1 = (numbers is [1, 2, 3]); // True
            bool test2 = (numbers is [1, 2, 4]);  // False
            bool test3 = (numbers is [1, 2, 3, 4]);  // False
            bool test4 = (numbers is [0 or 1, <= 2, >= 3]);  // True
            bool test5 = (numbers is [var a, _, 3]); // True

            int[] fiveNumbers = {1,2,3,4,5};
            bool test6 = (fiveNumbers is [var b, _, 3, _, 5]); // True
            bool test7 = (fiveNumbers is [1, _, var c, 4, 5]); // True

            // Output: The first element of a three-item list is 1
            // The var first is available for use only in the following {}
            if (numbers is [var first, _, _]) { returnValue.AppendLine($"The first element of a three-item list is {first}."); }

            //This fails because it does not match the pattern
            //Here we are saying the Pattern would just be a single number
            if (numbers is [var myFirst]) { returnValue.AppendLine("I will not print because I do not match the pattern"); }

            int[] singleNumberArray = { 10 };
            if (numbers is [var singeNumber]) { returnValue.AppendLine($"You matched a single number!"); }

            //This passes because it does match the pattern
            if (fiveNumbers is [var getFirst, ..]) { returnValue.AppendLine($"The first element of a list is {getFirst}."); }
            if (fiveNumbers is [1, .., 4, 5]) { returnValue.AppendLine($"[1, .., 4, 5] matches (1,2,3,4,5)"); }
            if (fiveNumbers is [1, .., 5]) { returnValue.AppendLine($"[1, .., 5] matches (1,2,3,4,5)"); }
            if (fiveNumbers is [1, ..]) { returnValue.AppendLine($"[1, ..] matches (1,2,3,4,5)"); }
            if (fiveNumbers is not [1, .., 6, 5]) { returnValue.AppendLine($"[1, .., 6, 5) DOES NOT MATCH (1,2,3,4,5)"); }

            return returnValue.ToString();
        }
    }
}
