using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int a = 0; 
            foreach (string item in strings) 
            { 
                if (a < item.Length) a = item.Length; 
            }
            for (int i = 0; i < a + 3; i++) 
                Console.Write("*"); 
            Console.WriteLine("*"); 
            foreach (string item in strings) 
            { 
                if (item.Length < a) 
                {
                    var s = "";
                    for (int i = 0; i < a - item.Length; i++) 
                        s += " ";
                    Console.WriteLine("* " + item + s + " *");
                } 
                else 
                    Console.WriteLine("* " + item + " *"); 
            }
            for (int i = 0; i < a + 3; i++) 
                Console.Write("*"); 
            Console.WriteLine("*");
        }
    }
}