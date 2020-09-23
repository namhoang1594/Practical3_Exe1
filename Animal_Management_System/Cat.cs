using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Management_System
{
    class Cat : ITerrestrialAnimal
    {
        public int id;
        public string name;
        public int age;
        public int ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public void Move()
        {
            Console.WriteLine("RUN");
        }
        public override string ToString()
        {
            Console.WriteLine(GetType());
            return "ID = : " + ID + ", Name = : " + Name + ", Age = : " + Age;
        }
    }
}
