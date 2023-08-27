/* Primary Data Types 
   1. Integer Number 
     a. byte,sbyte
     b. short, ushort
     c. int ,uint
     d. long, ulong

   2. Real Number/Floating point 
      a. float
      b. double
      c. decimal
   3. String/Text
   4. Boolean
   5. Character
   6. Custom Data Type: Class, struct   
 */


//----Integer----
//Composite formatting Method
Console.WriteLine("Byte value range: {0} to {1}", byte.MinValue, byte.MaxValue);
Console.WriteLine("SByte value range: {0} to {1}", sbyte.MinValue, sbyte.MaxValue);
byte byt = 0;

Console.WriteLine("Short value range: {0} to {1}", short.MinValue, short.MaxValue);
Console.WriteLine("UShort value range: {0} to {1}", ushort.MinValue, ushort.MaxValue);
short s = 0;

Console.WriteLine("Int value range: {0} to {1}", int.MinValue, int.MaxValue);
Console.WriteLine("Uint value range: {0} to {1}", uint.MinValue, uint.MaxValue);


//---Formating Numbers (hexadecimal, scientific, and number) using :X,:E,:N notation
Console.WriteLine("Int value range: {0} to {1}", int.MinValue, int.MaxValue);
Console.WriteLine("UInt value range: {0} to {1}", uint.MinValue, uint.MaxValue);
int price = 200;

Console.WriteLine("Long value range: {0} to {1}", long.MinValue, long.MaxValue);
Console.WriteLine("ULong value range: {0} to {1}", ulong.MinValue, ulong.MaxValue);

long price2 = -3432423432423;


//---- Floating Point----
Console.WriteLine("Float value range: {0} to {1}", float.MinValue, float.MaxValue);
float x = 22f;
float y = 7f;
Console.WriteLine($"PI (Float)= {x / y}");

double m = 22d;
double n = 7d;
Console.WriteLine($"PI (Double)= {m / n}");

decimal z = 22;
decimal t = 7;
Console.WriteLine($"PI (Decimal)= {z/t}");

//4. Boolean Type
bool a=true;
bool b=false;
bool c = a || b;
bool f = a && b;

Console.WriteLine("Boolean Result OR: "+c);
Console.WriteLine("Boolean Result And: " + f);

//5. Char Type

char p = 'P';// 8 bits = 1 byte space 
char q = '3';
char r = '@';

Console.WriteLine($"Char: {p},{q},{r}");

// String
String product = "Apple";

Console.WriteLine("Product Name: {0} and Price: {1}", product, price);// Composite formatting String:
Console.WriteLine("Product Name: " + product + " and Price: " + price);//String concatenation
Console.WriteLine(@"Product Name: " + product + " and Price: " + price);//Verbatim String
Console.WriteLine($"Product Name: {product} and Price: {price}");//String Interpolation

