using System;

namespace CsharpTut6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.SetName("Pishi");
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);

            cat.Owner = "Hanie";

            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);

            Console.WriteLine("{0} Shelter ID is {1}", cat.GetName(), cat.idNUm);


            Animal fox = new Animal("Oscar", "raawww");
            fox.Owner = "Attiyeh";
            Console.WriteLine("{0} owner is {1}", fox.GetName(), fox.Owner);


            Console.WriteLine("# of Animals {0}", Animal.NumOfAnimals);


            Console.ReadLine();

            
        }
    }
}
