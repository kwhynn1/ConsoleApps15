using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        public String Author;

        public DateTime Timestamp;

        private int likes;

        public int PostID;

        private static int intances = 0;

        public readonly List<String> comments;

        public NewsFeed NewsFeed = new NewsFeed();
  

        public Post(String author)
        {
            intances++;

            PostID = intances;

            Author = author;

            Timestamp = DateTime.Now;

            likes = 0;

            comments = new List<String>();
        }


        public void Like()
        {
            likes++;
        }


        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }


        public virtual void Display()
        {
           
            Console.WriteLine();
            Console.WriteLine($"      Post ID: {PostID}");
            Console.WriteLine($"      Author: {Author}");
            Console.WriteLine($"      Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes: -  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine("      No Likes");
            }

            Console.WriteLine();

            if (comments == null)
            {
                Console.WriteLine("      No comment");
            }
            else
            {
                Console.Write("      Comment:");
                CommentDisplay();
                Console.WriteLine();
            }
        }


        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }

        public void CommentDisplay()
        {
            foreach (string i in comments)

                Console.WriteLine(i);
        }

    }



}