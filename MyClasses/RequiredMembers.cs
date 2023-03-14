using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class ExampleClass
    {
        public required string Name { get; init; }
        public required int Age { get; set; }
        public string? email {get; set; }

        private string _address;
        public required string Address { get => _address; set => _address = value; }
    }


    public class RequiredMembers
    {
        public static string RunMe()
        {
            string returnValue = "";


            //Both Name and Age are required
            //So I absolutely have to set them on creation
            //If you comment out Name = "Fred Flintstone", you'll get an error
            //
            //Also, "Address" is a property to a private variable _address
            //Required can not be used on the private variable, but it can be used on the public property
            //And since that property is required, we have to set it below
            ExampleClass myObj = new()
            {
                Name = "Fred Flintsone",
                Age = 41,
                Address = "1234 HotRod St"
            };

            //But Name was also set to "init"
            //This means I can initialize it's value on creation, but I'm not allowed to change it after
            //The below code is commented out because it won't compile

            //myObj.Name = "Barney Rubble";

            //but Age is "set", so I can change it
            myObj.Age = 42;


            //email is not required, so while I can change it's value, I don't have to set it on creation
            myObj.email = "rambo@google.com";

            //and of course, we can combine these...
            //we could have an init but not required


            returnValue = """
                You'll have to just look at the code for this one.
                In short, you can flag properties to be "required"
                this means you have to set their value when you create an instance of the class

                This is for the new way of making an object without having to write a constructor

                You can also use init; to say a member can be set on construction but not edited
                """;
            return returnValue;
        }
    }
}
