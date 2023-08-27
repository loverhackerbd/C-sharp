//Loop

//1. For Loop
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();
//2. While Loop

int j = 0;
while (j<10)
{
    Console.WriteLine(j);
    j++;
}
Console.WriteLine();

//3. Do-while loop
int k = 0;
do {
    Console.WriteLine(k);
    k++;
}while (k<10);
Console.WriteLine();

//4. foreach loop
String[] names = {"Jahid","Rahim","Karim","Raju"};

foreach(String name in names)
{
    Console.WriteLine(name);
}