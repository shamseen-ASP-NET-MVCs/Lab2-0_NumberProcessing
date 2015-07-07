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
           // landCost();

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
            String output = "";

            //calculating total
            totalDeposited = deposit * 365 * years;

            //formatting and printing output
            output = String.Format("After {0} year(s), a total of {1:C2} was deposited.", years, totalDeposited);
            Console.WriteLine(output);
        }

        static void landCost()
        {
            //declaring variables
            double length = 0, width = 0, area = 0, perimeter = 0, totalCost = 0;
            const double costPerSqYard = 5.0, costPerFt = 0.75;
            String input = "", output = "";

            //taking input for land dimensions
            Console.Write("What is the length? ");
            input = Console.ReadLine();
            length = Convert.ToDouble(input);  //converting string to double

            Console.Write("What is the width? ");
            input = Console.ReadLine();
            width = Convert.ToDouble(input);  //converting string to double


            //calculations
            area = length * width;
            perimeter = (2.0 * length) + (2.0 * width);
            totalCost = (area * costPerSqYard) + (perimeter * costPerFt);

            //formatting output
            output = String.Format("\nLength: {0}ft \nWidth: {1}ft \nArea: {2}sq ft \nPerimeter: {3}ft \nTotalCost: {4:C2}",
                length, width, area, perimeter, totalCost);

            Console.WriteLine(output);
        }

        static void spaceExploration()
        {
            //declaring variables
            const double accelPerMin = 1.1; //in percent
            const int minutesFired = 5;
            double velInitial = 10000.0, velFinal = 0;
            String output = "";


            //First question
            //calculation
            velFinal = velInitial * accelPerMin * minutesFired;

            //formatting and printing output
            output = String.Format("\nThe rocket will go {0:N1} mph after firing for 5 minutes.", velFinal);
            Console.WriteLine(output);


            //Second question
            //resetting final answer
            velFinal = velInitial;

            //since each cycle is 15 minutes, will just keep recalculating velocity after every 5-minute boost
            //until 2 hours have passed
            for (int totalMin = 0; totalMin <= 120; totalMin += 15) //overall time passed with each cycle
                velFinal *= accelPerMin * minutesFired;

            //formatting and printing output
            output = String.Format("\nThe rocket will go {0:N1} mph after a 2-hour cycle of 5-min burn + 10-min coast.",
                velFinal);
            Console.WriteLine(output);
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