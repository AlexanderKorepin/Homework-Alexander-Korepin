// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max; 
int min;
if (num1 > num2)
{
   Console.WriteLine($"max number =  {num1} and min number = {num2}");
}
else
{
   Console.WriteLine($"max number = {num2} and min number = {num1}");
}
*/
//============================================================

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine ("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
   if ( num1 < num2 ) max = num2;
   if ( num2 <num3 ) max = num3;
Console.Write ("Max number = ");
Console.WriteLine (max);
*/

//============================================================
// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/* Console.WriteLine ("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1) 
{
   Console.WriteLine($"Number {number} - odd number ");
}
else 
{
   Console.WriteLine($"Number {number} - an even number");
}
*/
//============================================================
// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Input a number :");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;

while (current<=number)

{     if (current % 2 == 0)
         Console.Write(current +  "  ");
         current++; 
}
*/
//================================================================================