using NLog;
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
        static List<Models.Resturant> top3Resturants;
        private static Logger logger = LogManager.GetCurrentClassLogger();
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
        static void showAllResturantsByName()
        {
            list = bm.getResturantsbyName();
            showResturants();
            
        }

        static void showAllResturantsByState()
        {
            list = bm.getResturantsbyState();
            showResturants();

        }

        static void searchForAResturant()
        {
            Console.WriteLine("Enter a name or a partial to search for");
            String str = Console.ReadLine();
            var partialList = bm.SearchRestutants(str);

            Console.WriteLine("Here are the Results:\n\r");

            foreach (var rest in partialList)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",rest.Name,rest.Address,rest.City,rest.State,rest.FoodType);
            }
        }

        static void showTheTop3Resturants()
        {
            var top = bm.getTopResturants();
            foreach (var rest in top)
            {
                Console.WriteLine("{0}\n\r{1} {2} {3} {4} Average Rating: {5}\n\r", rest.Name, rest.Address, rest.City, rest.State, rest.FoodType, rest.getAverageRating());
            }
        }

        static void Main(string[] args)
        {
           
            getAllResturants();
            bool quit = false;
            Console.WriteLine("Welcome to Daniel's Project0");
            
            while (!quit)
            {
                Console.WriteLine("Press 1: To view the resturants\n\r" +
                    "Press 2: To view details of a Resturant\n\r" +
                    "Press 3: To view Reviews for a Resturant\n\r" +
                    "Press 4: To Sort the Resturants by Name\n\r" +
                    "Press 5: To Sort the Resturants by State\n\r" +
                    "Press 6: To See the Top 3 rated Resturants\n\r" +
                    "Press 7: To Search Resturants");
                String input = Console.ReadLine();
                logger.Info("User has entered " + input);
                int userChoice = int.Parse(input);
                
                switch (userChoice)
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
                    case 4:
                        {
                            showAllResturantsByName();
                            break;
                        }
                    case 5:
                        {
                            showAllResturantsByState();
                            break;
                        }
                    case 6:
                        {
                            showTheTop3Resturants();
                            break;
                        }
                    case 7:
                        {
                            searchForAResturant();
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
            
        }
    }
}
