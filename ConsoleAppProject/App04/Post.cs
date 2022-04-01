using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        /// <summary>
        /// Variables declared for use in app
        /// </summary>
        public String Author;
        public DateTime Timestamp;
        private int likes;
        public int PostID;
        private static int intances = 0;
        public readonly List<String> comments;
        public NewsFeed NewsFeed = new NewsFeed();
  
        /// <summary>
        ///  COnstuctor for Post object
        /// </summary>
        public Post(String author)
        {
            intances++;

            PostID = intances;

            Author = author;

            Timestamp = DateTime.Now;

            likes = 0;

            comments = new List<String>();
        }

        /// <summary>
        /// Increases like for a post
        /// </summary>
        public void Like()
        {
            likes++;
        }

        /// <summary>
        /// decreases like for a post
        /// </summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        /// <summary>
        /// Display the post made by users
        /// </summary>
        public virtual void Display()
        {
           
            Console.WriteLine();
            Console.WriteLine($"      Post ID: {PostID}");
            Console.WriteLine($"      Author: {Author}");
            Console.WriteLine($"      Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"      Likes: -  {likes}  people like this.");
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


        /// <summary>
        /// Calculates since a post was made
        /// </summary>
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

        /// <summary>
        /// Used to display comments
        /// </summary>
        public void CommentDisplay()
        {
            foreach (string i in comments)

                Console.WriteLine(i);
        }

    }



}