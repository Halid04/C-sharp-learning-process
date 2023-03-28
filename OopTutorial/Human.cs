using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTutorial
{
    internal class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human() { }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        
        public void IntroduceMyself()
        {
            if (age < 2)
            {
            Console.WriteLine("My name is {0} {1}, my eyescolor are {2} and i'm {3} year old", firstName,lastName,eyeColor,age);
            }
            else
            {
                Console.WriteLine("My name is {0} {1}, my eyescolor are {2} and i'm {3} years old", firstName, lastName, eyeColor, age);
            }
        }
    }
}
