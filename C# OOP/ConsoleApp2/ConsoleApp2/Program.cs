using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first Question

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            sumTwoNums(num1,num2);

            //int sum = 0;
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 == num2)
            //{
            //    sum = (num1 + num2) * 3;
            //}
            //else
            //{
            //    sum = num1 + num2;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Question 2

            //int n = int.Parse(Console.ReadLine());
            //int difference = 51-n;
            //if (n > 51)
            //{
            //    Console.WriteLine("Absolute difference is "+ -difference * 3);
            //}
            //else
            //{
            //    Console.WriteLine(difference);
            //}
            #endregion

            #region Q3
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //if(num1+num2==30 || num1==30 || num2==30)
            //{
            //    Console.WriteLine("True");
            //}
            //else { Console.WriteLine("False"); }
            #endregion

            #region Q4
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 || num % 7 == 0)
            //{
            //    Console.WriteLine("True");
            //}
            //else { Console.WriteLine("False"); }

            #endregion

            #region Q5
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //if(num1>=100 && num1 <= 200 && num2 >= 100 && num2<= 200)
            //{
            //    Console.WriteLine("True");
            //}
            //else {  Console.WriteLine("False"); }

            #endregion
            #region Q6
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //if(num1>=20 && num1<=50 || num2 >= 20 && num2 <= 50 || num3 >= 20 && num3 <= 50) {
            //    Console.WriteLine("True!");
            //}else { Console.WriteLine("False!"); }
            #endregion

            #region Q7
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //if(num1>num2 && num1 > num3)
            //{
            //    Console.WriteLine(num1);
            //}else if(num2 > num1 && num2 > num3) {
            //    Console.WriteLine(num2);
            //}
            //else { Console.WriteLine(num3); }

            #endregion

            #region Q8
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 == num2)
            //{
            //    Console.WriteLine("0");
            //}
            //int difference1 = 100 - num1;
            //int difference2 = 100 - num2;
            //if (difference1 < difference2)
            //{
            //    Console.WriteLine(num1);
            //}
            //else
            //{
            //    Console.WriteLine(difference2);
            //}
            #endregion

            #region Q9
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 >= 40 && num1 <=50 && num2 >=40 && num2 <=50
            //    || num1 >=50 && num1 <=60 && num2 >= 50 && num2 <= 60)
            //{
            //    Console.WriteLine("True");
            //}else { Console.WriteLine("False"); }


            #endregion

            #region Q10
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 >= 20 && num1 <= 30 && num2 >= 20 && num2 <= 30)
            //{
            //    if (num1 > num2)
            //    {
            //        Console.WriteLine(num1);
            //    }
            //    else { Console.WriteLine(num2); }

            //}else { Console.WriteLine("0"); }
            #endregion

            #region Q11
            //    Console.Write("Enter a string: ");
            //    string inputString = Console.ReadLine();

            //    Console.Write("Enter the number of copies (n): ");
            //    int n = int.Parse(Console.ReadLine());

            //    if (n >= 0)
            //    {
            //        string result = "";

            //        for (int i = 0; i < n; i++)
            //        {
            //            result += inputString;
            //        }

            //        Console.WriteLine($"Result: {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("enter a non-negative integer for the number of copies.");
            //    }
            //}
            #endregion

            #region Q12
            //            int num1 = int.Parse(Console.ReadLine());
            //            int num2 = int.Parse(Console.ReadLine());
            //            if (num1 == 5 || num2 ==5 || num1+num2==5 || num1-num2==5 || num2-num1==5){
            //                Console.WriteLine("True");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Fasle!");
            //            }
            #endregion

            #region Q13
            //Console.WriteLine("Enter positive number");
            //int num1 = int.Parse(Console.ReadLine());
            //if(num1%3 == 0 && num1%7==0 ) { Console.WriteLine("Fasle");
            //}else if(num1 % 3==9 || num1 % 7 == 0)
            //{
            //    Console.WriteLine("True!");
            //}

            #endregion

            #region Q14
            //int num1 = int.Parse(Console.ReadLine());
            //if(num1 %3 ==0 && num1%5==0) {
            //    Console.WriteLine("FizzBuzz");
            //}else if (num1 % 3 == 0)
            //{
            //    Console.WriteLine("Fizz");
            //}else if(num1 % 5 == 0) {
            //    Console.WriteLine("Buzz");
            //}
            #endregion

            #region Q15
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());

            //bool isPossible = (num1 + num2 == num3) || (num2 + num3 == num1) || (num3 + num1 == num2);

            //if (isPossible)
            //{
            //    Console.WriteLine($"{num1} + {num2} equals {num3}. It is possible to add two integers to get the third integer.");
            //}
            //else
            //{
            //    Console.WriteLine(" It is not possible to add two integers to get the third integer.");
            //}
            #endregion

            #region Q16
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //if(num1<num2 && num2 < num3)
            //{
            //    Console.WriteLine("True!");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            #endregion

            #region Q17
            //int tableNum = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 13; i++) {

            //    Console.WriteLine($"{tableNum} * {i} = {tableNum * i}");
            //}
            #endregion



            #region Q18

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());

            //if(num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine("the max is "+ num1);
            //    if(num2 > num3)
            //    {
            //        Console.WriteLine("min is " + num3);
            //    }
            //    else { Console.WriteLine("min is " + num2); };
            //}else if (num2 > num1 && num2 > num3) {
            //    Console.WriteLine("the max is " + num2);
            //    if (num1 > num3) { Console.WriteLine("min is " + num3); }
            //    else { Console.WriteLine("min is "+num1); }
            //}else if(num3 > num1 && num3 > num2)
            //{
            //    Console.WriteLine("max is " + num3);
            //    if (num2 > num1)
            //    {
            //        Console.WriteLine("min is " + num1);
            //    }
            //    else { Console.WriteLine("min is " + num2); }
            //}
            #endregion

            #region 19

            //int sum = 0;
            //while ( sum <= 400)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    sum += number;
            //    Console.WriteLine(sum);
            //}
            #endregion

            #region 20

            //Console.WriteLine("Enter two numbers");
            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter operator");
            //String choice = Console.ReadLine();
            //switch (choice)
            //{
            //    case "+":
            //        Console.WriteLine(number1+number2);
            //        break;
            //    case "-":
            //        Console.WriteLine(number1=number2);
            //        break;
            //    case "/":
            //        Console.WriteLine(number1/number2);

            //        break;
            //    case "*":
            //        Console.WriteLine(number1*number2);
            //        break;
            //    case "E || e":
            //        Console.WriteLine("Exiting the program. Goodbye!");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid input. Please enter a valid operation.");
            //        break;
            //}
            #endregion

            #region 21
            // int number1 = int.Parse(Console.ReadLine());
            // int number2 = int.Parse(Console.ReadLine());
            // int start = 0;
            // int end = 0;
            // int oddSum = 0;
            // int evenSum = 0;
            // if (number1 < number2)
            // {
            //     start = number1;
            //     end = number2;
            // }
            // else
            // {
            //     start = number2;
            //     end = number1;
            // }
            //for (int i = start; i < end; i++)
            // {
            //     if(i%2 == 0)
            //     {
            //         Console.WriteLine(i+"is even num");
            //         evenSum += i;
            //     }
            //     else
            //     {
            //         Console.WriteLine(i+"is odd num");
            //         oddSum += i;
            //     }
            // }

            // Console.WriteLine("Even Sum is "+ evenSum);
            // Console.WriteLine("Odd sum is "+oddSum);

            // int difference = Math.Abs(evenSum - oddSum);
            // Console.WriteLine("Difference is "+difference);
            #endregion

        }

        #region
        public static void sumTwoNums(int num1 , int num2)
        {

            int sum = 0;
            
            if (num1 == num2)
            {
                sum = (num1 + num2) * 3;
            }
            else
            {
                sum = num1 + num2;
            }
            Console.WriteLine(sum);
         #endregion

        }

    }
}



