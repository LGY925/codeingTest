using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);
        string output = input[0];
       for (int i= 1;  i < a; i++)
        {
            input[0] =input[0]+ output;
        }
        Console.WriteLine(input[0]);
    }
}