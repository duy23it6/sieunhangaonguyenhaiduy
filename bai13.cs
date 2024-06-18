using System;
using System.Text;

class Program
{
    static byte ReadByte()
    {
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
                return value;
            else
                Console.WriteLine("Nhập sai. Vui lòng nhập lại một số nguyên từ 2 đến 10.");
        }
    }

    static void Main()
    {Console.OutputEncoding = Encoding.UTF8;
        // Thiết lập encoding để hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;

        byte n = ReadByte();
        Console.WriteLine($"Giá trị được nhập: {n}");
    }
}