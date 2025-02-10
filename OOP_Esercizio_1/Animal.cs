using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Esercizio_1
{
    public class Animal
    {
        public string FirstName { get; set; }
        public string Nickname { get; set; }
        public string CodeName { get; set; }
        public string Species { get; set; }
        public string Mission { get; set; }
        public string RestingPlace { get; set; }

        public Animal(string firstname, string nickname, string codename, string species, string mission, string restingplace)
        {
            this.FirstName = firstname;
            this.Nickname = nickname;
            this.CodeName = codename;
            this.Species = species;
            this.Mission = mission;
            this.RestingPlace = restingplace;
        }

        public void showAnimalData()
        {
            Console.WriteLine(FirstName + " also known as " + Nickname + " was a " + Species + " that participated in " + Mission + ", part of the U.S. space program's Project Mercury. He's currently buried at the " + RestingPlace);
        }
    }
}
