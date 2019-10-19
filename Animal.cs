using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace CsharpTut6
{
    class Animal
    {
        private string name;
        private string sound;


        public const string SHELTER = "Mohsen's Home for Animals";

        public readonly int idNUm;

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        public Animal()
        : this("No Name", "No Sound") { }

        public Animal(string name)
        : this(name, "no SOund") { }


        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;

            Random rnd = new Random();
            idNUm = rnd.Next(1, 2147483640);

        }

        public void SetName(string name)
        {

            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name can't contain numbers");
            }
        }

        public string GetName()
        {
            return name;
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too Long");
                }
                sound = value;
            }
        }

        public string Owner{ get; set; } = "No Owner";

        public static int numOfAnimals = 0;

        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }
    }
}
