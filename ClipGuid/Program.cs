using TextCopy;
using System;

namespace ClipGuid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selection = "";
            do
            {
                Console.WriteLine("1. NewGuid\n2. DateTimeOffset");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    string stringFieldGuid = Guid.NewGuid().ToString();
                    Console.WriteLine(stringFieldGuid);
                    TextCopy.ClipboardService.SetText(stringFieldGuid);
                }
                if (input == 2)
                {
                    string dateTimeOffSet = DateTimeOffset.Now.ToString();
                    Console.WriteLine(dateTimeOffSet);
                    TextCopy.ClipboardService.SetText(dateTimeOffSet);
                }
                Console.WriteLine("Copied");

                Console.WriteLine("Do you want again? press yes");
                selection = Console.ReadLine();
            }
            while (selection == "yes");
        }
    }
}
