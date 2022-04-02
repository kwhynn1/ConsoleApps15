using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This app will allow the user to add messages and photos
    /// to a list of posts.  Users can also display those posts
    /// in a variety of ways.
    /// </summary>
    public class NetworkApp
    {
        public NewsFeed NewsFeed = new NewsFeed();


        public void Run()
        {            
            DisplayMenu();
        }

        public void DisplayMenu ()
        {

            ConsoleHelper.OutputHeading("Kyle News Feed");

            string[] choices = new string[]
            {
                "Add Message Post", "Add Photo Post", 
                "Display All Posts", "Display By Author" , 
                "Remove Post", "Like", "Unlike" , 
                "Add A Comment" , "Quit"
            };

            bool Quit = false; ;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice) 
                {
                    case 1: NewsFeed.CreateMessagePost();  break;
                    case 2: NewsFeed.CreatePhotoPost(); break;
                    case 3: DisplayAll();
                            break;
                    case 4:
                        DisplayByAuthor();
                        break;
                    case 5:
                        int ID;
                        RemovePost();
                        break;
                    case 6:
                        ID = LikePost();
                        break;
                    case 7:
                        ID = UnlikePost();
                        break;
                    case 8:
                        ID = AddComment();
                        break;
                    case 9:Quit=true; break;
                } 

            } while (!Quit);
        }

        private int AddComment()
        {
            int ID = (int)ConsoleHelper.InputNumber("      Enter Post ID For The Post You Want To Comment> ", 1, NewsFeed.AmountOfPosts());
            Console.WriteLine();
            Console.WriteLine("      Enter Your Comment");
            string comment = Console.ReadLine();
            NewsFeed.AddComment(ID, comment);
            return ID;
        }

        private int UnlikePost()
        {
            int ID = (int)ConsoleHelper.InputNumber("      Enter Post ID For The Post You Want To Unlike> ", 1, NewsFeed.AmountOfPosts());
            NewsFeed.unlike(ID);
            return ID;
        }

        private int LikePost()
        {
            int ID = (int)ConsoleHelper.InputNumber("      Enter Post ID For The Post You Want To Like> ", 1, NewsFeed.AmountOfPosts());
            NewsFeed.Addlike(ID);
            return ID;
        }

        private void RemovePost()
        {
            DisplayAll();
            int ID = (int)ConsoleHelper.InputNumber("      Enter Post ID For The Post You Want To Remove> ", 1, NewsFeed.AmountOfPosts());
            NewsFeed.FindPost(ID);
            NewsFeed.RemovePost(ID);
            Console.WriteLine();
        }

        private void DisplayByAuthor()
        {
            DisplayAll();
            Console.Write("      Enter Author Name> ");
            string author = Console.ReadLine();
            NewsFeed.FindPostByAuthor(author);
            Console.WriteLine();
        }

        private void DisplayAll()
        {
            NewsFeed.Display();
        }

    }
}