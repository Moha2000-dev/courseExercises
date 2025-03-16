using System.Numerics;
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
            //Console.Clear();
            //Console.WriteLine("pleass  choice a  options:\n1 for Withdraw Money \n2 for Deposit Money\n" +
            //    "3 for cheak balance \n4 to exsit  ");
            //int choice = int.Parse(Console.ReadLine());
            //double balance = 1000;
            //switch (choice) { 

            // case 1:
            //        Console.WriteLine("pleas enter the amount you want to withdraw ");
            //        double withdraw = double.Parse(Console.ReadLine());
            //        if (withdraw > balance)
            //        {
            //            Console.WriteLine("no balance");
            //        }
            //        else
            //        {
            //            balance =balance- withdraw;
            //            Console.WriteLine("your balanc " + balance);
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("pleas enter the amount you want to deposit ");
            //        double deposit = double.Parse(Console.ReadLine());
            //        balance = balance+deposit;
            //        Console.WriteLine("The balance after deposit is " + balance);
            //        break;
            //    case 3:
            //        Console.WriteLine("The balance is " + balance);
            //        break;
            //    case 4:
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice");
            //        break;

            //}
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
            Console.WriteLine("pleas enter the number of P and print the angeld  ");
            int starse = int.Parse(Console.ReadLine());
            for (int i = 1; i <= starse; i++)
            {
               
                    Console.WriteLine(new string('*',i));
                

            }

            //

    }
    }
}
