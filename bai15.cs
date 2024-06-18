using System;
using System.Text;

class Program
{
    static byte ReadByte(byte minValue, byte maxValue)
    {
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= minValue && value <= maxValue)
                return value;
            else
                Console.WriteLine($"Nhập sai. Vui lòng nhập một số nguyên từ {minValue} đến {maxValue}.");
        }
    }

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

    static float[] ReadFloatArray(int n)
    {
        float[] array = new float[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập giá trị phần tử thứ {i + 1}:");
            array[i] = ReadFloat();
        }
        return array;
    }

    static void Main()
    {
        // Thiết lập encoding để hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;

        // Nhập giá trị cho n
        byte n = ReadByte(2, 10);
        Console.WriteLine($"Giá trị của n: {n}");

        // Khai báo mảng a và gọi hàm để nhập giá trị
        float[] a = new float[n];
        a = ReadFloatArray(n);

        // In ra giá trị của mảng a
        Console.WriteLine("Giá trị của mảng a:");
        foreach (float value in a)
            Console.WriteLine(value);
    }
}