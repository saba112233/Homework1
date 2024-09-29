// See https://aka.ms/new-console-template for more information


Console.WriteLine("Check if the number is divisible by 5");
var rNum = Convert.ToInt32(Console.ReadLine());
if (rNum % 5 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}




Console.WriteLine("Enter X");
var X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y");
var Y = Convert.ToInt32(Console.ReadLine());

if (X >= Y)
{
    Console.WriteLine(X - Y);
}
else
{
    Console.WriteLine(Y - X);
}




if (X == 0 || Y == 0)
{
    Console.WriteLine("not allowed to devide by zero");
}
else
{
    if (X >= Y)
    {
        Console.WriteLine(X / Y);
    }
    else
    {
        Console.WriteLine(Y / X);
    }
}


Console.WriteLine("enter X");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter Y");
var num2 = Convert.ToInt32(Console.ReadLine());
var num3 = num1;
Console.WriteLine(num1 = num2);
Console.WriteLine(num2 = num3);




var Rnum = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i * Rnum);
}




var NUM = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < NUM; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i*i); 
    }
}