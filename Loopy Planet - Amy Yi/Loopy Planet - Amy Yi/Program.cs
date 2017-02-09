using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopy_Planet___Amy_Yi
{
    class Program
    {
        static void Main(string[] args) //start of Main
        {

            //the entire program is in a loop
            //here a boolean variable is declared for the condition of the while to be true
            bool runLoopy = true;

            //the program will continue to loop as long as runLoopy is true
            while (runLoopy)
            {
                //prints the menu
                Console.WriteLine("         Menu of Planets");
                Console.WriteLine("         ==== == =======");
                Console.WriteLine("1.Jupiter     2.Mars      3.Mercury");
                Console.WriteLine("4.Neptune     5.Pluto     6.Saturn");
                Console.WriteLine("7.Uranus      8.Venus     9.< Quit > ");
                Console.WriteLine(" ");

                //declared an int variable for holding the menu choice
                int casePlanet;

                //loop that continues asking for the menu choice if user enters invaid values
                while (true)
                {
                    //prints a line asking the user for their desired menu choice
                    Console.Write("Enter your menu choice: ");
                    try
                    {
                        //rejects the value if the value entered is not an integer
                        casePlanet = int.Parse(Console.ReadLine());
                    }

                    catch
                    {
                        //loop continues to next iteration (aka asking for the menu choice again)
                        continue;
                    }

                    //asks for menu choice again if casePlanet is equal to or less than zero or greater than 9
                    if ((casePlanet <= 0) || (casePlanet > 9))
                    {
                        //loop continues to next iteration (aka asking for the menu choice again)
                        continue;
                    }
                    else
                    {
                        //if no exception occurs, program continues to next block of code
                        break;
                    }
                }

                //the user may exit the program if menu choice 9 is entered
                if (casePlanet == 9)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Have a great day! Goodbye!"); //prints goodbye message when user exits the program
                    break;

                }


                //declares variable to hold the users weight on earth
                double weightPounds;

                do
                {                    
                    Console.Write("Enter your weight in pounds: "); //prints a line asking the user for their weight in pounds
                    try
                    {                        
                        weightPounds = double.Parse(Console.ReadLine()); //rejects the value if the value entered is not a double
                    }
                    catch
                    {
                        //unable to use continue here so set a negative value to ensure that the user will continue to be prompted to enter a valid value
                        weightPounds = -1;
                    }

                } while (weightPounds <= 0); //if weight is 0 or negative, keep looping


                Console.WriteLine(" ");

                //method to convert the weight into a string number with one decimal place
                string weightPoundsString;
                weightPoundsString = string.Format("{0:0.0}", weightPounds);

                //switch cases for eight different planets
                switch (casePlanet)
                {
                    case 1:                        
                        double weightJupiter; //declares variable for the calculated weight on Jupiter                        
                        weightJupiter = weightPounds * 2.64; //calculates the weight on Jupiter                        
                        string weightJupiterString; //declares string variable to round the result to one decimal place                                            
                        weightJupiterString = string.Format("{0:0.0}", weightJupiter); //method to convert weightJupiter into a string number with one decimal place
                        //prints out the weight on earth and weight on Jupiter
                        Console.WriteLine("Your weight of " + weightPoundsString + " pounds on Earth would be " + weightJupiterString + " pounds on Jupiter.");
                        break;

                    case 2:
                        double weightMars;
                        weightMars = weightPounds * 0.38;
                        string weightMarsString;
                        weightMarsString = string.Format("{0:0.0}", weightMars);
                        Console.WriteLine("Your weight of " + weightPoundsString + " pounds on Earth would be " + weightMarsString + " pounds on Mars.");
                        break;

                    case 3:
                        double weightMercury;
                        weightMercury = weightPounds * 0.37;
                        string weightMercuryString;
                        weightMercuryString = string.Format("{0:0.0}", weightMercury);
                        Console.WriteLine("Your weight of " + weightPoundsString + " pounds on Earth would be " + weightMercuryString + " pounds on Mercury.");
                        break;

                    case 4:
                        double weightNeptune;
                        weightNeptune = weightPounds * 1.12;
                        string weightNeptuneString;
                        weightNeptuneString = string.Format("{0:0.0}", weightNeptune);
                        Console.WriteLine("Your weight of " + weightPoundsString + " pounds on Earth would be " + weightNeptuneString + " pounds on Neptune.");
                        break;

                    case 5:
                        double weightPluto;
                        weightPluto = weightPounds * 0.04;
                        string weightPlutoString;
                        weightPlutoString = string.Format("{0:0.0}", weightPluto);
                        Console.WriteLine("Your weight of " + weightPoundsString + " pounds on Earth would be " + weightPlutoString + " pounds on Pluto.");
                        break;

                    case 6:
                        double weightSaturn;
                        weightSaturn = weightPounds * 1.15;
                        string weightSaturnString;
                        weightSaturnString = string.Format("{0:0.0}", weightSaturn);
                        Console.WriteLine("Your weight of " + weightPoundsString + " pounds on Earth would be " + weightSaturnString + " pounds on Saturn.");
                        break;

                    case 7:
                        double weightUranus;
                        weightUranus = weightPounds * 1.15;
                        string weightUranusString;
                        weightUranusString = string.Format("{0:0.0}", weightUranus);
                        Console.WriteLine("Your weight of " + weightPoundsString + " pounds on Earth would be " + weightUranusString + " pounds on Uranus.");
                        break;

                    case 8:
                        double weightVenus;
                        weightVenus = weightPounds * 0.37;
                        string weightVenusString;
                        weightVenusString = string.Format("{0:0.0}", weightVenus);
                        Console.WriteLine("Your weight of " + weightPoundsString + " pounds on Earth would be " + weightVenusString + " pounds on Venus.");
                        break;

                }


                //adds spaces everytime the program is re-initialized
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            
            Console.ReadLine(); //stops the console so you can see the result
        
        //end of Main
        }
    }
}
