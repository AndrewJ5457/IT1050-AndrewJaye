using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
public double getArea(double height, double width)
{
    return height * width;
}

/* Scope is double height, double width, anything between the () in the method header. */
/* Static you access information across the code. Non-static you must get the information another way. */
/* Return Type is double; it signifies the program returning the information. It as well can be an int or a void. */
/* Method Name (Identifier) is getArea. It can tell the code where to get the information. */
/* Parameters are public; it tells the code if there are any restrictions to the access. */
/* Method Body is return height * width; it marks areas of code that must be executed out. */

/* User defined is written by the user and hidden away from other methods. Framework is reused from several other locations. */
/* When user-defined methods are created; one should not consider to "reinvent the wheel". */

/* The difference between a static and non-static method is that a static method cannot access any of the objects' non-static fields. A non-static method can access all the non-static fields within an object. */

public string bark
public static void bark();
{
        Console.WriteLine("{0} is Barking...", name);
}

public string doTrick;
public static void doTrick(trickName);
{
        Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", name, trickName);
}