using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập console để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Nhập và in ra giá trị của m, n
        byte m = ReadByteInRange(2, 10, "Nhập số hàng m (2-10): ");
        byte n = ReadByteInRange(2, 10, "Nhập số cột n (2-10): ");
        Console.WriteLine($"m = {m}, n = {n}");

        // Tạo và nhập giá trị cho mảng 2 chiều a
        int[,] a = new int[m, n];
        ReadArray2D(a);
        Console.WriteLine("Mảng a:");
        PrintArray2D(a);

        // Tính tổng các phần tử chia hết cho 2024
        int sum = SumDivisibleBy2024(a);
        Console.WriteLine($"Tổng các phần tử chia hết cho 2024: {sum}");
    }

    static byte ReadByteInRange(byte min, byte max, string prompt)
    {
        byte value;
        while (true)
        {
            Console.Write(prompt);
            if (byte.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static int ReadInt32()
    {
        int value;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static void ReadArray2D(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"Nhập phần tử a[{i},{j}]: ");
                array[i, j] = ReadInt32();
            }
        }
    }

    static void PrintArray2D(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static int SumDivisibleBy2024(int[,] array)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] % 2024 == 0)
                    sum += array[i, j];
            }
        }
        return sum;
    }
}