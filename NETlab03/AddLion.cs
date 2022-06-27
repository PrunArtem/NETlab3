using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETlab03
{
    class AddLion : AddAnimal
    {
        public override IAnimal FactoryMethod(string name, int age, float ration)
        {
            return new Lion(name, age, ration);
        }
        public override float CalculateRation(int age)
        {
            return age * 5;
        }
        public override void OrderFood(Food food, float ration)
        {
            food.amount += 3 * ration;
        }
        public override Type ReturnType()
        {
            return typeof(Lion);
        }
    }
}
