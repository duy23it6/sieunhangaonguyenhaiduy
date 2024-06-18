using System;
using System.Text;

class Program
{
    static ushort ReadUInt16()
    {
        ushort value;
        while (true)
        {
            if (ushort.TryParse(Console.ReadLine(), out value))
                return value;
            else
                Console.WriteLine("Nhập sai. Vui lòng nhập lại.");
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        // Thiết lập encoding để hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;

        ushort n = ReadUInt16();
        Console.WriteLine($"Giá trị được nhập: {n}");

        long sum = 0;
        for (ushort i = 1; i <= n; i++)
            sum += i * i;

        Console.WriteLine($"Tổng bình phương các số từ 1 đến {n} là: {sum}");
    }
}