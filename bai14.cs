using System;
using System.Text;

class Program
{
    static float ReadFloat()
    {
        float value;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out value))
                return value;
            else
                Console.WriteLine("Nhập sai. Vui lòng nhập lại một số thực.");
        }
    }

    static void Main()
    {Console.OutputEncoding = Encoding.UTF8;
        // Thiết lập encoding để hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;

        float x = ReadFloat();
        Console.WriteLine($"Giá trị được nhập: {x}");
    }
}