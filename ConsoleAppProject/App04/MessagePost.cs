using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{

    public class MessagePost : Post
    {

        public String Message;

        public MessagePost(String text, string author) : base(author)
        {
            Message = text;
        }


        public override void Display() 
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      Message Post");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine($"      " +
                $"Messsage: {Message}");

            base.Display();
        }

    }
}