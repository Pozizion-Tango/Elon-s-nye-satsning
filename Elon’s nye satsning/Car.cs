using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elon_s_nye_satsning
{
    internal class Car
    {
        private string _colour;
        private double battery;
        private int distance;
        private string display;
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public double Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public string Display
        {
            get { return display; }
            set { display = value; }
        }

        public void ShowDisplay()//Display is shown whenever a car is choosen, to show the status of it
        {
            Console.Clear();
            Console.Write($"Battery level: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Battery}%\r\n");
            Console.ResetColor();
            Console.Write($"Distance Drivien: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Distance} meters\r\n");
            Console.ResetColor();
        }
        public bool InvalidChoice()//a little get around, to use whenever there is a wrong choice choosen. Made in here to save a few lines of code.
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Choice");
            Console.ResetColor();
            return false;
        }
        public void Drive()//driving mode
        {
            while(true)//driving mode will continue to loop until the user select to stop driving mode themselves
            {

                Console.WriteLine("Press Enter To Drive 10 meters\r\n1: Drive 100 meters\r\n2: back");
                string choice = Console.ReadLine();
                if (choice == "" && this.Battery > 0.4)//if the battery have any juice left, it will be allowed to "drive" 10 meters
                {
                    this.Distance = this.Distance + 10;
                    this.Battery = Math.Round(this.Battery - 0.5, 2);
                    Console.Clear();
                    this.ShowDisplay();//the new states will be put onto the selected car, and updating the Status shown to the User
                }
                else if (choice == "1" && this.Battery > 4)//User can also select to drive more then 10 meters, this will drain the battery more
                {
                    this.Distance = this.Distance + 100;
                    this.Battery = Math.Round(this.Battery - 5, 2);
                    Console.Clear();
                    this.ShowDisplay();
                }
                else if (choice == "2")//user selects to leave driving mode
                    break;
                else//stop choosing something that is not there! Why are you doing this
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Choice");
                    Console.ResetColor();
                    this.ShowDisplay();
                }

            }
        }
        public void Charge()//yup, recharges it smartass~
        {
            this.Battery = 100;
            this.Distance = 0;//and resets it too i guess, does it even matter?
        }
    }
}
