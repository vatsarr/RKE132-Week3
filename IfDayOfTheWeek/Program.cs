﻿
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 0)
{
    Console.WriteLine("Sunday");
}
else if (weekDay == 1)
{
    Console.WriteLine("Monday");
}
else if (weekDay == 2)
{
    Console.WriteLine("Tuesday");
}
else if (weekDay == 3)
{
    Console.WriteLine("Wednesday");
}
else if (weekDay == 4)
{
    Console.WriteLine("Thursday");
}
else if (weekDay == 5)
{
    Console.WriteLine("Friday");
}
else if (weekDay == 6)
{
    Console.WriteLine("Saturday");
};

Console.WriteLine("Have a great day!");
