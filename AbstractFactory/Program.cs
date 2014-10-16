using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IToyFactory teddyToyFactory = new TeddyToysFactory();
            Bear teddyBear = teddyToyFactory.GettBear();
            Cat teddyCat = teddyToyFactory.GetCat();

            Console.WriteLine(string.Concat(teddyBear.Name, " ", teddyCat.Name));


            IToyFactory woodenToyFactory = new WoodenToysFactory();
            Bear woodenBear = woodenToyFactory.GettBear();
            Cat woodenCat = woodenToyFactory.GetCat();

            Console.WriteLine(string.Concat(woodenBear.Name, " ", woodenCat.Name));


            Console.ReadLine();
        }
    }
}
