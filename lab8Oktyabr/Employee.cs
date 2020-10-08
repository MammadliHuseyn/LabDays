using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8Oktyabr
{
    class Employee:Person
    {
        public byte Experience;
        public double Salary;

        public Employee(string name, string surname,byte age,byte exp, double salary):base(name,surname,age)
        {
            Experience = exp;
            Salary = salary;
        }


        public void SetInfo(string name)
        {
            //Name = name;
        }

        //polymorpishm
        public override string GetInfo()
        {
            return $"{base.GetInfo()} exp: {Experience} salary: {Salary}";
        }


    }
}
