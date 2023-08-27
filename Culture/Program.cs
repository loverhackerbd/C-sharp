//To change culture
using System.Globalization;

string name = "Bill";

Console.WriteLine($"Culture = {Thread.CurrentThread.CurrentCulture.DisplayName}");
Console.WriteLine($"   Is 'Bill' the same as 'BILL'? {name.Equals("BILL", StringComparison.OrdinalIgnoreCase)}");
Console.WriteLine($"   Does 'Bill' start with 'BILL'? {name.StartsWith("BILL", true, null)}");
Console.WriteLine();


Thread.CurrentThread.CurrentCulture = new CultureInfo("Bn-BD");//Bn-In
Console.WriteLine($"Culture = {Thread.CurrentThread.CurrentCulture.DisplayName}");
Console.WriteLine($"   Is 'Bill' the same as 'BILL'? {name.Equals("BILL", StringComparison.OrdinalIgnoreCase)}");
Console.WriteLine($"   Does 'Bill' start with 'BILL'? {name.StartsWith("BILL", true, null)}");
Console.WriteLine();

Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
Console.WriteLine($"Culture = {Thread.CurrentThread.CurrentCulture.DisplayName}");
Console.WriteLine($"   Is 'Bill' the same as 'BILL'? {name.Equals("BILL", StringComparison.OrdinalIgnoreCase)}");
Console.WriteLine($"   Does 'Bill' start with 'BILL'? {name.StartsWith("BILL", true, null)}");

