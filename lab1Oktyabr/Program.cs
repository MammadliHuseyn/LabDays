using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Oktyabr
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Starts with phrase

            //string word = "Azerbaijan";
            //Console.WriteLine(StartsWith(word, "aze"));

            #endregion

            #region Var, dynamic

            //var number = "5";
            //number = "example";

            //dynamic str = "Huseyn";
            //str = 565;

            #endregion

            #region ref, out

            //int a = 5;
            //int b;
            //b = a;

            //b = 10;

            //Console.WriteLine(a);

            //string str = "Huseyn";

            //string str2 = str;

            //str2 = "Agil";

            //Console.WriteLine(str2);

            //int[] arr = { 1, 2, 3 };

            //int[] arr2 = arr;

            //arr2 = new int[] { 5, 6, 7 };

            //Console.WriteLine(arr2[0]);


            //int a;
            //RefExample(out a);
            //Console.WriteLine($"from main : {a}");



            #endregion

            #region TryParse

            //Console.WriteLine("Enter a number: ");
            //string str = Console.ReadLine();

            //int num;

            //bool isTrue = Int32.TryParse(str, out num);

            //if (isTrue)
            //    Console.WriteLine("success " + num);
            //else
            //    Console.WriteLine("error!");


            #endregion

            #region String methods


            //string str = "Welcome";

            //ToLower
            //str = str.ToLower();
            //Console.WriteLine(str);

            //ToUpper
            //str = str.ToUpper();
            //Console.WriteLine(str);

            //Replace
            //str = str.Replace("COmE", "salam");
            //Console.WriteLine(str);

            //Trim, TrimEnd,
            //str = str.Trim(' ');
            //Console.WriteLine(str);
            #endregion
        }

        #region ref,out
        //static void RefExample(int a)
        //{
        //    a = 5;
        //    Console.WriteLine($"from method : {a}");
        //}

        //static void RefExample(out int a)
        //{
        //    a = 5;
        //    Console.WriteLine($"from method : {a}");
        //}
        #endregion

        #region Starts with phrase

        static bool StartsWith(string word, string phrase)
        {
            word = word.ToLower();
            phrase = phrase.ToLower();

            string sb = String.Empty;

            for (int i = 0; i < phrase.Length; i++)
            {
                sb += $"{word[i]}";
            }

            if (sb == phrase)
                return true;

            return false;
        }

        #endregion
    }
}
