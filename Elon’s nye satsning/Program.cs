using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_nye_satsning
{
    internal class Program
    {
        static void Main(string[] args)
        { //First we have some startup settings, to define the cars and what propities they hold
            Car mazda = new Car();
            Car tesla = new Car();
            mazda.Colour = "Red";
            tesla.Colour = "Blue";
            mazda.Battery = 100;
            tesla.Battery = 100;
            mazda.Distance = 0;
            tesla.Distance = 0;
            bool invalid = false;//invaild is used throughout the program to tell the user that their input is unusable

            while (true)//The first While(true) is used to play the main program itself. 
            {
                Console.Clear();
                Console.WriteLine("1: for tesla\r\n2: for mazda\r\n3: Exit");
                string choice = Console.ReadLine();//program awaits input from the user to select one of the options proposed to them

                bool backtesla = false;//These false statment bools will reset  the next while loop to default
                bool backmazda = false;

                //This first If/Else statment is used to navigate the first UI
                if (choice == "1")//Tesla Selection
                {

                    while (!backtesla)//the user selected the Tesla, and will be shown another options menu. to either select Drive, Charge, Back
                    {
                        tesla.ShowDisplay();//shows the status of the Tesla
                        if (invalid)
                            invalid = tesla.InvalidChoice();//Whatever the user typed is invaild to the selection menu
                        Console.WriteLine("1: for driving\r\n2: for recharge\r\n3: back");
                        choice = Console.ReadLine();
                        if (choice == "1")//user selected Drive and will be giving the driving UI
                        {
                            tesla.ShowDisplay();//display is shown
                            tesla.Drive();//entering driving mode
                        }
                        else if (choice == "2")//user selected recharge, and have their car reset
                            tesla.Charge();
                        else if (choice == "3")//user selected back, and is there for send back to the main menu
                            backtesla = true;
                        else//hey! That wasn't on the menu
                            invalid = true;
                    }
                }
                else if (choice == "2")//Mazda Selection
                {

                    while (!backmazda)//the user selected the Mazda, and will be shown another options menu. to either select Drive, Charge, Back
                    {
                        mazda.ShowDisplay();//shows the status of the Mazda
                        if (invalid)
                            invalid = mazda.InvalidChoice();//Whatever the user typed is invaild to the selection menu
                        Console.WriteLine("1: for driving\r\n2: for recharge\r\n3: back");
                        choice = Console.ReadLine();
                        if (choice == "1")//user selected Drive and will be giving the driving UI
                        {
                            mazda.ShowDisplay();//display is shown
                            mazda.Drive();//entering driving mode
                        }
                        else if (choice == "2")//user selected recharge, and have their car reset
                            mazda.Charge();
                        else if (choice == "3")//user selected back, and is there for send back to the main menu
                            backmazda = true;
                        else//hey! That wasn't on the menu
                            invalid = true;
                    }
                }
                else if (choice == "3")//Exit, terminating the program
                    break;
                else//oooohh wupsi, whatever you typed is invalid for the UI selection
                {
                    Console.Clear();
                    invalid = tesla.InvalidChoice();//that is says Tesla doesn't matter
                    Console.ReadKey();
                }
                    
            } 
        }
    }
}
