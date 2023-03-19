using static System.Console;
using static System.Math;
using static System.Convert;

int numberOne = 10;
int numberTwo = 5;
WriteLine($"Write any number: ");
string numberThree = ReadLine();
int convertedNumberThree = ToInt32(numberThree);
WriteLine($"{numberOne} - {numberThree} = {numberOne - convertedNumberThree}"); 
WriteLine($"{numberOne} + {numberThree} = {numberOne + convertedNumberThree}"); 
WriteLine($"{numberOne} * {numberThree} = {numberOne * convertedNumberThree}"); 
WriteLine($"{numberTwo} - {numberThree} = {numberTwo - convertedNumberThree}"); 
WriteLine($"{numberTwo} + {numberThree} = {numberTwo + convertedNumberThree}"); 
WriteLine($"{numberTwo} * {numberThree} = {numberTwo * convertedNumberThree}");
