using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while true

            //bool isTrue = true;

            //while (isTrue)
            //{
            //    try
            //    {
            //        Console.WriteLine("enter your age:");
            //        //string strAge = Console.ReadLine();

            //        //int bytAge = int.Parse(strAge);

            //        int age = int.Parse(Console.ReadLine());

            //        if (age > 16)
            //        {
            //            Console.WriteLine("Welcome!");
            //            isTrue = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("You cant enter!");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Please enter a number!");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Finally bloku");
            //    }
            //}




            #endregion

            #region Switch case, if else


            //if (operation == '+')
            //{
            //    Console.WriteLine(firstNum + secondNum);
            //}
            //else if (operation == '-')
            //{
            //    Console.WriteLine(firstNum - secondNum);
            //}
            //else if (operation == '/')
            //{
            //    Console.WriteLine(firstNum / secondNum);
            //}
            //else if (operation == '*')
            //{
            //    Console.WriteLine(firstNum * secondNum);
            //}



            //while (true)
            //{

            //    try
            //    {

            //        Console.Write("enter first number:");
            //        int firstNum = int.Parse(Console.ReadLine());

            //        Console.Write("enter second number:");
            //        int secondNum = int.Parse(Console.ReadLine());

            //        Console.Write("enter an operation:");
            //        char operation = char.Parse(Console.ReadLine());

            //        switch (operation)
            //        {
            //            case '+':
            //                Console.WriteLine(firstNum + secondNum);
            //                break;
            //            case '-':
            //                Console.WriteLine(firstNum - secondNum);
            //                break;
            //            case '*':
            //                Console.WriteLine(firstNum * secondNum);
            //                break;
            //            case '/':
            //                Console.WriteLine(firstNum / secondNum);
            //                break;
            //            default:
            //                Console.WriteLine("operation is not correct!");
            //                break;
            //        }
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("cannot divide by zero!!!");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Error!");
            //    }
            //}

            #endregion

            #region array loop
            //int[] array = { 12, 15, 16, 18, 19, 20, 25 };


            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //int i = 0;

            //while (i<array.Length)
            //{
            //    Console.WriteLine(array[i]);
            //    i++;
            //}

            //foreach (int num in array)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region divide by 2 array
            //int[] numbers = { 213, 15, 16, 18, 49 };

            //foreach (int num in numbers)
            //{
            //    if (num % 2 == 0)
            //        Console.WriteLine(num);
            //}
            #endregion
        }
    }
}
