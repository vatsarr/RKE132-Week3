﻿
Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum % 2;
//Console.WriteLine(result);

if (result != 0)
{
    Console.WriteLine("This number number is odd");
}
else
{
    Console.WriteLine("This number is even");
}