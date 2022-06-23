// GПервая задача
int a, b;
Console.WriteLine("First Task");
Console.Write("Unput first digit: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Unput second digit: ");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Max = {a}");
}
else
{
    Console.WriteLine($"Max = {b}");
}
Console.WriteLine();

// Вторая задача
int a1, a2, a3;
Console.WriteLine("Second Task");
Console.Write("Input first digit: ");
a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second digit: ");
a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third digit: ");
a3 = Convert.ToInt32(Console.ReadLine());
if (a1>a2 && a1>a3)
{
    Console.WriteLine($"Max = {a1}");
}
if (a2>a1 && a2>a3)
{
    Console.WriteLine($"Max = {a2}");
}
if (a3>a2 && a3>a2)
{
    Console.WriteLine($"Max = {a3}");
}
Console.WriteLine();

//Третья задача
int c;
Console.WriteLine("Third Task");
Console.Write("Input a digit: ");
c = Convert.ToInt32(Console.ReadLine());
if (c % 2 == 0)
{
    Console.WriteLine($"Digit {c} is even");
}
else
{
    Console.WriteLine($"Digit {c} is not even");
}
Console.WriteLine();

//Четвертая задача
int n, count;
Console.WriteLine("Fourth Task");
Console.Write("Input a digit: ");
n = Convert.ToInt32(Console.ReadLine());
count = 2;
if (c < 0)
{
    n = n * (-1);
}
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}