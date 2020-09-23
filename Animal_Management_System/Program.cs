using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading;

namespace Animal_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;
            Console.WriteLine("ANIMAL MANAGEMENT SYSTEM");
            Console.WriteLine("1. Create a Crocodile");
            Console.WriteLine("2. Create a Cat");
            Console.WriteLine("3. Create a Fish");
            Console.WriteLine("4. View Terrestrial Animals");
            Console.WriteLine("5. View Marine Animals");
            Console.WriteLine("6. View All Animals");
            Console.WriteLine("7. Delete Animal");
            Console.WriteLine("8. Exit");
            do
            {
                Console.WriteLine("\n Select: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.CreateaCrocodile();
                        break;
                    case 2:
                        program.CreateaCat();
                        break;
                    case 3:
                        program.CreateaFish();
                        break;
                    case 4:
                        program.ViewTerrestrialAnimals();
                        break;
                    case 5:
                        program.ViewMarineAnimals();
                        break;
                    case 6:
                        program.ViewAllAnimals();
                        break;
                    case 7:
                        program.DeleteAnimals();
                        break;
                    case 8: return;
                }
            }
            while (choice != 8);
        }
        int count = 0;
        ArrayList animal = new ArrayList();
        public void CreateaCrocodile()
        {
            Crocodile crocodile = new Crocodile();
            crocodile.ID = count;
            Console.WriteLine("Name of Crocodile: ");
            crocodile.Name = Console.ReadLine();
            Console.WriteLine("Age of Crocodile: ");
            crocodile.Age = Int32.Parse(Console.ReadLine());
            animal.Add(count);
            animal.Add(crocodile);
            count++;
        }
        public void CreateaCat()
        {
            Cat cat = new Cat();
            cat.ID = count;
            Console.WriteLine("Name of Cat: ");
            cat.Name = Console.ReadLine();
            Console.WriteLine("Age of Cat: ");
            cat.Age = Int32.Parse(Console.ReadLine());
            animal.Add(count);
            animal.Add(cat);
            count++;
        }
        public void CreateaFish()
        {
            Fish fish = new Fish();
            fish.ID = count;
            Console.WriteLine("Name of Fish: ");
            fish.Name = Console.ReadLine();
            Console.WriteLine("Age of Fish: ");
            fish.Age = Int32.Parse(Console.ReadLine());
            animal.Add(count);
            animal.Add(fish);
            count++;
        }
        public void ViewTerrestrialAnimals()
        {
            Cat c = new Cat();
            for (int i = 0; i < animal.Count; i++)
                if (animal[i].GetType().Equals(c.GetType()))
                {
                    Console.WriteLine(animal[i].ToString());
                    c.Move();
                }
        }
        public void ViewMarineAnimals()
        {
            Fish f = new Fish();
            for (int i = 0; i < animal.Count; i++)
                if (animal[i].GetType().Equals(f.GetType()))
                {
                    Console.WriteLine(animal[i].ToString());
                    f.Move();
                }
        }
        public void ViewAllAnimals()
        {
            foreach(var item in animal)
            {
                Console.WriteLine(item);
            }
        }
        public void DeleteAnimals()
        {
            int n;
            Console.WriteLine("Please select a ID: ");
            n = Int32.Parse(Console.ReadLine());
            foreach (var item in animal)
                if (item.Equals(n))
                {
                    animal.RemoveAt(n);
                    break;
                }
            Console.WriteLine(animal.Count);
        }
    }
}
