﻿//Console.WriteLine("Hello, World!");
//Console.WriteLine("About Me");
//int age = 18;
//bool isStudent = true;
//string currentStudyPlace = "bdu";
//char mostUsedLetter = 'C';
//string myNameAndSurname = "Behmen Ceferov";
//double creatingTime = 3.12;
//decimal monthYear = 13.2023M;
//Console.WriteLine("Press any key if you want to continue");
//Console.ReadLine();
//Console.WriteLine(myNameAndSurname);
//Console.ReadLine();
//Console.WriteLine(age);
//Console.ReadLine();
//Console.WriteLine($"He is a student: {isStudent}");
//Console.ReadLine();
//Console.WriteLine(currentStudyPlace.ToUpper()); // or To.Lower
//Console.ReadLine();
//Console.WriteLine(creatingTime);
//Console.ReadLine();
//Console.WriteLine(monthYear);
//Console.ReadLine();
//Console.WriteLine(mostUsedLetter);

using static System.Console;
using static System.Math;
using static System.Convert;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//double numberOne = 11, numberTwo = 12, numberThree = 13;
////double convertedNumberTwo = ToInt32(15);
////WriteLine(convertedNumberTwo);
//WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
//string textNumber = "15";
//double convertedTextNumber = ToDouble(textNumber);
//WriteLine($"({textNumber} + {numberTwo}) / {numberThree} = {(convertedTextNumber + numberTwo) / numberThree}");
//WriteLine($"Where are you from?");
//string iAmFrom = ReadLine();
//string describe = $"i am from {iAmFrom}";
//WriteLine(describe);
WriteLine("What language are you learning?");
string programmingLanguage = ReadLine();
WriteLine("What is your group number?");
string groupNumber = ReadLine();
WriteLine("Who is your best friend?");
string bestFriend = ReadLine();
string text = $"Programming language that i learn: {programmingLanguage}. My group's number is {groupNumber}. My Best friend is {bestFriend}";
WriteLine(text);
