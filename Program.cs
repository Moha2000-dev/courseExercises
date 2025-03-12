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


            //    Console.WriteLine(grade + "is yor grade  ");

            //}
            //else if (grade >= 80)
            //{


            //    Console.WriteLine(grade + "is yor grade  ");

            //}
            //else if (grade >= 70)
            //{


            //    Console.WriteLine(grade + "is yor grade  ");

            //}
            //else if (grade >= 60)
            //{


            //    Console.WriteLine(grade + "is yor grade  ");

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

            double number1 ;
            double number2;
            string opreater; 
            Console.WriteLine("pleas enter number1");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("pleas enter number2");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("pleas enter opreater");
            opreater =Console.ReadLine();

            if (opreater == "+")
            {
               
                Console.WriteLine(number1+number2);

            }
            else if (opreater == "-")
            {
                Console.WriteLine(number1 - number2);




                }
            else if (opreater == "*")
            {
                Console.WriteLine(number1 * number2);




            }
            else if (opreater == "/")
            {
                Console.WriteLine(number1 / number2);




            }

            else  {

         
                Console.WriteLine(" out of scope" );

            }

            //]--------------------------------------------------------------------------------------------------------------------------------------------










        }
    }
}
