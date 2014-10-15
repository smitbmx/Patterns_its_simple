using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            LaptopBuilder tripBuilder = new TripLaptopBuilder();
            LaptopBuilder gamingBuilder = new GamingLaptopBuilder();

            BuyLaptop buyLaptop = new BuyLaptop();
            buyLaptop.SetLaptopBuilder(tripBuilder);
            buyLaptop.ConstructLaptop();

            Laptop laptop = buyLaptop.GetLaptop();

            Console.WriteLine(laptop.ToString());


            BuyLaptop buySecondLaptop = new BuyLaptop();
            buySecondLaptop.SetLaptopBuilder(gamingBuilder);
            buySecondLaptop.ConstructLaptop();
            string laptopData = buySecondLaptop.GetLaptop().ToString();

            Console.WriteLine(laptopData);

            Console.ReadLine();
        }
    }
}
