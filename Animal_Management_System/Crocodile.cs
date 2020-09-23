using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Animal_Management_System
{
    class Crocodile : IMarineAnimal,ITerrestrialAnimal
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
        void ITerrestrialAnimal.Move()
        {
            Console.WriteLine("RUN");
        }
        void IMarineAnimal.Move()
        {
            Console.WriteLine("SWIM");
        }
        public override string ToString()
        {
            Console.WriteLine(GetType());
            return "ID = : " + ID + ", Name = : " + Name + ", Age = : " + Age;
        }
    }
}
