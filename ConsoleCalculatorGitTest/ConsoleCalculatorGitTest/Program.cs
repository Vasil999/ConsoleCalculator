using System;

namespace ConsoleCalculatorGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vasil Paskalev
            //04.04.2020
            //Calculator
            while (true)
            {
                double angle, firstNumber, secondNumber, result; string operation; //declare variables

                //Welcome the user
                Console.WriteLine("_____________________________Welcome to C# Console Calculator_____________________________");
                Console.WriteLine("------------------------------------------------------------------------------------------");

                //let the user chose an operation
                Console.Write("Enter one of the operations \"+\", \"-\", \"*\", \"/\", \"%\", \"sin()\", \"cos()\", \"tan()\" here: ");

                operation = Console.ReadLine(); //Save value that user has chosen as operation

                switch (operation) //differ trigonometric an algebraic operations
                {
                    case "sin()":
                    case "cos()":
                    case "tan()": //trigonometric operations

                        Console.WriteLine("------------------------------------------------------------------------------------------");

                        //let the user enter value of angle
                        Console.Write("Value of the angle. (please, don't enter the unit of measurement yet)\t\t        ");

                        //Trying to convert value of the user to double; saving value in the variable angle
                        if (!double.TryParse(Console.ReadLine(), out angle))
                        {
                            Console.WriteLine("You entered an invalid value.\nYou can represent the angle only as one skalar" +
                                              "\nUse \",\" instead of decimal points.");
                            goto case "tan()";
                        }

                        Console.WriteLine("------------------------------------------------------------------------------------------");

                        //differing degrees and radians
                        Console.Write("Is the angle given in degrees (write \"degrees\") or radians (write \"radians\")?\t   ");

                        //chosing object, because we will need this variable as ConsoleKeyInfo in the default-case
                        string unitOfMeasurement = Console.ReadLine();

                        switch (unitOfMeasurement)
                        {
                            //calculations with degrees
                            //saving result in variable result
                            //Showing full equation and result
                            case "degrees":

                                switch (operation)
                                {

                                    case "sin()":
                                        result = Math.Sin(Math.PI * angle / 180.0);
                                        Console.WriteLine($"sin({angle}°) = {result}");
                                        break;

                                    case "cos()":
                                        result = Math.Cos(Math.PI * angle / 180.0);
                                        Console.WriteLine($"cos({angle}°) = {result}");
                                        break;

                                    case "tan()":
                                        result = Math.Tan(Math.PI * angle / 180.0);
                                        Console.WriteLine($"tan({angle}°) = {result}");
                                        break;
                                }
                                break;

                            //calculations with radians 
                            //saving result in variable result
                            //Showing full equation and result
                            case "radians":

                                switch (operation)
                                {
                                    case "sin()":
                                        result = Math.Sin(angle);
                                        Console.WriteLine($"sin({angle}) = {result}");
                                        break;

                                    case "cos()":
                                        result = Math.Cos(angle);
                                        Console.WriteLine($"cos({angle}) = {result}");
                                        break;

                                    case "tan()":
                                        result = Math.Tan(angle);
                                        Console.WriteLine($"tan({angle}) = {result}");
                                        break;
                                }
                                break;

                            default:
                                //making sure the user choses either degrees or radians
                                Console.WriteLine("Only degrees or radians possible");
                                Console.Write("If you ment \"degrees\" enter d. If you ment \"radians\" enter r. ");

                                ConsoleKeyInfo pressedKey = Console.ReadKey();

                                if (pressedKey.Key == ConsoleKey.D)
                                {
                                    Console.WriteLine();
                                    goto case "degrees";
                                }
                                else if (pressedKey.Key == ConsoleKey.R)
                                {
                                    Console.WriteLine();
                                    goto case "radians";
                                }
                                else
                                {
                                    Console.WriteLine("------------------------------------------------------------------------------------------");
                                    goto default;
                                }
                        }
                        break;

                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "%"://algebraic operations, two numbers are needed

                        //user enters value of first number
                        Console.Write("Enter the value of the first number:\t\t\t\t\t\t     ");

                        //Trying to convert value of the user to double; saving value in the variable firstNumber
                        if (!double.TryParse(Console.ReadLine(), out firstNumber))
                        {
                            Console.WriteLine("You entered an invalid value.\nYou can represent the number only as a skalar" +
                                              "\nUse \",\" instead of decimal points.");
                            goto case "%";
                        }

                        //user enters value of second number
                        Console.Write("Enter the value of the second number:\t\t\t\t\t\t     ");

                        //Trying to convert value of the user to double; saving value in the variable firstNumber
                        if (!double.TryParse(Console.ReadLine(), out secondNumber))
                        {
                            Console.WriteLine("You entered an invalid value.\nYou can represent the number only as a skalar" +
                                              "\nUse \",\" instead of decimal points.");
                            goto case "%";
                        }

                        //execute different calculations for different operations
                        //saving result in variable result
                        //Showing full equation and result
                        switch (operation)
                        {
                            case "+":
                                result = firstNumber + secondNumber;
                                Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                                break;

                            case "-":
                                result = firstNumber - secondNumber;
                                Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                                break;

                            case "*":
                                result = firstNumber * secondNumber;
                                Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                                break;

                            case "/":
                                result = firstNumber / secondNumber;
                                Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                                break;

                            case "%":
                                result = firstNumber % secondNumber;
                                Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("You have entered an invalid operation. " +
                                          "\nLook, if you haven't forgotten the brackets in sin(), cos() or tan().");
                        continue;
                }

                //say goodbye to the user / asking him to continue 
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Thank you for using C# Console Calculator. \nIf you want to exit press Escape." +
                                  "\nIf you want to do further calculations press Enter or any other key.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else
                {
                    continue;
                }

                Console.WriteLine("------------------------------------------------------------------------------------------");
            }
    }
}
