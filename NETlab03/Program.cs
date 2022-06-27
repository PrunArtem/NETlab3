using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETlab03
{
    class Program
    {
        static List<Food> foods = new List<Food>(){
            new Food(50, typeof(Kangaroo)),
            new Food(50, typeof(Koala)),
            new Food(50, typeof(Lion)),
            new Food(50, typeof(Monkey)),
        };
        static List<IAnimal> zoo = new List<IAnimal>() { 
            new Kangaroo("Kangoo", 3, 9),
            new Koala("Koal", 4, 8),
            new Lion("Leo", 3, 15),
            new Monkey("Funy", 2, 4)
        };
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int choice = 0;
            bool choice_check;
            Console.WriteLine("_______menu_______\n1) Show all animals\n2) Feed an animal\n3) Add an animal\n4) Exit");
            while (choice != 4)
            {
                do
                {
                    Console.Write("\nChoose a possible option: ");
                    string choice_input = Console.ReadLine();
                    choice_check = Int32.TryParse(choice_input, out choice);
                }
                while (choice_check == false || choice < 1 || choice > 4);
                try
                {
                    switch (choice)
                    {
                        case 1:
                            showAnimals();
                            break;
                        case 2:
                            feedAnimal();
                            break;
                        case 3:
                            addAnimal();
                            break;
                        case 4:
                            return;
                    }
                }
                catch { }
            }
        }
        static void showAnimals()
        {
            foreach (var animal in zoo.OrderBy(t => t.GetType().Name))
                Console.WriteLine($"{animal.GetType().Name} {animal.name} age: {animal.age}");
        }
        static void feedAnimal()
        {
            Console.Write("Enter a name of an animal to feed: ");
            string name = Console.ReadLine();
            var animal = zoo.Where(a => a.name == name).First();
            animal.Feed(foods.Where(f => f.animal == animal.GetType()).First());
            Console.WriteLine($"Food left: {foods.Where(f => f.animal == animal.GetType()).First().amount}");
        }
        static void addAnimal()
        {
            Console.WriteLine("Which animal to add?");
            string newAnimal = Console.ReadLine();
            Console.WriteLine("Enter it's name:");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter it's age:");
            int newAge = Int32.Parse(Console.ReadLine()); 
            switch (newAnimal.ToLower())
            {
                case "kangaroo":
                    add(new AddKangaroo(), newName, newAge);
                    break;
                case "koala":
                    add(new AddKoala(), newName, newAge);
                    break;
                case "lion":
                    add(new AddLion(), newName, newAge);
                    break;
                case "monkey":
                    add(new AddMonkey(), newName, newAge);
                    break;
            }
        }
        static void add(AddAnimal creator, string newName, int newAge)
        {
            zoo.Add(creator.CreateAnimal(newName, newAge, foods.Where(f => f.animal == creator.ReturnType()).First()));
        }
    }
}
