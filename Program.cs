﻿using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int number; // assingr the number counternr
            //    Console.WriteLine("pleas enter a number ");// asking the user to write a number 
            //    number = int.Parse(Console.ReadLine());//save the number in the counter
            //    if (number % 2 == 0) // test the number if it is an odd or even
            //    {
            //        Console.WriteLine(number + " is an even number ");

            //    }
            //    else {

            //        Console.WriteLine(number + " is an odd number ");
            //    }

            //]-------------------------------------------------------------------------------------------------------------------------------------------[
            //int number1, number2, number3;
            //Console.WriteLine("pleas enter a number ");// asking the user to write a number 
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("pleas enter a number ");// asking the user to write a number 
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("pleas enter a number ");// asking the user to write a number 
            //number3 = int.Parse(Console.ReadLine());
            //if (number1 > number2 & number1 > number3) // finding the higest number 
            //{
            //    Console.WriteLine(number1 + " is  the lagest  number ");

            //}
            //else if (number2 > number3)
            //{
            //    Console.WriteLine(number2 + " is  the lagest  number ");

            //}
            //else {

            //    Console.WriteLine(number3 + " is  the lagest  number ");
            //}

            //]----------------------------------------------------------------------------------------------------------------------------------------------------------[

            //int celsius; // assingr the celsius counternr
            //Console.WriteLine("pleas enter the temperature  ");// asking the user to write a celsius 
            //celsius = int.Parse(Console.ReadLine());//save the celsius in the counter
            //int fahrenheit = (celsius * 9 / 5) + 35;
            //Console.WriteLine(fahrenheit + " is  the  temperature in Fahrenheit  ");

            //]----------------------------------------------------------------------------------------------------------------------------------------------------------[
            //double price; // assingr the celsius counternr
            //double discount;
            //Console.WriteLine("pleas enter the price  ");// asking the user to write a celsius 
            //price = int.Parse(Console.ReadLine());//save the celsius in the counter
            //if (price >100) {  discount = (price * 0.1);
            //price=price-discount
            //    Console.WriteLine(discount + " is  the  new price  "); }
            //else {

            //    Console.WriteLine(price + " is the price  ");

            //}
            //]----------------------------------------------------------------------------------------------------------------------------------------------------------[

            //int grade ; // assingr the number counternr
            //   Console.WriteLine("pleas enter a number ");// asking the user to write a number 
            //    grade  = int.Parse(Console.ReadLine());//save the number in the counter
            //if (grade > 100)
            //{
            //    Console.WriteLine("out of range  ");
            //}
            //else if (grade >= 90)
            //{


            //    Console.WriteLine(grade + "is yor grade A ");

            //}
            //else if (grade >= 80)
            //{


            //    Console.WriteLine(grade + "is yor grade B  ");

            //}
            //else if (grade >= 70)
            //{


            //    Console.WriteLine(grade + "is yor grade C ");

            //}
            //else if (grade >= 60)
            //{


            //    Console.WriteLine(grade + "is yor grade D ");

            //}
            //else {

            //    Console.WriteLine(grade + "you faill ");

            //}

            //int number1, number2;
            //int temp;
            //Console.WriteLine("pleas enter a number ");// asking the user to write a number 
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("pleas enter a number ");// asking the user to write a number 
            //number2 = int.Parse(Console.ReadLine());
            //temp=number1;
            //number1 = number2;
            //number2 = temp;
            //Console.WriteLine("the swap is " + number1 + "and" + number2);
            //]------------------------------------------------------------------------------------------------------------------[



            //double dayes;
            //double remaing;
            //Console.WriteLine("pleas enter numbers of dayes ");
            //dayes = double.Parse(Console.ReadLine());
            //double weeks = dayes / 7;
            //remaing = dayes % 7;
            //Console.WriteLine("the weeks is =" + weeks + "the remaing is" + remaing);
            //]-----------------------------------------------------------------------------------------------------------------[


            //double unites ;
            //double bill;
            //Console.WriteLine("pleas enter numbers of units");
            //unites = double.Parse(Console.ReadLine());
            //if (unites <= 100)
            //{
            //    bill = unites * 0.5;
            //    Console.WriteLine("your bill = $" + bill);

            //}
            //else if (unites <= 300)
            //{
            //    bill = unites * 0.75;
            //    Console.WriteLine("your bill = $" + bill);




            //}
            //else {
            //    bill = unites * 1;
            //    Console.WriteLine("your bill = $" + bill);

            //}

            //]--------------------------------------------------------------------------------------------------------------------------------------------

            //double number1 ;
            //double number2;
            //string opreater; 
            //Console.WriteLine("pleas enter number1");
            //number1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("pleas enter number2");
            //number2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("pleas enter opreater");
            //opreater =Console.ReadLine();

            //if (opreater == "+")
            //{

            //    Console.WriteLine(number1+number2);

            //}
            //else if (opreater == "-")
            //{
            //    Console.WriteLine(number1 - number2);




            //    }
            //else if (opreater == "*")
            //{
            //    Console.WriteLine(number1 * number2);




            //}
            //else if (opreater == "/")
            //{
            //    Console.WriteLine(number1 / number2);




            //}

            //else  {


            //    Console.WriteLine(" out of scope" );

            //}

            ////]--------------------------------------------------------------------------------------------------------------------------------------------
            //// paret2 

            //Console.Clear();
            //Console.WriteLine("pleas enter the frist number "); // asking the user to write a number
            //double Number1 = double.Parse(Console.ReadLine());    // save the number in the counter
            //Console.WriteLine("pleas enter the seconde number ");// asking the user to write a number
            //double Number2 = double.Parse(Console.ReadLine());// save the number in the counter
            //Console.WriteLine("pleas enter the operations ( *, / , + , - ) ");// asking the user to write a opreater
            //char opreation = char.Parse(Console.ReadLine()); // save the opreation in the counter

            //double result = 0; // assingr the result counter
            //switch (opreation)
            //{ // test the opreation


            //    case '+':
            //        result = Number1 + Number2;
            //        break;

            //    case '-':
            //        result = Number1 - Number2;
            //        break;

            //    case '*':
            //        result = Number1 * Number2;
            //        break;

            //    case '/' :

            //        if (Number2 == 0)
            //        {
            //            Console.WriteLine("Division by zero not allowed");


            //        }
            //        else
            //        {
            //            result = Number1 / Number2;
            //        }
            //        break;
            //    default:

            //        Console.WriteLine("Invalid operation");
            //        break;
            //}


            //Console.WriteLine("The result is " + result);// print the result



            //]--------------------------------------------------------------------------------------------------------------------------------------------

            //int flage = 0;
            //double balance = 1000;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("pleass  choice a  options:\n1 for Withdraw Money \n2 for Deposit Money\n" +
            //    "3 for cheak balance \n4 to exsit  ");
            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {

            //        case 1:
            //            Console.WriteLine("pleas enter the amount you want to withdraw ");
            //            double withdraw = double.Parse(Console.ReadLine());
            //            if (withdraw > balance)
            //            {
            //                Console.WriteLine("no balance");
            //            }
            //            else
            //            {
            //                balance = balance - withdraw;
            //                Console.WriteLine("your balanc " + balance);
            //            }
            //            break;
            //        case 2:
            //            Console.WriteLine("pleas enter the amount you want to deposit ");
            //            double deposit = double.Parse(Console.ReadLine());
            //            balance = balance + deposit;
            //            Console.WriteLine("The balance after deposit is " + balance);
            //            break;
            //        case 3:
            //            Console.WriteLine("The balance is " + balance);
            //            break;
            //        case 4:
            //            flage = 4;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid choice");
            //            break;

            //    }

            //    Console.WriteLine("\nPress any key to continue");
            //    Console.ReadKey();

            //} while (flage != 4);

            //]--------------------------------------------------------------------------------------------------------------------------------------------
            //Console.Clear();
            //Console.WriteLine("pleass  choice a  options:\n1 for Withdraw Money \n2 for Deposit Money\n" +
            //    "3 for cheak balance");
            //int choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{

            //    case 1: // if the user enter number 1
            //        double pi = 3.14; // assingr the pi counter
            //        Console.WriteLine("pless enter the  radius "); // asking the user to write a number
            //        double radius = double.Parse(Console.ReadLine()); // save the number in the counter
            //        double area = pi * radius * radius;
            //        double circumference = 2 * pi * radius;
            //        Console.WriteLine("The area of the circle is " + area);// print the result
            //        Console.WriteLine("The circumference of the circle is " + circumference); // print the result
            //        break;
            //    case 2: // if the user enter number 2
            //        Console.WriteLine("pleas enter the length ");
            //        double length = double.Parse(Console.ReadLine());
            //        Console.WriteLine("pleas enter the width ");
            //        double width = double.Parse(Console.ReadLine());
            //        double area1 = length * width;
            //        double perimeter = 2 * (length + width);
            //        Console.WriteLine("The area of the rectangle is " + area1);
            //        Console.WriteLine("The perimeter of the rectangle is " + perimeter);
            //        break;
            //    case 3:// if the user enter number 3
            //        Console.WriteLine("pleas enter the base ");
            //        double bases = double.Parse(Console.ReadLine());
            //        Console.WriteLine("pleas enter the height ");
            //        double height = double.Parse(Console.ReadLine());
            //        double area2 = 0.5 * bases * height;
            //        Console.WriteLine("The area of the triangle is " + area2);
            //        break;
            //    default:// if the user enter a wrong choice
            //        Console.WriteLine("Invalid choice");
            //        break;

            //}

            //]--------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("pleas enter the  factorial number  ");
            //int number = int.Parse(Console.ReadLine());
            //int fact = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    fact= fact * i;
            //}
            //Console.WriteLine("The factorial of " + number +"\nis   "+fact);
            //]--------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("pless enter a number ");// asking the user to write a number
            //int number = int.Parse(Console.ReadLine());// save the number in the counter
            //int sumOfEven = 0; // assingr the sum of even counter
            //int sumOfOdd = 0;// assingr the sum of odd counter
            //for (int i = 0; i <=number; i++) // loop to test the number
            //{
            //    if (i % 2 == 0) // test the number if it is an odd or even
            //    {
            //        sumOfEven = sumOfEven + i;
            //    }
            //    else
            //    {
            //        sumOfOdd = sumOfOdd + i;
            //    }

            //}
            //Console.WriteLine("The sum of even numbers is " + sumOfEven);// print the result
            //Console.WriteLine("The sum of odd numbers is " + sumOfOdd); // print the result


            //]--------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("pless choice a options:\n1 for  sin  \n2 for composite  cos \n" +
            //    "3 for tan\n 4 for sqrt \n 5 for log \n  6 for pow ");
            //int choice = int.Parse(Console.ReadLine());
            //double result = 0;
            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("pleas enter the number ");
            //        double number = double.Parse(Console.ReadLine());
            //        result = Math.Sin(number);
            //        Console.WriteLine("The sin of " + number + " is " + result);
            //        break;
            //    case 2:
            //        Console.WriteLine("pleas enter the number ");
            //        double number1 = double.Parse(Console.ReadLine());
            //        result = Math.Cos(number1);
            //        Console.WriteLine("The cos of " + number1 + " is " + result);
            //        break;
            //    case 3:
            //        Console.WriteLine("pleas enter the number ");
            //        double number2 = double.Parse(Console.ReadLine());
            //        result = Math.Tan(number2);
            //        Console.WriteLine("The tan of " + number2 + " is " + result);
            //        break;
            //    case 4:
            //        Console.WriteLine("pleas enter the number ");
            //        double number3 = double.Parse(Console.ReadLine());
            //        result = Math.Sqrt(number3);
            //        Console.WriteLine("The sqrt of " + number3 + " is " + result);
            //        break;
            //    case 5:
            //        Console.WriteLine("pleas enter the number ");
            //        double number4 = double.Parse(Console.ReadLine());
            //        result = Math.Log(number4);
            //        Console.WriteLine("The log of " + number4 + " is " + result);
            //        break;
            //    case 6:
            //        Console.WriteLine("pleas enter the number ");
            //        double number5 = double.Parse(Console.ReadLine());
            //        Console.WriteLine("pleas enter the power ");
            //        double power = double.Parse(Console.ReadLine());
            //        result = Math.Pow(number5, power);
            //        Console.WriteLine("The pow of " + number5 + " is " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice");
            //        break;


            //]--------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("pleas enter the number of starts and print the angeld  ");
            //int starse = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= starse; i++)
            //{

            //        Console.WriteLine(new string('*',i));


            //}

            //]--------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("pleas enter the numper of stars  ");
            //int stars = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= stars; i++)
            //{
            //   Console.WriteLine(new string(' ', stars - i) + new string('*', i*2-1) );
            //}

            //]----------------------------------------------------------------------------------------------------------------------------------------------
            //Console.Write("Please enter the number of stars: ");
            //int stars = int.Parse(Console.ReadLine());

            //int count = stars * 2 - 1; 

            //for (int i = 1; i <= count; i++)
            //{
            //    if (i <= stars)
            //    {
            //        Console.WriteLine(new string(' ', stars - i) + new string('*', i * 2 - 1));
            //    }
            //    else
            //    {
            //        int j = count - i + 1;
            //        Console.WriteLine(new string(' ', stars - j) + new string('*', j * 2 - 1));
            //    }

            //}

            //]------------------------------------------------------------------------
            //Console.Write("Please enter the number of stars: ");
            //int stars = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= stars; i++)
            //{
            //    for (int j = 1; j <= stars - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = stars - 1; i >= 1; i--)
            //{
            //    for (int j = 1; j <= stars - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //]-----------------------------------------------------------------------------

            //]--------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("pleas guss a number btween 1 and 100  ");
            //int number = new Random().Next(1, 100);
            //int guss = 0;
            //int count = 0;
            //while (guss != number)
            //{
            //    guss = int.Parse(Console.ReadLine());
            //    count++;
            //    if (guss > number)
            //    {
            //        Console.WriteLine("The number is too high");
            //    }
            //    else if (guss < number)
            //    {
            //        Console.WriteLine("The number is too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You gussed the number in " + count + " attempts");
            //    }
            //}






            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Simple Calculator");
                Console.WriteLine("2. Basic ATM System");
                Console.WriteLine("3. Geometry Calculator");
                Console.WriteLine("4. Factorial of a Number");
                Console.WriteLine("5. Sum of Even and Odd Numbers");
                Console.WriteLine("6. Scientific Calculator");
                Console.WriteLine("7. Print Triangle Pattern");
                Console.WriteLine("8. Print Pyramid Pattern");
                Console.WriteLine("9. Print Diamond Pattern");
                Console.WriteLine("10. Guess the Number Game");
                Console.WriteLine("11. Arrays");
                Console.WriteLine("12. Max and Min Numbers");
                Console.WriteLine("13. Even and Odd Numbers");
                Console.WriteLine("14. Reverse Array");
                Console.WriteLine("15. Search Number");
                Console.WriteLine("16. Sort Array");
                Console.WriteLine("17. Merge Arrays");
                Console.WriteLine("18. Remove Duplicates");
                Console.WriteLine("19. Second Largest Number");
                Console.WriteLine("20. Remove Duplicates 2");
                Console.WriteLine("21. Most Frequent Number");
                Console.WriteLine("22. Palindrome Array");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: SimpleCalculator(); break;
                    case 2: BasicATM(); break;
                    case 3: GeometryCalculator(); break;
                    case 4: Factorial(); break;
                    case 5: SumEvenOdd(); break;
                    case 6: ScientificCalculator(); break;
                    case 7: PrintTriangle(); break;
                    case 8: PrintPyramid(); break;
                    case 9: PrintDiamond(); break;
                    case 10: GuessGame(); break;
                    case 11: arrayes(); break;
                    case 12: maxMinNumbers(); break;
                    case 13: evenAndOdd(); break;
                    case 14: reversArray(); break;
                    case 15: searchNumber(); break;
                    case 16: sortArray(); break;
                    case 17: meargArry(); break;
                    case 18:removeDuplicates(); break;
                    case 19:secondLargest(); break;
                    case 20:RemoveDuplicates2(); break;
                    case 21: mostFrequnceNumber(); break;
                    case 22: palindromeArray(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();

            }
            }
        static void SimpleCalculator() {

            Console.Clear();
            Console.WriteLine("pleas enter the frist number "); // asking the user to write a number
            double Number1 = double.Parse(Console.ReadLine());    // save the number in the counter
            Console.WriteLine("pleas enter the seconde number ");// asking the user to write a number
            double Number2 = double.Parse(Console.ReadLine());// save the number in the counter
            Console.WriteLine("pleas enter the operations ( *, / , + , - ) ");// asking the user to write a opreater
            char opreation = char.Parse(Console.ReadLine()); // save the opreation in the counter

            double result = 0; // assingr the result counter
            switch (opreation)
            { // test the opreation


                case '+':
                    result = Number1 + Number2;
                    break;

                case '-':
                    result = Number1 - Number2;
                    break;

                case '*':
                    result = Number1 * Number2;
                    break;

                case '/':

                    if (Number2 == 0)
                    {
                        Console.WriteLine("Division by zero not allowed");


                    }
                    else
                    {
                        result = Number1 / Number2;
                    }
                    break;
                default:

                    Console.WriteLine("Invalid operation");
                    break;
            }


            Console.WriteLine("The result is " + result);// print the result





        }
        static void BasicATM() {

            int flage = 0;
            double balance = 1000;
            do
            {
                Console.Clear();
                Console.WriteLine("pleass  choice a  options:\n1 for Withdraw Money \n2 for Deposit Money\n" +
                "3 for cheak balance \n4 to exsit  ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("pleas enter the amount you want to withdraw ");
                        double withdraw = double.Parse(Console.ReadLine());
                        if (withdraw > balance)
                        {
                            Console.WriteLine("no balance");
                        }
                        else
                        {
                            balance = balance - withdraw;
                            Console.WriteLine("your balanc " + balance);
                        }
                        break;
                    case 2:
                        Console.WriteLine("pleas enter the amount you want to deposit ");
                        double deposit = double.Parse(Console.ReadLine());
                        balance = balance + deposit;
                        Console.WriteLine("The balance after deposit is " + balance);
                        break;
                    case 3:
                        Console.WriteLine("The balance is " + balance);
                        break;
                    case 4:
                        flage = 4;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }

                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();

            } while (flage != 4);




        }
        static void GeometryCalculator() {


            Console.Clear();
            Console.WriteLine("pleass  choice a  options:\n1 for Withdraw Money \n2 for Deposit Money\n" +
                "3 for cheak balance");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1: // if the user enter number 1
                    double pi = 3.14; // assingr the pi counter
                    Console.WriteLine("pless enter the  radius "); // asking the user to write a number
                    double radius = double.Parse(Console.ReadLine()); // save the number in the counter
                    double area = pi * radius * radius;
                    double circumference = 2 * pi * radius;
                    Console.WriteLine("The area of the circle is " + area);// print the result
                    Console.WriteLine("The circumference of the circle is " + circumference); // print the result
                    break;
                case 2: // if the user enter number 2
                    Console.WriteLine("pleas enter the length ");
                    double length = double.Parse(Console.ReadLine());
                    Console.WriteLine("pleas enter the width ");
                    double width = double.Parse(Console.ReadLine());
                    double area1 = length * width;
                    double perimeter = 2 * (length + width);
                    Console.WriteLine("The area of the rectangle is " + area1);
                    Console.WriteLine("The perimeter of the rectangle is " + perimeter);
                    break;
                case 3:// if the user enter number 3
                    Console.WriteLine("pleas enter the base ");
                    double bases = double.Parse(Console.ReadLine());
                    Console.WriteLine("pleas enter the height ");
                    double height = double.Parse(Console.ReadLine());
                    double area2 = 0.5 * bases * height;
                    Console.WriteLine("The area of the triangle is " + area2);
                    break;
                default:// if the user enter a wrong choice
                    Console.WriteLine("Invalid choice");
                    break;

            }


        }
        static void Factorial() {

            Console.WriteLine("pleas enter the number of starts and print the angeld  ");
            int starse = int.Parse(Console.ReadLine());
            for (int i = 1; i <= starse; i++)
            {

                Console.WriteLine(new string('*', i));


            }

        }
        static void SumEvenOdd() {



             Console.WriteLine("pless enter a number ");// asking the user to write a number
            int number = int.Parse(Console.ReadLine());// save the number in the counter
            int sumOfEven = 0; // assingr the sum of even counter
            int sumOfOdd = 0;// assingr the sum of odd counter
            for (int i = 0; i <= number; i++) // loop to test the number
            {
                if (i % 2 == 0) // test the number if it is an odd or even
                {
                    sumOfEven = sumOfEven + i;
                }
                else
                {
                    sumOfOdd = sumOfOdd + i;
                }

            }
            Console.WriteLine("The sum of even numbers is " + sumOfEven);// print the result
            Console.WriteLine("The sum of odd numbers is " + sumOfOdd); // print the result

        }

        static void ScientificCalculator() {

            Console.WriteLine("pless choice a options:\n1 for  sin  \n2 for composite  cos \n" +
                "3 for tan\n 4 for sqrt \n 5 for log \n  6 for pow ");
            int choice = int.Parse(Console.ReadLine());
            double result = 0;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("pleas enter the number ");
                    double number = double.Parse(Console.ReadLine());
                    result = Math.Sin(number);
                    Console.WriteLine("The sin of " + number + " is " + result);
                    break;
                case 2:
                    Console.WriteLine("pleas enter the number ");
                    double number1 = double.Parse(Console.ReadLine());
                    result = Math.Cos(number1);
                    Console.WriteLine("The cos of " + number1 + " is " + result);
                    break;
                case 3:
                    Console.WriteLine("pleas enter the number ");
                    double number2 = double.Parse(Console.ReadLine());
                    result = Math.Tan(number2);
                    Console.WriteLine("The tan of " + number2 + " is " + result);
                    break;
                case 4:
                    Console.WriteLine("pleas enter the number ");
                    double number3 = double.Parse(Console.ReadLine());
                    result = Math.Sqrt(number3);
                    Console.WriteLine("The sqrt of " + number3 + " is " + result);
                    break;
                case 5:
                    Console.WriteLine("pleas enter the number ");
                    double number4 = double.Parse(Console.ReadLine());
                    result = Math.Log(number4);
                    Console.WriteLine("The log of " + number4 + " is " + result);
                    break;
                case 6:
                    Console.WriteLine("pleas enter the number ");
                    double number5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("pleas enter the power ");
                    double power = double.Parse(Console.ReadLine());
                    result = Math.Pow(number5, power);
                    Console.WriteLine("The pow of " + number5 + " is " + result);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }   }

        static void PrintTriangle() {

            Console.WriteLine("pleas enter the number of starts and print the angeld  ");
            int starse = int.Parse(Console.ReadLine());
            for (int i = 1; i <= starse; i++)
            {

                Console.WriteLine(new string('*', i));


            }


        }



        static void PrintPyramid() {

            Console.WriteLine("pleas enter the numper of stars  ");
            int stars = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stars; i++)
            {
                Console.WriteLine(new string(' ', stars - i) + new string('*', i * 2 - 1));
            }


        }

        static void PrintDiamond() {

            Console.Write("Please enter the number of stars: ");
            int stars = int.Parse(Console.ReadLine());

            int count = stars * 2 - 1;

            for (int i = 1; i <= count; i++)
            {
                if (i <= stars)
                {
                    Console.WriteLine(new string(' ', stars - i) + new string('*', i * 2 - 1));
                }
                else
                {
                    int j = count - i + 1;
                    Console.WriteLine(new string(' ', stars - j) + new string('*', j * 2 - 1));
                }

            }



        }


        static void GuessGame() {

            Console.WriteLine("pleas guss a number btween 1 and 100  ");
            int number = new Random().Next(1, 100);
            int guss = 0;
            int count = 0;
            while (guss != number)
            {
                guss = int.Parse(Console.ReadLine());
                count++;
                if (guss > number)
                {
                    Console.WriteLine("The number is too high");
                }
                else if (guss < number)
                {
                    Console.WriteLine("The number is too low");
                }
                else
                {
                    Console.WriteLine("You gussed the number in " + count + " attempts");
                }
            }


        }

        static void arrayes() { 
               double[] numbers = new double[5];
            Console.WriteLine("pleas enter the numbers ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");
                numbers[i]= double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }




        }
        static void maxMinNumbers() {
            double[] numbers = new double[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine("The max number is " + numbers[numbers.Length - 1]);
            Console.WriteLine("The min number is " + numbers[0]);

        }

       static void evenAndOdd()
        {
          Console.WriteLine("pleas enter the length of the arry ");
            int length = int.Parse(Console.ReadLine());
            double[] numbers = new double[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            int oddcounts = 0;
            int evencounts = 0;
            double[] odd = new double[length];
            double[] even = new double[length];     

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even[evencounts] = numbers[i];
                    evencounts++;

                }
                else
                {
                    odd[oddcounts] = numbers[i];
                    oddcounts++;
                    
                   
                }
            }
            Console.WriteLine("The odd numbers are "+oddcounts+" \n  the arry is :"+string.Join(",",odd));

           Console.WriteLine("The even numbers are " + evencounts + " \nthe arry is :" + string.Join(",", even));



        }

        static void reversArray()
        {
            Console.WriteLine("pleas enter the length of the arry ");
            int length = int.Parse(Console.ReadLine());
            double[] numbers = new double[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Array.Reverse(numbers);
            Console.WriteLine("the revers is : " + string.Join(",",numbers));
        }
        static void searchNumber()
        {

           int[] numbers = {1,2,3,4,5,6,7,8,9};

            Console.WriteLine("pleas add the number youare searching for ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    Console.WriteLine("The number is found at index " + i);

                    break;
                }
            }





            //// 6. Search for a Number in an Array
            //static void SearchNumber()
            //{
            //    Console.Write("Enter the number of elements: ");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] arr = new int[n];

            //    Console.WriteLine("Enter elements:");
            //    for (int i = 0; i < n; i++)
            //        arr[i] = int.Parse(Console.ReadLine());

            //    Console.Write("Enter number to search: ");
            //    int search = int.Parse(Console.ReadLine());

            //    //int index = Array.IndexOf(arr, search);

            //    int index = -1;
            //    int[] indexes = new int[arr.Length];

            //    for (int i = 0; i < arr.Length; i++)
            //    {

            //        if (arr[i] == search)
            //        {
            //            // Console.WriteLine(i);
            //            index = i;
            //            break;
            //        }
            //        //if (arr[i]==search)
            //        //{
            //        //    indexes[i] = i;
            //        //}




            //    }

            //    if (index != -1)
            //        Console.WriteLine(index);
            //    else
            //        Console.WriteLine("not found");



            //    Console.WriteLine(index == -1 ? "Number not found." : $"Number found at index {index}");
            //}


        }
        static void sortArray()
        {
            Console.WriteLine("pleas enter the length of the arry ");
            int length = int.Parse(Console.ReadLine());
            double[] numbers = new double[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");   
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine("The sorted array is " + string.Join(",", numbers));




        }

        static void meargArry() {

            Console.WriteLine("pleas enter the length of the arry ");
            int length = int.Parse(Console.ReadLine());
            double[] numbers = new double[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("pleas enter the length of the second arry ");
            double[] numbers2 = new double[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");
                numbers2[i] = double.Parse(Console.ReadLine());
            }

            int length3 = length + length;
            double[] mearg = new double[length3];
            for (int i = 0; i < length; i++)
            {
                mearg[i] = numbers[i];
                mearg[i + length] = numbers2[i];
            }

            Console.WriteLine("The mearged array is " + string.Join(",", mearg));

        }
        static void removeDuplicates() {

            Console.WriteLine("pleas enter the length of the arry ");
            int length = int.Parse(Console.ReadLine());
            double[] numbers = new double[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            double[] unique = numbers.Distinct().ToArray();
            Console.WriteLine("The unique array is " + string.Join(",", unique));


        }

        static void secondLargest()
        {
            Console.WriteLine("pleas enter the length of the arry ");
            int length = int.Parse(Console.ReadLine());
            double[] numbers = new double[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine("The second largest number is " + numbers[numbers.Length - 2]);
        }



        static void RemoveDuplicates2()
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Array without duplicates:");
            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate) Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void mostFrequnceNumber() {
            Console.WriteLine("pleas enter the length of the arry ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int [] frequentNumber =new int[length];
            for (int i = 0; i < frequentNumber.Length; i++) {
                for (int j = 0; j < frequentNumber.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        frequentNumber[i] = numbers[i];


                    }
                }   

            }
            Array.Sort(frequentNumber);
            Console.WriteLine("The most smallest  frequent number is " + frequentNumber[0]);







        }


        static void palindromeArray()
        {
            Console.WriteLine("pleas enter the length of the arry ");
            int length = int.Parse(Console.ReadLine());
            double[] numbers = new double[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("pleas enter the number ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            double[] reverse = new double[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                reverse[i] = numbers[length - i - 1]; 
            }
            bool isPalindrome = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != reverse[i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("The array is a palindrome");
            }
            else
            {
                Console.WriteLine("The array is not a palindrome");
            }
        }

    }
}
