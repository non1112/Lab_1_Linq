using System;


namespace Lab_1_Linq
{
    public class Message
    {
        public static void WriteMassage(ConsoleColor cl,string text)
        {
            Console.ForegroundColor = cl;
            Console.WriteLine(text);
            Console.ResetColor();
        }

    }
}
