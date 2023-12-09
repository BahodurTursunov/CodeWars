/*
Summation
Write a program that finds the summation of every number from 1 to num. 
The number will always be a positive integer greater than 0. Your function only needs to return the result,
what is shown between parentheses in the example below is how you reach that result and it's not part of it,
see the sample tests.

For example (Input -> Output):

2 -> 3 (1 + 2)
8 -> 36 (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8)
*/

/*
 using System;
using NUnit.Framework;

[TestFixture]
public static class KataTests 
{
    [Test]
    public static void BasicTests() 
    {
        Assert.AreEqual(1, Kata.summation(1));
        Assert.AreEqual(36, Kata.summation(8));
        Assert.AreEqual(253, Kata.summation(22));
        Assert.AreEqual(5050, Kata.summation(100));
        Assert.AreEqual(22791, Kata.summation(213));
    }
}*/

class Program
{
    public static int Summation(int num)
    {
        int result = 0;
        for (int i = 1; i <= num; i++)
        {
            result += i;
        }
        return result;
    }
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(Summation(input));
    }
}