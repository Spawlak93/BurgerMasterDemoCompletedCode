using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class BurgerMaster
    {
        //Cook Patty
        public Patty CookPatty()
        {
            Console.WriteLine("Putting patty on the grill", Console.ForegroundColor = ConsoleColor.Red);
            Task.Delay(1000).Wait();
            Console.WriteLine("Flipping patty", Console.ForegroundColor = ConsoleColor.Red);
            Task.Delay(1000).Wait();
            Console.WriteLine("Taking patty off the grill", Console.ForegroundColor = ConsoleColor.Red);
            Console.ResetColor();
            return new Patty();
        }
        //Async Cook Patty
        public async Task<Patty> CookPattyAsync()
        {

            Console.WriteLine("Putting patty on the grill", Console.ForegroundColor = ConsoleColor.Red);
            await Task.Delay(1000);
            Console.WriteLine("Flipping patty", Console.ForegroundColor = ConsoleColor.Red);
            await Task.Delay(1000);
            Console.WriteLine("Taking patty off the grill", Console.ForegroundColor = ConsoleColor.Red);
            Console.ResetColor();
            return new Patty();
        }

        //Fry Fries
        public Fries FryFries()
        {
            Console.WriteLine("Putting Fries in the Frier", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("Lowering the basket", Console.ForegroundColor = ConsoleColor.Blue);
            Task.Delay(3000).Wait();
            Console.WriteLine("Pulling fries from frier", Console.ForegroundColor = ConsoleColor.Blue);
            Console.ResetColor();
            return new Fries();
        }
        //Async Fry Fries
        public async Task<Fries> FryFriesAsync()
        {
            Console.WriteLine("Putting Fries in the Frier", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("Lowering the basket", Console.ForegroundColor = ConsoleColor.Blue);
            await Task.Delay(3000);
            Console.WriteLine("Pulling fries from frier", Console.ForegroundColor = ConsoleColor.Blue);
            Console.ResetColor();
            return new Fries();
        }
        //Chop Produce
        public Produce ChopProduce()
        {
            Console.WriteLine("Cutting Tomato", Console.ForegroundColor = ConsoleColor.DarkGreen);
            Task.Delay(500).Wait();
            Console.WriteLine("Cutting Onion", Console.ForegroundColor = ConsoleColor.DarkGreen);
            Task.Delay(500).Wait();
            Console.WriteLine("Chopping Letuce", Console.ForegroundColor = ConsoleColor.DarkGreen);
            Task.Delay(500).Wait();
            Console.ResetColor();
            return new Produce();
        }
        //Async Chop Produce 
        public async Task<Produce> ChopProduceAsync()
        {
            Console.WriteLine("Cutting Tomato", Console.ForegroundColor = ConsoleColor.DarkGreen);
            await Task.Delay(500);
            Console.WriteLine("Cutting Onion", Console.ForegroundColor = ConsoleColor.DarkGreen);
            await Task.Delay(500);
            Console.WriteLine("Chopping Letuce", Console.ForegroundColor = ConsoleColor.DarkGreen);
            await Task.Delay(500);
            Console.ResetColor();
            return new Produce();
        }

        //Toast Bun
        public Bun ToastBun()
        {
            Console.WriteLine("putting bun in the toaster", Console.ForegroundColor = ConsoleColor.Yellow);
            Task.Delay(4000).Wait();
            Console.WriteLine("Bun pops", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
            return new Bun();
        }
        //Async Toast Bun
        public async Task<Bun> ToastBunAsync()
        {
            Console.WriteLine("putting bun in the toaster", Console.ForegroundColor = ConsoleColor.Yellow);
            await Task.Delay(4000);
            Console.WriteLine("Bun pops", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
            return new Bun();
        }

        //Asemble Burger
        public Burger AssembleBurger()
        {
            Console.WriteLine("Assembling Burger");
            Console.WriteLine("Putting Burger on Plate");
            Console.WriteLine("Putting Fries on Plate");

            return new Burger();
        }
    }
}
