﻿
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay)
{
	case 0:
		Console.WriteLine("It's Sunday!");
		break;
	case 1:
		Console.WriteLine("It's Monday!");
		break;
	case 2:
		Console.WriteLine("It's Tuesday!");
		break;
	case 3:
		Console.WriteLine("It's Wednesday!");
		break;
	case 4:
		Console.WriteLine("It's Thursday!");
		break;
	case 5:
		Console.WriteLine("It's Friday!");
		break;
	case 6:
		Console.WriteLine("It's Saturday!");
		break;
	default:
		Console.WriteLine("Something is wrong with your calendar! Please consult with tech support!");
		break;
};

Console.WriteLine("Have a great day!");