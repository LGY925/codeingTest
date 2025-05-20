using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        division(a);

    }
    static void division(int a) // 홀짝 구분 함수
    {
        int b = a % 2;
        if (b == 0)
        {
            Console.WriteLine("{0} is even", a);
        }
        else
        {
            Console.WriteLine("{0} is odd", a);
        }
            
    }
}