using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETlab03
{
    class AddKangaroo : AddAnimal
    {
        public override IAnimal FactoryMethod(string name, int age, float ration) {
            return new Kangaroo(name, age, ration);
        }
        public override float CalculateRation(int age) {
            return age * 3;
        }
        public override void OrderFood(Food food, float ration) {
            food.amount += 10 * ration;
        }
        public override Type ReturnType()
        {
            return typeof(Kangaroo);
        }
    }
}
