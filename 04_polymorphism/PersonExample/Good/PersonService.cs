using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polymorphism.PersonExample.Good
{
    internal class PersonService
    {
        //public void Login(Student st) => Console.WriteLine($"Stuedent is login");
        //public void Login(Teacher st) => Console.WriteLine($"Teacher is login");

        public void Login(Person person) => Console.WriteLine(person.LoginChange());
    }
}
