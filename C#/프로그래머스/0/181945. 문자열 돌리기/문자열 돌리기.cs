using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        for (int i = 0; i < s.Length; i++)
        {
            Char r = s[i];
            Console.WriteLine(r);
        }
    }
}