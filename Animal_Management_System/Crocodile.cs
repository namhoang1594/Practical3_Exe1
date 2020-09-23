using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Animal_Management_System
{
    class Crocodile : IMarineAnimal,ITerrestrialAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
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
