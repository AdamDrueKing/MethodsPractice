using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods are a tool for us to create reusable pieces of code.
            //Methods are a way for us collecting a series of instructions and then call them when needed.
            //Methods are ALWAYS part of a class. Methods are ALWAYS children of classes.
            //This means a method will NEVER be created inside another method or member of the class. However...
            //...methods are frequently CALLED inside of another class or method.
            //Console.WriteLine("Hello. Please enter the first number to be added.");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number to be added.");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int answer = Add(numberOne, numberTwo);
            //Console.WriteLine(answer);

            //RobotWarning("Will Robinson");

            //Console.WriteLine("Please enter a name.");
            //RobotWarning(Console.ReadLine());

            string myBirthMonth = "September";
            string myFriendBirthMonth = "December";
            string myVehicle = Vehicle(myBirthMonth);
            string myFriendVehicle = Vehicle(myFriendBirthMonth);

            Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle is {1}.", myVehicle, myFriendVehicle);
        }
        //Method header
        //Access Modifier - Return Type - Method Name (in Pascal Case) - Parentheses (sometimes with parameters)
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method body
            //A complete method - header and body - is called a method declaration
            int sum = firstNumber + secondNumber;
            return sum;
            //The "return" keyword takes whatever value is determined by using this method and sends that value...
            //...back to where the method is called.
        }
        //If you have a method that does NOT have a return value, you would use the keyword "void." When we have a...
        //"void" return type we DON'T need to use the keyword "return."

        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!!");
        }


        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";
            }
            else
            {
                vehicleFortune = "SUV";
            }
            return vehicleFortune;
        }

    }
}
