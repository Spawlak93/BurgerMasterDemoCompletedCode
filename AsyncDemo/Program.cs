using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // BurgerMaster Class
            BurgerMaster burgerMaster = new BurgerMaster();
            //Creating Timer to track speed of application
            var timer = System.Diagnostics.Stopwatch.StartNew();

            //Syncronous code run
            Patty patty = burgerMaster.CookPatty();
            Console.WriteLine("Patty Done");
            Fries fries = burgerMaster.FryFries();
            Console.WriteLine("Fries Done");
            Bun bun = burgerMaster.ToastBun();
            Console.WriteLine("Bun Toasted");
            Produce produce = burgerMaster.ChopProduce();
            Console.WriteLine("Produce Chopped");
            Console.ResetColor();

            burgerMaster.AssembleBurger();
            Console.WriteLine("Burger Done");
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

            Console.ReadLine();

            timer.Restart();

            //Async Code run Syncronously
            patty = burgerMaster.CookPattyAsync().Result;
            Console.ResetColor();
            Console.WriteLine("Patty Done");
            fries = await burgerMaster.FryFriesAsync();
            Console.ResetColor();
            Console.WriteLine("Fries Done");
            bun = await burgerMaster.ToastBunAsync();
            Console.ResetColor();
            Console.WriteLine("Bun Toasted");
            produce = await burgerMaster.ChopProduceAsync();
            Console.ResetColor();
            Console.WriteLine("Produce Chopped");

            burgerMaster.AssembleBurger();
            Console.WriteLine("Burger Done");
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

            Console.ReadLine();

            //Async Code run Asyncronously
            timer.Restart();

            var pattyTask = burgerMaster.CookPattyAsync();
            var fryTask = burgerMaster.FryFriesAsync();
            var bunTask = burgerMaster.ToastBunAsync();
            var produceTask = burgerMaster.ChopProduceAsync();

            patty = await pattyTask;
            Console.ResetColor();
            Console.WriteLine("Patty Done");

            fries = await fryTask;
            Console.ResetColor();
            Console.WriteLine("Fries Done");

            bun = await bunTask;
            Console.ResetColor();
            Console.WriteLine("Bun Toasted");

            produce = await produceTask;
            Console.ResetColor();
            Console.WriteLine("Produce Chopped");

            burgerMaster.AssembleBurger();
            Console.WriteLine("Burger Done");
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

            Console.ReadLine();

            //Async Code run Asyncronously grouped (OPTIONAL)
            timer.Restart();

            var pattyTaskTwo = burgerMaster.CookPattyAsync();
            var fryTaskTwo = burgerMaster.FryFriesAsync();
            var bunTaskTwo = burgerMaster.ToastBunAsync();
            var produceTaskTwo = burgerMaster.ChopProduceAsync();

            Task.WhenAll(pattyTaskTwo, fryTaskTwo, bunTaskTwo, produceTaskTwo).Wait();

            Console.ResetColor();
            Console.WriteLine("Patty Done");
            Console.WriteLine("Fries Done");
            Console.WriteLine("Bun Toasted");
            Console.WriteLine("Produce Chopped");

            burgerMaster.AssembleBurger();
            Console.WriteLine("Burger Done");
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

            Console.ReadLine();


            //Async Code run Asyncronously grouped with individual outputs (also good for more than one burger) (OPTIONAL)
            //
            timer.Restart();

            var pattyTaskThree = burgerMaster.CookPattyAsync();
            var fryTaskThree = burgerMaster.FryFriesAsync();
            var bunTaskThree = burgerMaster.ToastBunAsync();
            var produceTaskThree = burgerMaster.ChopProduceAsync();

            List<Task> taskList = new List<Task>() { pattyTaskThree, fryTaskThree, bunTaskThree, produceTaskThree };

            while (taskList.Count > 0)
            {
                Task completedTask = await Task.WhenAny(taskList);
                if(completedTask.GetType() == typeof(Task<Patty>))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Patty Done");
                }
                if (completedTask.GetType() == typeof(Task<Fries>))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Fries Done");
                }
                if (completedTask.GetType() == typeof(Task<Bun>))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bun Done");
                }
                if (completedTask.GetType() == typeof(Task<Produce>))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Produce Done");
                }
                taskList.Remove(completedTask);
            }

            Console.ResetColor();
            Console.WriteLine("Patty Done");
            Console.WriteLine("Fries Done");
            Console.WriteLine("Bun Toasted");
            Console.WriteLine("Produce Chopped");

            burgerMaster.AssembleBurger();
            Console.WriteLine("Burger Done");
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}


