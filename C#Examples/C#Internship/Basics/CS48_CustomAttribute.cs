using System;

// Define a custom attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class MyCustomAttribute : Attribute
{
    public string Description { get; }

    public MyCustomAttribute(string description)
    {
        Description = description;
    }
}

// Apply the custom attribute to a class and method
[MyCustom("This is a custom attribute applied to the class")]
class My_Class
{
    [MyCustom("This is a custom attribute applied to the method")]
    public void MyMethod()
    {
        Console.WriteLine("Inside MyMethod");
    }
}

class CS48_CustomAttribute
{
     void Main(string[] args)
    {
        // Get and display the custom attribute applied to the class
        var classAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(typeof(My_Class), typeof(MyCustomAttribute));
        if (classAttribute != null)
        {
            Console.WriteLine("Class Attribute Description: " + classAttribute.Description);
        }

        // Get and display the custom attribute applied to the method
        var methodInfo = typeof(My_Class).GetMethod("MyMethod");
        var methodAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(MyCustomAttribute));
        if (methodAttribute != null)
        {
            Console.WriteLine("Method Attribute Description: " + methodAttribute.Description);
        }
    }
}
