using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {





        }



            #region Q1 method
            public static void sumTwoNums(int num1, int num2)
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
            }
            #endregion

            #region Q2 method 

            public static void differenceFrom51(int n)
            {

                int difference = 51 - n;
                if (n > 51)
                {
                    Console.WriteLine("Absolute difference is " + -difference * 3);
                }
                else
                {
                    Console.WriteLine(difference);
                }
            }

        #endregion

            #region Q3 method
        public static Boolean numThirty(int num1 , int num2) { 
        
        if(num1+num2==30 || num1==30 || num2==30)
        {
                return true;
        }
        else {
                return false;
            }

        }
        #endregion

        #region Q4 method
        public static Boolean division(int num)
        {
            if (num % 3 == 0 || num % 7 == 0)
            {
                return true;

            }
            else { return false; 
            }
        }
        #endregion

        #region Q5 method
        public static void checkRange(int num1, int num2)
        {
            if (num1 >= 100 && num1 <= 200 && num2 >= 100 && num2 <= 200)
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
        }
        #endregion

        
        #region Q6 method
        public static Boolean checkNums(int num1 , int num2 , int num3)
        {
            if (num1 >= 20 && num1 <= 50 || num2 >= 20 && num2 <= 50 || num3 >= 20 && num3 <= 50)
            {
                return true;
            }
            else {
                return false;
            }
        }
        #endregion

        #region Q7 method
        public static int maxNum(int num1 , int num2 , int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else { return num3; 
            }
        }
        #endregion

        #region Q8 method
            public static void nearestTo100(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("0");
            }
            int difference1 = 100 - num1;
            int difference2 = 100 - num2;
            if (difference1 < difference2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(difference2);
            }
        }
        #endregion

        #region Q9 method
        public static Boolean checkRange2(int num1 , int num2)
        {
            if (num1 >= 40 && num1 <= 50 && num2 >= 40 && num2 <= 50
                || num1 >= 50 && num1 <= 60 && num2 >= 50 && num2 <= 60)
            {
                return true;            
            }
            else { return false;
            }
        }
        #endregion

        #region Q10 method
        public static void highestNumInRange(int num1 , int num2)
        {
            if (num1 >= 20 && num1 <= 30 && num2 >= 20 && num2 <= 30)
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num1);
                }
                else { Console.WriteLine(num2); }

            }
            else { Console.WriteLine("0"); }

        }
        #endregion

        #region Q11 method
        public static String numberOfCopies(int n,String inputString) {


            if (n >= 0)
            {
                string result = "";

                for (int i = 0; i < n; i++)
                {
                    result += inputString;
                }

               return result;
            }
            else
            {
                return "enter a non-negative integer for the number of copies.";
            }
        }

        #endregion

        #region Q 12 method
        public static Boolean chechNums(int num1 , int num2)
        {
            if (num1 == 5 || num2 == 5 || num1 + num2 == 5 || num1 - num2 == 5 || num2 - num1 == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Q13 method 
        public static Boolean divisionOn3And7 (int num1)
        {
            if (num1 % 3 == 0 && num1 % 7 == 0)
            {
                return false;        
            }
            else if (num1 % 3 == 0 || num1 % 7 == 0)
            {
                return true;       
            }
            return  false;
        }
        #endregion

        
        #region Q14 method 
        public static void fuzzBuzz (int num1, int num2)
        {
            if (num1 % 3 == 0 && num1 % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num1 % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num1 % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }

        #endregion

        #region Q15 method
        public static void twoNumsEqualThird(int num1, int num2,int num3)
        {
            bool isPossible = (num1 + num2 == num3) || (num2 + num3 == num1) || (num3 + num1 == num2);

            if (isPossible)
            {
                Console.WriteLine($"{num1} + {num2} equals {num3}. It is possible to add two integers to get the third integer.");
            }
            else
            {
                Console.WriteLine(" It is not possible to add two integers to get the third integer.");
            }
        }
        #endregion

        #region Q16 method 
        public static Boolean highestAscendingNum(int num1, int num2,int num3)
        {
            if (num1 < num2 && num2 < num3)
            {
                return true;          
            }
            else
            {
                return false;       
            }
        }
        #endregion

        #region Q17 method
        public static void multiplicationTables(int tableNum)
        {
            for (int i = 0; i < 13; i++)
            {

                Console.WriteLine($"{tableNum} * {i} = {tableNum * i}");
            }
        }
        #endregion

        #region Q18 method
        public static void maxOfThreeNums(int num1 , int num2 , int num3 ) {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("the max is " + num1);
                if (num2 > num3)
                {
                    Console.WriteLine("min is " + num3);
                }
                else { Console.WriteLine("min is " + num2); };
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("the max is " + num2);
                if (num1 > num3) { Console.WriteLine("min is " + num3); }
                else { Console.WriteLine("min is " + num1); }
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("max is " + num3);
                if (num2 > num1)
                {
                    Console.WriteLine("min is " + num1);
                }
                else { Console.WriteLine("min is " + num2); }
            }


        }
        #endregion

        #region Q19 method
        public static void displayTill400(int number)
        {
            int sum = 0;
            while (sum <= 400)
            {
                sum += number;
                Console.WriteLine(sum);
            }
        }
        #endregion

        #region Q20 method
        public static void operators (int number1 ,int number2, String operation) {

            
            switch (operation)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 = number2);
                    break;
                case "/":
                    Console.WriteLine(number1 / number2);

                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "E || e":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid operation.");
                    break;
            }
        }
        #endregion

        #region Q21 method
        public static void evenOdd(int number1 , int number2)
        {

            int start = 0;
            int end = 0;
            int oddSum = 0;
            int evenSum = 0;
            if (number1 < number2)
            {
                start = number1;
                end = number2;
            }
            else
            {
                start = number2;
                end = number1;
            }
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "is even num");
                    evenSum += i;
                }
                else
                {
                    Console.WriteLine(i + "is odd num");
                    oddSum += i;
                }
            }

            Console.WriteLine("Even Sum is " + evenSum);
            Console.WriteLine("Odd sum is " + oddSum);

            int difference = Math.Abs(evenSum - oddSum);
            Console.WriteLine("Difference is " + difference);
        }
        #endregion

    }
}
