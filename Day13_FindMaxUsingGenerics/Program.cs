// See https://aka.ms/new-console-template for more information
using Day13_FindMaxUsingGenerics;
Console.WriteLine("Welcome to Find Max Number Using Generics Program");

int output = FindMaxNumber.MaximumIntegerNumber(10, 20, 30);
Console.WriteLine(output);

Console.WriteLine();

Console.WriteLine("Maximum Float Value");
double doubleoutput = FindFlotMaxNumber.MaximumFloatNumber(10.10, 100.10, 30.30);
Console.WriteLine(doubleoutput);

Console.WriteLine();

Console.WriteLine("Maximum String Value");
string stringoutput = FindStringMax.MaximumString("Rohit", "Virat", "Sachin");
Console.WriteLine(stringoutput);
Console.WriteLine();

Console.WriteLine();

int[] intArray = { 1001, 2001, 1994, 2551 };
FindMaxUsingGeneric<int> generic = new FindMaxUsingGeneric<int>(intArray);
generic.PrintMaxValue();

double[] doubleArray = { 10.58, 52.52, 65.35, 89.52 };
FindMaxUsingGeneric<double> genericDouble = new FindMaxUsingGeneric<double>(doubleArray);
genericDouble.PrintMaxValue();

string[] stringArray = { "Rohit", "Virat", "Sachin", "Dhoni" };
FindMaxUsingGeneric<string> genericString = new FindMaxUsingGeneric<string>(stringArray);
genericString.PrintMaxValue();
