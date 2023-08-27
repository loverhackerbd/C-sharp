//1. Composite formatting Method
//Format item syntax: {index[,alignment][:formatString]}

//2. interpolated string method
//Format item syntax: {<interpolationExpression>[,<alignment>][:<formatString>]}

//Topic: Index component, Alignment component, Format string component

//3. Custom numeric format strings Method
//https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings

//---------------------------------------//
//1.
//https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting#format-string-component
using System.Globalization;

string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                         "Ebenezer", "Francine", "George" };
decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80,
                                 16.75m };


Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
for (int ctr = 0; ctr < names.Length; ctr++)
    Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);



//2.
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
//Example 1 : using alignment
Console.WriteLine($"|{"Left",-7}|{"Right",7}|");

const int FieldWidthRightAligned = 20;
Console.WriteLine($"{Math.PI,FieldWidthRightAligned} - default formatting of the pi number");
Console.WriteLine($"{Math.PI,FieldWidthRightAligned:F3} - display only three decimal digits of the pi number");


//Example 2: using tarnary operator
string name = "Horace";
int age = 34;
Console.WriteLine($"He asked, \"Is your name {name}?\", but didn't wait for a reply :-{{");
Console.WriteLine($"{name} is {age} year{(age == 1 ? "" : "s")} old.");


//Example 3: using format specifier

// Display string representations of numbers for en-us culture
CultureInfo ci = new CultureInfo("en-us");

// Output floating point values
double floating = 10761.937554;
Console.WriteLine("C: {0}",
        floating.ToString("C", ci));           // Displays "C: $10,761.94"
Console.WriteLine("E: {0}",
        floating.ToString("E03", ci));         // Displays "E: 1.076E+004"
Console.WriteLine("F: {0}",
        floating.ToString("F04", ci));         // Displays "F: 10761.9376"
Console.WriteLine("G: {0}",
        floating.ToString("G", ci));           // Displays "G: 10761.937554"
Console.WriteLine("N: {0}",
        floating.ToString("N03", ci));         // Displays "N: 10,761.938"
Console.WriteLine("P: {0}",
        (floating / 10000).ToString("P02", ci)); // Displays "P: 107.62 %"
Console.WriteLine("R: {0}",
        floating.ToString("R", ci));           // Displays "R: 10761.937554"
Console.WriteLine();
//https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

//https://learn.microsoft.com/en-us/dotnet/standard/base-types/how-to-pad-a-number-with-leading-zeros