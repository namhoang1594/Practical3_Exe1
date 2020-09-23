using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Management_System
{
    class Cat : ITerrestrialAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
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
