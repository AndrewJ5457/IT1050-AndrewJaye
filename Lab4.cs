using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/* Control variable is a loop counter that counts out how many times an algorithm should repeat itself. Intial value is the first value given to the control variable needed to start the loop. Increment(decrement) is how the control variable changes everytime it loops. Loop-Continuation Condition is what determines how long the loop should loop. */

/* A while statement would look like (see below). */
int i = 0;
while(i>10)
{
Console.WriteLine(i);
i++
}
/* A for statment would look like (see below). */
for(int =0; i<10; i++)
{
 Console.WriteLine(i);
}

/* A do-while statement would be more appropriate to do than a while statement, only when the condition in which they run or must run after the loop. */
int sum = 0;
int i = 0;
do
{
  sum += i;
  i++;
  }
  while (i < 5);
  return sum;

for (int i = 1; i < 101; i++)
{
    Console.WriteLine(i);
    {
        if ((i % 2) == 0)
        {
            Console.WriteLine("Number is Even");
        }
        else if ((i % 2) != 0)
        {
            Console.WriteLine("Number is Odd");
        }
    }
}

Console.Write("Please enter a temperature: ");
 int temp = Convert.ToInt32(Console.ReadLine());
 if (temp >= 90)
{
    Console.WriteLine("Fish");
}
 else if (temp >= 80)
{
    Console.WriteLine("Lion");
}
 else if (temp >= 70)
{
    Console.WriteLine("Turtle");
}
 else if (temp >= 60)
{
    Console.WriteLine("Deer");
}
 else if (temp >= 50)
{
    Console.WriteLine("Reindeer");
}
 else if (temp >= 40)
{
    Console.WriteLine("Moose");
}
 else if (temp >= 20)
{
    Console.WriteLine("Penguin");
}
 else if (temp >= 10)
{
    Console.WriteLine("Polar Bear");
}
 else
{
    Console.WriteLine("Bug");
}

int i = 9;
 while (i < 20)
      {
          i++;
          Console.WriteLine(i);
      }

 for (int i = 0; i < 101; i++)
      {
          Console.WriteLine(i);
          Console.WriteLine("********");
      }

