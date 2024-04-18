using UDR.Models;

namespace UDR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow  cow = new Cow("inek momo");
            Lion lion = new Lion("kral mufasa",true);

            Animal[] animals=new Animal[] {lion,cow,new Lion("simba",false)};

            foreach (var animal in animals) 
            {   
                Meat meat = new Meat(1500, "zebr");
                Grass grass = new(900, "yonca");
                if (animal is Lion li)
                {
                    Console.WriteLine(li.Breed);
                    
                    li.EatFood(meat);
                    li.MakeSound();
                    li.EatFood(grass);
                    

                }
                else if (animal is Cow c)
                {
                    Console.WriteLine(c.Breed);
                    
                    c.EatFood(grass);
                    c.ProduceMilk();
                    c.MakeSound();
                   
                    

                }
                Console.WriteLine("");
                //var type = animal.GetType();
                //Console.WriteLine(type.Name);
                //foreach (var item in type.GetFields())
                //{
                //    Console.WriteLine(item.GetValue(animal));
                //}
            }
        }
    }
}
