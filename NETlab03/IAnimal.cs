using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETlab03
{
    interface IAnimal
    {
        string name { get; set; }
        int age { get; set; }
        float ration { get; set; }
        void Feed(Food food);
    }
}
