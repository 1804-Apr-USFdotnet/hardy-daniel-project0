using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static BusinessLayer.BusinessLibrary bm = new BusinessLayer.BusinessLibrary();
        static Models.Resturant resturant;
        static List<Models.Resturant> list;

        static void getAllResturants()
        {
            list = bm.getAllResturants();
        }
        static Models.Resturant GetResturant()
        {
            Console.WriteLine("Please choose from the following:");
            showResturants();
            String input = Console.ReadLine();
            int userChoice = int.Parse(input);
            userChoice--; // convert optionbase zero
            return list[userChoice];
        }

        static void showResturants()
        {
            int i = 1;
            foreach (var res in list)
            {
                Console.WriteLine("{0}:{1} at {2} {3},{4}",i, res.Name, res.Address,res.City,res.State);
                i++;
            }
        }
        static void showResturantDetails()
        {
            resturant = GetResturant();
            Console.WriteLine("{0}  {1} {2}, {3}. {4}",resturant.Name,resturant.Address,resturant.City,resturant.State,resturant.FoodType);
        }
        static void showAllReviewForResturant()
        {
            resturant = GetResturant();
            Console.WriteLine("Show all reviews for:{0}  at  {1}", resturant.Name, resturant.Address);
            foreach (var rev in resturant.Reviews)
            {
                Console.WriteLine(rev.Author);
                Console.WriteLine(rev.Rating);
                Console.WriteLine(rev.Comment + "\n\r\n\r\n\r");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!!!!");
            getAllResturants();
            //showResturants();
            bool quit = false;
            Console.WriteLine("Welcome to Daniel's Project0");
            while (!quit)
            {
                Console.WriteLine("Press 1: To view the resturants\n\rPress 2: To view details of a Resturant\n\rPress 3: to view Reviews for a Resturant");
                String input = Console.ReadLine();
                int userChoice = int.Parse(input);

                switch(userChoice)
                {
                    case 1:
                        {
                            showResturants();
                            break;
                        }
                    case 2:
                        {
                            showResturantDetails();
                                break;
                        }
                    case 3:
                        {
                            showAllReviewForResturant();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }

                }
                Console.WriteLine("Press y to quit");
                String userInput = Console.ReadLine();
                char Choice = 'n';
                char.TryParse(userInput, out Choice);
                if (Choice == 'y' || Choice == 'Y') quit = true;
            }
            //Console.WriteLine("Enter a number to view the reviews from that resturant");
            //String input = Console.ReadLine();
            //int userChoice = int.Parse(input);
            //resturant = GetResturant(userChoice);
            //showAllReviewForResturant(resturant);
            //Console.Read();
        }
    }
}
