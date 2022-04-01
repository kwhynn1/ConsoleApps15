using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NewsFeed
    {
        private readonly List<Post> posts;
        public String Message;
        public String Author;
        public String Filename;
        public String Caption;
        public int like;

        public NewsFeed()
        {
            posts = new List<Post>();
        }

        public void AddPhoto(PhotoPost photo)
        {
            posts.Add(photo);
        }

        public void AddMessagePost(MessagePost post)
        {
            posts.Add(post);
        }

        public void Display()
        {
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();
            }
        }

        public void CreateMessagePost()
        {

            Console.WriteLine();
            Message = EnterText("      Enter Message >");
            Console.WriteLine();
            Author = EnterText("      Enter Author >");
            Console.WriteLine();
            MessagePost post = new MessagePost(Message, Author);
            AddMessagePost(post);
        }

        public void CreatePhotoPost()
        {
            Console.WriteLine();
            Filename = EnterText("      Enter Filename >");
            Console.WriteLine();
            Caption = EnterText("      Enter Caption >");
            Console.WriteLine();
            PhotoPost post = new PhotoPost(Author, Filename, Caption);
            AddPhoto(post);
        }

        public string EnterText(string EnterTextMessage)
        {
            string text;
            Console.Write(EnterTextMessage);
            text = Console.ReadLine();
            return text;
        }

        public Post FindPost(int id)
        {
            foreach (Post post in posts)
                if (post.PostID == id)
                {
                    return post;
                }
            return null;
        }

        public void FindPostByAuthor(String author)
        {
            foreach (Post post in posts)
                if (post.Author == author)
                {
                    post.Display();
                }
                else
                {
                    Console.WriteLine("      Author Not Found");
                }
        }

        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post != null)
            {
                Console.WriteLine($"\n      The Post with ID {id} has been Removed");
                posts.Remove(post);
            }
            else
            {
                Console.WriteLine($"\n      The Post with ID {id} does not exist");
            }

        }

        public int AmountOfPosts()
        {
            return posts.Count;
        }

        public void AddComment(int ID, string text)
        {
            foreach (Post post in posts)

                if (post.PostID == ID)
                {
                    post.comments.Add(text);
                }
        }

        public void Addlike(int ID)
        {
            foreach (Post post in posts)

                if (post.PostID == ID)
                {
                    post.Like();
                }

        }

        public void unlike(int ID)
        {
            foreach (Post post in posts)

                if (post.PostID == ID)
                {
                    post.Unlike();
                }
        }


    }
}
  
