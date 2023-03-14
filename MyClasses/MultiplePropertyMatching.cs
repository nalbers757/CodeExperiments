using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    /*
     * You can match on multiple properties of an object
     * In the method "MatchStuff" we do a switch on the given user, but the case is on multiple properties
     * Only if all of the property values of the given class match, does the case succeed
     * 
     * You can also match by checking if an object "is" something or "or" something
     * 
     * We can use some logic in our checks, like Age >= 30
     * 
     * And we can combine
     * -- obj is MPA_User { LastName: "Smith", Age: >= 30 }:
     * 
     * Also, again we use string interpolation and call the MatchStuff method in the return string
    */

    public class MPA_User
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class MPA_DummyClass
    {
        public string Name { get; set; }    
    }

    public class MultiplePropertyMatching
    {
        public static string RunMe()
        {
            string returnValue = "";

            MPA_User userBobSmith = new()
            {
                Age = 30,
                FirstName = "Bob",
                LastName = "Smith"
            };

            MPA_User userBobJohnson = new()
            {
                Age = 30,
                FirstName = "Bob",
                LastName = "Johnson"
            };

            MPA_User userTonyRobinson = new()
            {
                Age = 30,
                FirstName = "Tony",
                LastName = "Robinson"
            };


            returnValue += $"TonyRobinson -- {MatchStuff(userTonyRobinson)}";
            returnValue += $"BobJohnson -- {MatchStuff(userBobJohnson)}";
            returnValue += $"BobSmith -- {MatchStuff(userBobSmith)}";

            return returnValue;
        }

        private static string MatchStuff(object user)
        {
            string returnValue = "";

            if (user is MPA_User) { returnValue += "user is MPA_User. "; }
            if (user is MPA_DummyClass or MPA_User) { returnValue += "user is MPA_DummyClass or MPA_User. ";}


            switch ((MPA_User)(user))
            {
                case { LastName: "Smith", Age: 30 }:
                    returnValue += "LastName: Smith, Age: 30. ";
                    break;
                case { Age:  >= 10 }:
                    returnValue += "Age: >= 10. ";
                    break;
                default:
                    returnValue += "No match found. ";
                    break;
            }

            return returnValue;
        }
    }
}
