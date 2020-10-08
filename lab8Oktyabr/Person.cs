using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8Oktyabr
{
    class Person
    {
        public readonly string Name = "Huseyn";
        private readonly string Surname;
        private byte _age;
        public byte Age 
        { get
            {
                return _age;
            }
             
          set
            {
                if(value < 100)
                _age = Age;
            }
        }


        public Person()
        {
            Console.WriteLine("New Person created!");
        }

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void SetInfo(string name,string surname,byte age )
        {
            //Name = name;
            //Surname = surname;
            Age = age;
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name} Surname: {Surname} Age: {Age}";
        }


    }
}
namespace newnamespace
{
    class Person { }
    class Human { }
}