using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/* Both the if-single selection and the while repetition statement are similar because they perform an action or a set of actions based on whether a condition is true or false. They are different though when the condition is true, the if-single statement performs actions once.  The while repetition statement continues to repeatedly perform the actions until the the condition is false. */

int speedLimit;
int speed;

speedLimit = 35;
speed = 42;

if (speed > speedLimit
    Console.Write("SLOW NOW");

int istrue = 10;

if (istrue <= 60)
    Console.WriteLine("It is True");
else
    Console.WriteLine("It is False");

Console.WriteLine("Input Temperature in Fahrenheit:");

    double fahrenheit = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

double Celsius = (fahrenheit - 32d) * 5d / 9d;

    Console.WriteLine("Temperature in Celsius is {0}:", Celsius);

        Console.ReadLine();

if (fahrenheit >= 90)

                Console.WriteLine("It is hot");

if (fahrenheit <= 40)

    int i = 1;

    while (i < 11)
{
        Console.Write("While Output:");
        Console.WriteLine(i);
        i++;
}

    int i = 60;

    while (i >= 20)
{
        Console.Write("While Output:");
        Console.WriteLine(i);
        i--;
}

    int i = 10;

    while (i <= 20)
{
    Console.Write("While Output:");
    Console.WriteLine(i);
    i++;
}






    