﻿using System;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.DTOS;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            ShoppingCart myShoppingCart = new ShoppingCart();

            string response = "";

            while (response!="5")
            {
                myShoppingCart.PrintMenu();

                response = myShoppingCart.CaptureResponse();

                switch(response)
                {
                    case "1":
                        myShoppingCart.CreateUser();
                        break;
                    case "2":
                        myShoppingCart.CreateComment();
                        break;
                    case "3":
                        myShoppingCart.ShowAllExistingUsers();
                        break;
                    case "4":
                        myShoppingCart.ShowAllExistingCakeReviews();
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}