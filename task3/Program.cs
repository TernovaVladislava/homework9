using System;
using static System.Console;
Clear();
WriteLine("Введите A:");
int a = int.Parse(ReadLine()!);

WriteLine("Введите B:");
int b = int.Parse(ReadLine()!);

WriteLine(AsyncCallback(a,b));
int ack(int n, int m)
{
    while (n !=0)
    {
        if(m==0) m=1;
        else m = ack(n, m-1);
        n = n-1;
    }
    return m + 1;
}
//В задаче m и n неверно стоят, поэтому 29, вместо 9
