using System;
using System.Text;

public class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập xâu kí tự: ");
        string st = Console.ReadLine();

        if (st == "#")
        {
            Console.Beep();
        }
        else
        {
            int wordCount = countWords(st);
            Console.WriteLine($"Số từ trong xâu kí tự: {wordCount}");
        }
    }

    static int countWords(string text)
    {
        // Loại bỏ các khoảng trắng thừa
        text = text.Trim();

        // Nếu xâu rỗng, trả về 0 từ
        if (string.IsNullOrEmpty(text))
            return 0;

        // Đếm số từ bằng cách tách xâu thành mảng các từ và đếm số phần tử
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}