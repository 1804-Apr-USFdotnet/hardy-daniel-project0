using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Layer;

namespace Project0App
{
    class Program
    {
        static void showMenu()
        {
            Console.WriteLine("Welcome to Resturant Ratings (Project0)\n\rPress 1: To view resturants");
        }
        static void Main(string[] args)
        {
            BusinessLayer bl = new BusinessLayer();
            int menuOption = 0;
            bool Quit = false;
            showMenu();
            Console.ReadLine();


        }
    }
}
