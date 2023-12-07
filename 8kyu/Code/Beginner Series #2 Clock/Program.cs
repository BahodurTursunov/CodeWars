/*Clock shows h hours, m minutes and s seconds after midnight.

Your task is to write a function which returns the time since midnight in milliseconds.

Example:
h = 0
m = 1
s = 1

result = 61000
Input constraints:

0 <= h <= 23
0 <= m <= 59
0 <= s <= 59
 */


using System;
public static class Clock
{
    public static int Past(int h, int m, int s)
    {
        //#Happy Coding! ^_^
        return ((h * 3600000) + (m * 60000) + (s * 1000));
    }

    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int res = Past(hours, minute, second);
        Console.WriteLine(res);
    }
}

