using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Management_System
{
    interface IAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
