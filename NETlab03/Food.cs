using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETlab03
{
    class Food
    {
        public float amount { get; set; }
        public Type animal { get; set; }
        public Food(float amount, Type animal)
        {
            this.amount = amount;
            this.animal = animal;
        }
        public void Decrase(float decraseBy)
        {
            if (amount - decraseBy >= 0)
                amount -= decraseBy;
            else throw new Exception("Not enough stored food");
        }
    }
}
