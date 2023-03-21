//using static System.Console;
//using static System.Math;
//using static System.Convert;

//int numberOne = 10;
//int numberTwo = 5;
//WriteLine($"Write any number: ");
//string numberThree = ReadLine();
//int convertedNumberThree = ToInt32(numberThree);
//WriteLine($"{numberOne} - {numberThree} = {numberOne - convertedNumberThree}"); 
//WriteLine($"{numberOne} + {numberThree} = {numberOne + convertedNumberThree}"); 
//WriteLine($"{numberOne} * {numberThree} = {numberOne * convertedNumberThree}"); 
//WriteLine($"{numberTwo} - {numberThree} = {numberTwo - convertedNumberThree}"); 
//WriteLine($"{numberTwo} + {numberThree} = {numberTwo + convertedNumberThree}"); 
//WriteLine($"{numberTwo} * {numberThree} = {numberTwo * convertedNumberThree}");

using System.Runtime.CompilerServices;
using static System.Console;
using static System.Math;
//int numberOne = 11, numberTwo = 10;
//WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");

double x = 10, z = 2;
double y = (Abs(((Pow(x, 2) * Pow(z, 4 / 3)) / (Pow(z, 3) * Pow(x, 2))) - Abs(Pow(x, 2))));
WriteLine(y);