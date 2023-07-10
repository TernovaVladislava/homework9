using System;
using static System.Console;
Clear();
WriteLine("Введите A:");
int a = int.Parse(ReadLine()!);

WriteLine("Введите B:");
int b = int.Parse(ReadLine()!);

WriteLine(PrintNumbers(a, b));
string PrintNumbers(int a, int b)
{
    if (b == a || b == 1)
    {
        return 1;
    }
    int s = PrintNumbers(a,b - 1) + b;
    return s;
}