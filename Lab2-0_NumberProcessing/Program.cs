using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_0_NumberProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accumulation problem
            Console.WriteLine("\n-----ACCUMULATION PROBLEM-----");
            accumulation(1);  //1 year
            accumulation(2);  //2 years
            accumulation(5);  //5 years
            accumulation(10); //10 years


            ////Land cost calculator
            Console.WriteLine("\n\n-----LAND COST CALCULATOR-----");
            landCost();

            //Space Exploration
            Console.WriteLine("\n\n-----SPACE EXPLORATION-----");
            spaceExploration();

            //Extra Credit
            Console.WriteLine("\n\n-----EXTRA CREDIT-----");
            extraCredit();
        }

        static void accumulation(int years)
        {
            //declaring variables
            double deposit = 35.0, totalDeposited = 0;

            //calculating total ==> 365.25 for leap years. courtesy of yashmyn :)
            totalDeposited = deposit * 365.25 * years;

            //formatting and printing output
            Console.WriteLine("After {0} year(s), a total of {1:C2} was deposited.", 
                years, totalDeposited);
        }

        static void landCost()
        {
            //declaring variables
            double length = 0, width = 0, area = 0, perimeter = 0, totalCost = 0;
            const double costPerSqYard = 5.0, costPerFt = 0.75;
            String input = "";

            //taking input for land dimensions
            Console.Write("What is the length? ");
            input = Console.ReadLine();
            length = Convert.ToDouble(input);  //converting string to double

            Console.Write("What is the width? ");
            input = Console.ReadLine();
            width = Convert.ToDouble(input);  //converting string to double


            //calculations
            area = length * width / 9;  //accounting for yards
            perimeter = (2.0 * length) + (2.0 * width);
            totalCost = (area * costPerSqYard) + (perimeter * costPerFt);

            //formatting and printing output
            Console.WriteLine("\nLength: {0}ft \nWidth: {1}ft \nArea: {2:N3}sq yd" + 
                "\nPerimeter: {3}ft" + "\nTotalCost: {4:C2}", length, width, area, 
                perimeter, totalCost);
        }

        static void spaceExploration()
        {
            //declaring variables
            const double accelPer30Sec = 1.05; //increase by 5% per 30 seconds
            int minutesFired = 5;
            double velInitial = 10000.0, velFinal = velInitial;

    //First question
            //calculation
            //velFinal = velInitial * accelPerMin * minutesFired;
            for (int secPassed = 0; secPassed < minutesFired * 60; secPassed += 30 )
                velFinal *= accelPer30Sec;

                //formatting and printing output
                Console.WriteLine("\nThe rocket will go {0:N} mph after firing for 5 min.",
                    velFinal);


    //Second question
                //resetting final answer and minutes fired for 
                velFinal = velInitial;

                //since each cycle is 15 minutes, will just keep recalculating  
                //velocity after every 5-minute boost until 2 hours have passed
                for (int minPassed = 0; minPassed < 120; minPassed += 15 )//per cycle

                    for (int secPassed = 0; secPassed < minutesFired * 60; secPassed+=30)
                        velFinal *= accelPer30Sec;

                //formatting and printing output
                Console.WriteLine("\nThe rocket will go {0:N} mph after a 2-hour cycle" +
                    "of a 5-min burn followed by a 10-min coast.", velFinal);
        }

        static void extraCredit()
        {
            //declaring variables
            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0, discriminant = 0;
            String input = "", output = "";

            //taking input for a, b and c
            Console.Write("What is a? ");
            input = Console.ReadLine();
            a = Convert.ToDouble(input);

            Console.Write("What is b? ");
            input = Console.ReadLine();
            b = Convert.ToDouble(input);

            Console.Write("What is c? ");
            input = Console.ReadLine();
            c = Convert.ToDouble(input);

            //calculating discriminant (tells if equation has real solutions)
            discriminant = (b * b) - (4 * a * c);

            //terminating program if equation is unsolvable
            if (discriminant < 0)
            {
                Console.WriteLine("This equation has no real solutions.");
                return;
            }

            //we know the equation is solvable, so solving it.
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            //printing solutions
            Console.WriteLine("X = " + x1 + " , " + x2);
        }
    }
}