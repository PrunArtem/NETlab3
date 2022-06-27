using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETlab03
{
    class Monkey : IAnimal
    {
        public string name { get; set; }
        public int age { get; set; }
        public float ration { get; set; }
        public Monkey(string name, int age, float ration)
        {
            this.name = name;
            this.age = age;
            this.ration = ration;
        }
        public void Feed(Food food)
        {
            try
            {
                if (food.animal == typeof(Monkey))
                    food.Decrase(ration);
                else throw new Exception("Wrong food type");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

