using System;

var now = DateTime.Now;
var first = new DateTime(now.Year, now.Month, 1);

Console.WriteLine($"{now:MMMM yyyy}");
Console.WriteLine("Su Mo Tu We Th Fr Sa");

int pad = (int)first.DayOfWeek;
for (int i = 0; i < pad; i++) Console.Write("   ");

for (int d = 1; d <= DateTime.DaysInMonth(now.Year, now.Month); d++)
{
    Console.Write($"{d,2} ");
    if ((pad + d) % 7 == 0) Console.WriteLine();
}
