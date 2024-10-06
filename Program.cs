using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

//For Loop
Console.WriteLine(""); Console.WriteLine("For Loop");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

//For loop with array and length
Console.WriteLine(""); Console.WriteLine("For loop with array and length");
int[] myNumbers = {10, 20, 30, 40, 50};
for (int i = 0; i < myNumbers.Length; i++)
{
    Console.WriteLine(myNumbers[i]);
}

// Foreach
Console.WriteLine(""); Console.WriteLine("Foreach");
char[] message = { 'H', 'e', 'l', 'l', 'o' };
foreach (char i in message)
    Console.WriteLine(i);

//While
Console.WriteLine(""); Console.WriteLine("While");
int counter = 5;
while (counter > 0)
{
    Console.WriteLine("Counter = {0}", counter);
    counter = counter - 1;
}

//Do While
Console.WriteLine(""); Console.WriteLine("Do While");
int counted = 100;
do
{
    Console.WriteLine("Counter = {0}", counted);
    counted++;
} while (counted<0);
