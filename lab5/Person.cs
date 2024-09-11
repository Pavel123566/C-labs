using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Person
    {
        private string name;
        private int age;
        private char sex; // 'M' of 'F'

        public Person()
        {
            name = "None";
            age = 18;
            sex = 'M';
        }

        public Person(string name, int age, char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public override string ToString()
        {
            return $"name={name}, age={age}, sex={sex}";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public char Sex
        {
            get { return sex; }
            set { sex = value; }
        }
    }
}
