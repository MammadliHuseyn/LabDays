using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newnamespace;

namespace lab8Oktyabr
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Find Phrase

            //string word = "Hello World!";
            //string phrase = "worl";

            //Console.WriteLine(FindPhrase(word,phrase));

            //FindPhrase(word, phrase);

            #endregion

            #region Anonymous Objects

            //var person = new
            //{
            //    name = "Reshad",
            //    surname = "Xanmemmedli",
            //    age = 27
            //};

            //var person1 = new
            //{
            //    name = "Huseyn",
            //    surname = "Memmedli",
            //    age = 19
            //};



            #endregion

            #region Class,Instance object

            //Person person = new Person();
            //person.Name = "Reshad";
            //person.Surname = "Xanmemmedli";
            //person.Age = 27;

            //Person person = new Person()
            //{
            //    Name = "Reshad",
            //    Surname = "XanMemmedli",
            //    Age = 27
            //};

            //Person person = new Person("Huseyn","Memmedli",19);
            //Person person = new Person();
            //person.SetInfo("Huseyn", "Memmedli", 18);

            //Console.WriteLine(person.GetInfo());

            #endregion

            #region Inheritance,base,polymorpishm

            //Employee employee = new Employee("Huseyn","Memmedli",19,3,800);

            //Console.WriteLine( employee.GetInfo() );

            #endregion

            #region Encapsulation

            Person person = new Person();

            person.SetInfo("a", "b", 18);

            Console.WriteLine(person.GetInfo());



            #endregion

            #region namespace

            lab8Oktyabr.Person person1 = new lab8Oktyabr.Person();

            Human human = new Human();

            #endregion
        }

        #region Find Phrase

        static bool FindPhrase(string word, string phrase)
        {
            string str = String.Empty;
            word = word.ToLower();
            phrase = phrase.ToLower();
            word = word.Trim(' ');
            phrase = phrase.Trim(' ');

            for (int i = 0; i < word.Length; i++)
            {
                if (i == word.Length - phrase.Length)
                {
                    break;
                }

                for (int j = i; j < i + phrase.Length; j++)
                {
                    str += word[j];
                }

                if (str == phrase)
                    return true;

                str = String.Empty;
            }
            return false;

        }

        #endregion

    }
}
