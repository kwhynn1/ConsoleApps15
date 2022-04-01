using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    public class PhotoPost : Post
    {

        public String Filename;

        public String Caption;

        public PhotoPost(String author, String filename, String caption) : base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }

        public override void Display()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      Photo Post");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine($"      Filename: {Filename}");
            Console.WriteLine($"      Caption: {Caption}");

            base.Display();
        }

    }
}