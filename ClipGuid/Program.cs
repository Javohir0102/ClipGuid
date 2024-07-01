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
                string stringFieldGuid = Guid.NewGuid().ToString();
                Console.WriteLine(stringFieldGuid);
                TextCopy.ClipboardService.SetText(stringFieldGuid);
                Console.WriteLine("Copied");
                
                Console.WriteLine("Do you want again NewGuid? press yes");
                selection = Console.ReadLine();
            } 
            while (selection == "yes");
        }
    }
}
