using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Esercizio_1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string Nickname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        public string Employer { get; set; }

        public Employee(string firstname, string nickname, string lastname, int age, string profession, string employer)
        {
            this.FirstName = firstname;
            this.Nickname = nickname;
            this.LastName = lastname;
            this.Age = age;
            this.Profession = profession;
            this.Employer = employer;
        }

        public void showEmployeeData()
        {
            Console.WriteLine(FirstName + " " + Nickname + " " + LastName + " is " + Age + " years old. He's a " + Profession + " currently working for " + Employer);
        }
    }
}
