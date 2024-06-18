using System;
using System.Text;

public class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        double x = ReadDouble();
        Console.WriteLine($"Căn bậc 2 của {x} là: {Math.Sqrt(x)}");
    }

    static double ReadDouble()
    {
        double value;
        while (true)
        {
            Console.Write("Nhập số thực 8 byte: ");
            if (double.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Nhập sai, vui lòng nhập lại.");
        }
    }
}