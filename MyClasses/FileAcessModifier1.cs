using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class FileAcessModifier1
    {
        public static string RunMe()
        {
            var returnString = "";

            returnString = """
                Another one you'll have to look at the code to see.

                What you want to notice here is that we have two class files
                -- FileAccessModifier1
                -- FileAccessModifier2

                Both files are using the same namespace "MyClasses"

                However, in both files we have a class called "FileClass"

                These classes are "file", meaning they are only available in that file

                Why would you want this? CodeGenerators

                Previously you would have to parse files to see if a class with a given name already exists before you generated a class with that name
                and if this is just some kind of helper class or whatever, now you can declare it as file... and it doesn't matter if this class exists elsewher already
                """;
            return returnString;
        }
    }

    file class FileClass
    {
        public string Name { get; set; }

    }

    //The below class is not allowed because a class with this name already exists in FileAccessModifier2

    //internal class PrivateFileClass
    //{
    //     public string? Name { get; set; } 
    //}
}
