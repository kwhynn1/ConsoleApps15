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
                "Display All Posts", "Display By Author" , "Remove Post", "Like", "Unlike" , "Add A Comment" , "Quit"
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
                    case 4: DisplayAll();
                            Console.Write("      Enter Author Name> "); 
                            string author = Console.ReadLine();
                            NewsFeed.FindPostByAuthor(author);
                            Console.WriteLine();
                            break;
                    case 5: DisplayAll(); 
                            int ID = (int)ConsoleHelper.InputNumber("      Enter Post ID For The Post You Want To Remove> ", 1, NewsFeed.AmountOfPosts());
                            NewsFeed.FindPost(ID); 
                            NewsFeed.RemovePost(ID);
                            Console.WriteLine();
                            break;
                    case 6:
                            ID = (int)ConsoleHelper.InputNumber("      Enter Post ID For The Post You Want To Comment> ", 1, NewsFeed.AmountOfPosts());
                            NewsFeed.Addlike(ID);
                            break;
                    case 7:
                            ID = (int)ConsoleHelper.InputNumber("      Enter Post ID For The Post You Want To Comment> ", 1, NewsFeed.AmountOfPosts());
                            NewsFeed.unlike(ID);
                            break;
                    case 8:
                            ID = (int)ConsoleHelper.InputNumber("      Enter Post ID For The Post You Want To Comment> ", 1, NewsFeed.AmountOfPosts());
                            Console.WriteLine();
                            Console.WriteLine("Enter Your Comment");
                            string comment = Console.ReadLine();
                            NewsFeed.AddComment(ID, comment);   
                            break;
                    case 9:Quit=true; break;

                } 

            } while (!Quit);

        }

        private void DisplayAll()
        {
            NewsFeed.Display();
        }

    }
}