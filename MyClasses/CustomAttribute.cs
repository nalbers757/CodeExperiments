using System.Text.Json.Serialization;

namespace MyClasses
{
    /*
     * C# 11 has introduced "Generic Attributes"
     * In this example we make two custom attributes
     * -- one the old way
     * -- the other, the new way
     * 
     * To make a custom attribute you have to derive from the "Attribute" class
     * 
     * We will apply our custom attributes to a class "CA_User"
     * and then in our example method we will loop through attributes of the class
     * then we will add to a list the type associated with our custom attribute
     * -- [CustomAttributeOld(typeof(string))]
     * -- [CustomAttributeNew<bool>]
     * 
     * What is the advantage of using Generics?
     * -- One is that we can do something like
     * -- -- public class Blah<T> : Attribute where T is SomeClass
     * --
     * We cannot use <T> for our GenericAttribute
     * -- Example: [CustomAttributeNew<T>] is not allowed
     * We also cannot use the following types
     * -- dynamic, nullable types (string?, int?, etc), tuples [CustomAttribute<(int a, int b)>] 
     * --
     * You can use a Tuple, you just have to use the following syntax
     * -- [CustomAttribute<Tuple<int a, int b>>]
     * --
     * https://www.youtube.com/watch?v=uKcSO68LAkc
    */


    #region old way to make a CustomAttribute
    public class CustomAttributeOld : Attribute
    {
        private readonly Type _type;

        public CustomAttributeOld(Type type)
        {
            _type = type;
        }

        public Type CurrentType => _type;
    }
    #endregion

    #region new way to make a CustomAttribute
    public class CustomAttributeNew<T> : Attribute
    {
        public Type CurrentType => typeof(T);
    }
    #endregion

    #region we apply our customAttribute here
    [CustomAttributeOld(typeof(string))]
    [CustomAttributeNew<bool>]
    public class CA_User
    { 
        public string? Name { get; set; }

        [JsonPropertyName("add")] //<-- Example of preExisting attribute
        public required string Address { get; set; }
        public string Phone { get; set; }
    }
    #endregion


    #region example method, run me to see results
    public static class CA_Example
    {
        public static List<string> RunMe()
        {
            List<string> returnList = new();

            var type = typeof(CA_User);
            var customAttributes = type.GetCustomAttributes(false);

            foreach (var customAttribute in customAttributes) 
            { 
                if (customAttribute is CustomAttributeOld)
                {
                    returnList.Add( ((CustomAttributeOld)customAttribute).CurrentType.Name );
                }
                else if (customAttribute is CustomAttributeNew<bool>)
                {
                    returnList.Add(((CustomAttributeNew<bool>)customAttribute).CurrentType.Name);
                }
            }

            return returnList;
        }
    }
    #endregion
}