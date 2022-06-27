using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETlab03
{
    abstract class AddAnimal
    {
        public IAnimal CreateAnimal(string name, int age, Food food)
        {
            float ration = CalculateRation(age);
            OrderFood(food, ration);
            return FactoryMethod(name, age, ration);
        }
        public abstract IAnimal FactoryMethod(string name, int age, float ration);
        public abstract float CalculateRation(int age);
        public abstract void OrderFood(Food food, float ration);
        public abstract Type ReturnType();
    }
}
