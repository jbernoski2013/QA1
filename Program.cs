using System;

namespace JBQA1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            int length = 1;
            int width = 1;
            Rectangle rectangle = new Rectangle();


        Reset:
            Console.WriteLine("1.Get Recntangle Length");
            Console.WriteLine("2.Change Rectangle Length");
            Console.WriteLine("3.Get Rectangle Width");
            Console.WriteLine("4.Change Rectangle Width");
            Console.WriteLine("5.Get Rectangle Perimeter");
            Console.WriteLine("6.Get Rectangle Area");
            Console.WriteLine("7.Exit");
            Console.WriteLine("Input: ");
            userChoice = Console.ReadLine();
            try
            {
                int input = int.Parse(userChoice);
                if (input == 1)
                {
                    Console.WriteLine("The Length of the rectangle is: " + rectangle.getLength(length));
                    Console.ReadLine();

                }
                else if (input == 2)
                {
                Retry:
                    Console.WriteLine("What would you like to change the Length to?: ");
                    string userLength = Console.ReadLine();
                    int userLengthInt = int.Parse(userLength);
                    if (userLengthInt <= 0)
                    {
                        Console.WriteLine("Enter a integer that is greater than 1");
                        goto Retry;
                    }
                    Console.WriteLine("The new length of the rectangle is: " + rectangle.setLength(userLengthInt));
                    length = userLengthInt;
                    Console.ReadLine();

                }
                else if (input == 3)
                {
                    Console.WriteLine("The length of the rectangle is: " + rectangle.getWidth(width));

                    Console.ReadLine();
                }
                else if (input == 4)
                {
                    Console.WriteLine("What would you like to change the Length to?: ");
                    string userWidth = Console.ReadLine();
                    int userWidthInt = int.Parse(userWidth);
                    Console.WriteLine("The new width of the rectangle is: " + rectangle.setLength(userWidthInt));
                    length = userWidthInt;
                    Console.ReadLine();
                }
                else if (input == 5)
                {
                    Console.WriteLine("The perimeter of the rectangle is: " + rectangle.getPerimeter(length, width));
                    Console.ReadLine();
                }
                else if (input == 6)
                {
                    Console.WriteLine("The area of the rectangle is: " + rectangle.getArea(length, width));
                    Console.ReadLine();
                }
                else if (input == 7)
                {
                    Environment.Exit(0);
                }

                else if (input > 7)
                {
                    Console.WriteLine("Select a number between 1 and 7!");
                }
                else
                {
                    Console.WriteLine("Integers only!");
                }

                goto Reset;
            }
            catch
            {
                Console.WriteLine("Enter a valid number.");
                goto Reset;
            }

        }
    }
}
