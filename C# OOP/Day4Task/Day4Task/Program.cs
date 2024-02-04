using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Task
{
    internal class Program
    {
        #region handling one dimension arrays
        public static void FindAndDisplayRepeatedElements(int[] array, int[] repeatedElementsArr)
        {
            Console.WriteLine("Repeated elements in the array:");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine($"Element {array[i]}");
                        repeatedElementsArr[i] = array[j];
                    }
                }
            }
            for (int i = 0; i < repeatedElementsArr.Length; i++)
            {
                Console.WriteLine("repeated elements are " + repeatedElementsArr[i]);

            }
        }

        public static int[] ReservingArray(int size)
        {
            int[] array = new int[size];

            return array;

        }

        public static void FillArray(int[] array)
        {
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void SumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("sum is " + sum);
        }


        public static int[] GetOddOnes(int[] _arr)
        {
            int[] oddones = new int[_arr.Length];
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] % 2 != 0)
                { oddones[i] = _arr[i]; }
            }

            return oddones;
        }
        public static int[] GetEvenOnes(int[] _arr)
        {
            int[] evenones = new int[_arr.Length];
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] % 2 == 0)
                { evenones[i] = _arr[i]; }
            }

            return evenones;
        }

        public static int getMax(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int GetMin(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int GetAvg(int[] array)
        {
            int avg = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            avg = sum / array.Length;
            return avg;
        }

        #endregion

        #region Q3 methods
        public static void FillTwoDimArray(int[,] arr)
        {
            Console.WriteLine("please enter array elements");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }


        public static void CalculateAndDisplayRowSums(int[,] array)
        {
            Console.WriteLine("\nSum of every row:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int rowSum = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    rowSum += array[i, j];
                }

                Console.WriteLine($"Row {i + 1}: {rowSum}");
            }
        }


        public static void CalculateAndDisplayColumnAverages(int[,] array)
        {
            Console.WriteLine("\nAverage of every column:");

            for (int j = 0; j < array.GetLength(1); j++)
            {
                int columnSum = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    columnSum += array[i, j];
                }

                double columnAverage = (double)columnSum / array.GetLength(0);

                Console.WriteLine($"Column {j + 1}: {columnAverage}");
            }
        }
        #endregion


        #region create array with specific dimensions
        public static int[] CreateArraywithDims()
        {
            Console.WriteLine("please enter the desired dimensions ");
            int dim = int.Parse(Console.ReadLine());
            
             int[]array = new int[dim];
              DisplayArray(array);

            return array;
            
        }
        #endregion





        public static void Menu(String choice)
        {
            int[,] arr = new int[2, 3];
            switch (choice)
            {
                case "Dimension":
                    CreateArraywithDims();
                    break;

                case "FillArray":
                    FillTwoDimArray(arr);
                    break;
                case "GetRowSum":
                    CalculateAndDisplayRowSums(arr);
                    break;
                case "Column Avg":
                    CalculateAndDisplayColumnAverages(arr);
                    break;
                case "exit":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                    break;
            }
        }




        public static int[] ConcatArrays(int[] array1, int[] array2)
        {
            int[] resultArray = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i];
            }

            for (int j = 0; j < array2.Length; j++)
            {
                resultArray[array1.Length + j] = array2[j];
            }

            return resultArray;
        }

        #region Q6 Find Repeated elements 
        public static void FindRepeated() 
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            int[] count = new int[13];

            for (int j = 0; j < array.Length; j++)
            {
                int number = array[j];
                count[number]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                int numberCount = count[i];
                if (numberCount > 1)
                {
                    Console.WriteLine(i + " occurs " + numberCount + " times");
                }
            }
        }

        #endregion

        static bool CheckUnique(int[] array, int userInput)
        {
            for (int i = 0;i<array.Length;i++)
            
            {
                if (array[i] == userInput)
                {
                    return false;
                }
            }
            return true;
        }


        public static int GetPower(int baseValue, int exponent)
        {

            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseValue;
            }

            return result;
        }






        public static void Main(string[] args)
        {

            #region Repeated array
            //int[] array = {2,3,2,4,5,5 };
            //int[] repeatedarr = new int[array.Length];
            //FindAndDisplayRepeatedElements(array, repeatedarr);
            #endregion

            #region Q2 reserver fill and display getodd get even get avg
            //int[] arr = new int[4];
            //FillArray(arr);
            //DisplayArray(arr);
            //SumArray(arr);

            #endregion

            #region Q3

            //int[,] array = new int[3,4];
            //FillTwoDimArray(array);
            //CalculateAndDisplayRowSums(array);
            //CalculateAndDisplayColumnAverages(array);
            #endregion

            #region Q4 ( Menu )
            //Menu("Dimension");


            #endregion



            #region Q5 Concat
            //int[] arr1 = { 1, 2, 3, 4};
            //int[] arr2 = { 10, 20, 30, 40,50 };
            //int [] arr= ConcatArrays(arr1, arr2);
            //Console.WriteLine($"Concatinated array is \t");
            //DisplayArray(arr);

            #endregion

            #region Q6 repeated elements in array 


            //FindRepeated();

            #endregion

            #region Q7 check uniqiness




            //int[] userArray = new int[10];

            //for (int i = 0; i < userArray.Length; i++)
            //{
            //    int userInput;

            //    while (true)
            //    {
            //        Console.Write($"Enter value {i + 1}: ");

            //        userInput = int.Parse(Console.ReadLine());
            //        if (CheckUnique(userArray, userInput))
            //        {
            //            userArray[i] = userInput;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Value must be unique. Please try again.");
            //        }
            //    }


            //}

            #endregion



            #region Q8 GetPower
            //Console.WriteLine(GetPower(2,3));
            #endregion





        }
    }
}
