using System;
using System.Collections.Generic;

namespace BakeryShoppingCart.Models
{
    public class ShoppingCart
    {
        private List<User> userList = new List<User>();
        private List<Comment> usercommentList = new List<Comment>();

        public ShoppingCart()
        {
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. Create a User");
            Console.WriteLine("2. Create a Comment");
            Console.WriteLine("3. Print the list of Users");
            Console.WriteLine("4. Print the list of Comments");
            Console.WriteLine("5. Look for a user");
            Console.WriteLine("6. Look for a comment");
            Console.WriteLine("7. Exit");
        }

        public string CaptureResponse()
        {
            string response = Console.ReadLine();

            return response;
        }

        public void CreateUser()
        {
            User myUser = new User();
            myUser.Email = "myemail@somewhere.com";
            myUser.Password = "Password";
            myUser.UserId = 1;
            myUser.UserName = "Mario";

            userList.Add(myUser);

            Console.WriteLine("");
            Console.WriteLine("You have created a User for your Shopping Cart");
            Console.WriteLine("");
        }

        public void CreateComment()
        {
            Comment myComment = new Comment();
            myComment.CommentId = 1;
            myComment.TheComment = "Hello";

            usercommentList.Add(myComment);

            Console.WriteLine("You have created a comment");
        }

        public void ShowAllExistingUsers()
        {
            int userCount = 1;

            string format = "User {0}: Has the following data.- User Name[{1}], Password[{2}], " +
                            "UserId[{3}], Email[{4}]";

            Console.WriteLine("");
            foreach (var user in userList)
            {
                Console.WriteLine(String.Format(format, userCount, user.UserName, user.Password,
                                                user.UserId, user.Password));

                userCount++;
            }
            Console.WriteLine("");
        }

        public void ShowAllExistingCakeReviews()
        {
            Console.WriteLine("This is the list of comments created");

            foreach (var insideComment in usercommentList)
            {
                Console.WriteLine("The comment id is: " + insideComment.CommentId);
                Console.WriteLine("The actual comment is: " + insideComment.TheComment);
            }
        }
    }
}
