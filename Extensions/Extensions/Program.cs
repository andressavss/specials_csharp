using Extension.Extesions;
using System;

namespace Extension;
class Program
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(2022, 11, 16, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());

        Console.WriteLine();
        string str = "Good morning dear students!";
        Console.WriteLine(str.Cut(10));

        Console.WriteLine();
        string str1 = "Hello world!";
        Console.WriteLine(str1.Cut(11));
    }
}
