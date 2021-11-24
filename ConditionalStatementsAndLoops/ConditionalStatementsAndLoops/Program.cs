using System;
using System.Linq;

namespace ConditionalStatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. Write a program that reads from the console three numbers of type int and prints their sum.
            //int number1 = ReadFromConsole();
            //int number2 = ReadFromConsole();
            //int number3 = ReadFromConsole();
            //Console.WriteLine($"The sum of the numbers is {Sum(number1, number2, number3)}");

            // 2. Write a program that reads five numbers from the console and prints the greatest of them.
            //int number1 = ReadFromConsole();
            //int number2 = ReadFromConsole();
            //int number3 = ReadFromConsole();
            //int number4 = ReadFromConsole();
            //int number5 = ReadFromConsole();
            //Console.WriteLine($"The greatest number of [{number1}, {number2}, {number3}, {number4}, {number5}] is: {GreatestNumber(number1, number2, number3, number4, number5)}");

            //// 3. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            //int radius = ReadFromConsole();
            //CirclePerimeter(radius);
            //CircleArea(radius);

            //// 4. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5.
            //int number1 = ReadFromConsole();
            //int number2 = ReadFromConsole();
            //NumbersDivisibleWith5(number1, number2);

            //// 5. Write a program that reads two numbers from the console and prints the greater of them.
            //// Solve the problem without using conditional statements and with conditional statements.
            //int number1 = ReadFromConsole();
            //int number2 = ReadFromConsole();
            //Console.WriteLine($"The greatest number of [{number1}, {number2}] is: {GreatestNumber(number1, number2)}");
            //Console.WriteLine($"The greatest number of [{number1}, {number2}] is: {LargestNum(number1, number2)}");

            // 6. Write a program that reads five integer numbers and prints their sum.
            // If an invalid number is entered the program should prompt the user to enter another number(only once).
            //int number1 = ReadCorrectIntFromConsole();
            //int number2 = ReadCorrectIntFromConsole();
            //int number3 = ReadCorrectIntFromConsole();
            //int number4 = ReadCorrectIntFromConsole();
            //int number5 = ReadCorrectIntFromConsole();
            //Console.WriteLine($"The sum of numbers [{number1}, {number2}, {number3}, {number4} and {number5}] is {Sum(number1, number2, number3, number4, number5)}");

            // 7. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
            //int number = ReadFromConsole();
            //Console.WriteLine("The numbers from 1 to {0} are:" , number);
            //PrintNNumbers(number);

            // 8. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
            // The number N should be read from the standard input.
            //int number = ReadFromConsole();
            //Console.WriteLine("The numbers from 1 to {0} which are not divisible by 3 and 7 simultaneously are:", number);
            //IndivisleBy3and7(number);

            // 9. Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.
            //int number1 = ReadFromConsole();
            //int number2 = ReadFromConsole();
            //int number3 = ReadFromConsole();
            //int number4 = ReadFromConsole();
            //int number5 = ReadFromConsole();
            //Console.WriteLine($"The smalest nr is {SmalestNumber(number1, number2, number3, number4, number5)} and the greatest nr is {GreatestNumber(number1, number2, number3, number4, number5)}");

            // 10. Write program that outputs a triangle made of stars with variable size, depending on an input parameter.
            //int number1 = ReadFromConsole();
            //PrintTriangle(number1);

            // 11. Write a program that converts a given number from decimal to binary notation (numeral system).
            //int number = ReadFromConsole();
            //ConvertToBinary(number);

            // 12. Write a program that by a given integer N prints the numbers from 1 to N in random order
            //int number1 = ReadFromConsole();
            //PrintRandom(number1);

            // 13. A program which iterates the integers from 1 to 50 For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz".
            // For numbers which are multiples of both three and five print "FizzBuzz".
            //FizzBuzzGame();

            // 14. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number.
            // Write a program that reads information about the company and its manager and then prints it on the console.
            //CheckCompany();
        }

        static int ReadFromConsole()
        {
            Console.WriteLine("Please insert a number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int ReadCorrectIntFromConsole()
        {
            Console.WriteLine("Please insert a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int number);

            if (success)
            {
                return number;
            }
            else
            {
                number = ReadFromConsole();
            }
            return number;
        }

        static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static int GreatestNumber(params int[] number)
        {
            int gratestNumber = number[0];
            foreach (int element in number)
            {
                if (element > gratestNumber)
                {
                    gratestNumber = element;
                }
            }
            return gratestNumber;
        }

        static void CirclePerimeter(int radius)
        {
            Console.WriteLine("The circle perimeter is: {0}", 2 * Math.PI * radius);
        }

        static void CircleArea(int radius)
        {
            Console.WriteLine("The circle area is: {0}", Math.PI * Math.Pow(radius, 2));
        }

        static void NumbersDivisibleWith5(int number1, int number2)
        {
            int index = 0;
            for (int i = number1 + 1; i < number2; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    index++;
                }
            }
            Console.WriteLine($"Between {number1} and {number2} we have {index} numbers divisible by 5");
        }

        static int LargestNum(int number1, int number2)
        {
            return (number1 * ((number1 - number2) >= 0 ? 1 : 0) + number2 * ((number2 - number1) > 0 ? 1 : 0));
        }

        static void PrintNNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void IndivisleBy3and7(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int SmalestNumber(params int[] number)
        {
            int smallestNr = number[0];
            foreach (int element in number)
            {
                if (element < smallestNr)
                {
                    smallestNr = element;
                }
            }
            return smallestNr;
        }

        static void PrintTriangle(int number)
        {
            string stars = "";
            for (int i = 0; i < number; i++)
            {
                stars += "*";
                Console.WriteLine(stars);
            }
            for (int i = number - 1; i >= 1; i--)
            {
                stars = stars.Remove(stars.Length-1);
                Console.WriteLine(stars);
            }
        }

        static void FizzBuzzGame()
        {
            for (int i = 0; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ConvertToBinary(int number)
        {
            Console.WriteLine(Convert.ToString(number, 2));
        }

        static void PrintRandom(int number)
        {
            var rnd = new Random();
            int[] randomNumbers = new int[number];
            for (int i = 0; i < number; i++)
            {
                int temp;
                do
                {
                    temp = rnd.Next(1, number + 1);
                } while (randomNumbers.Contains(temp));
                if (!randomNumbers.Contains(temp))
                {
                    randomNumbers[i] = temp;
                }
            }
            foreach (var nr in randomNumbers)
            {
                Console.WriteLine(nr);
            }
        }

        static void CheckCompany()
        {
            var scoalaInformala = new Company();

            scoalaInformala.CompanyName = "SC Scoala Informala SRl";
            scoalaInformala.CompanyAdress = "CLuj-Napoca";
            scoalaInformala.CompanyPhone = "0745xxxxxx";
            scoalaInformala.CompanyFax = "0264xxxxxx";
            scoalaInformala.CompanyWebSite = "www.scoalainformaladeit.com";
            scoalaInformala.manager.ManagerName = "Alina";
            scoalaInformala.manager.ManagerSurName = "Candale";
            scoalaInformala.manager.ManagerPhone = "0742365847";

            Console.WriteLine($"Compania {scoalaInformala.CompanyName} are adresa {scoalaInformala.CompanyAdress}, tel {scoalaInformala.CompanyPhone}, " +
                $"fax {scoalaInformala.CompanyFax} si pagina web {scoalaInformala.CompanyWebSite} si are manager pe " +
                $"{scoalaInformala.manager.ManagerSurName + " " + scoalaInformala.manager.ManagerName} care poate fi gasita la tel {scoalaInformala.manager.ManagerPhone}");
        }
    }
}


