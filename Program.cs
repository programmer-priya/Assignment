using System;
using System.Threading.Tasks;

namespace AssignmentApp
{
    class Program
    {
        //here we create two method which is not depend on each other.
        
            static void Main(string[] args)
            {
                Method1();
                Method2();
                Console.ReadKey();
            }
// Here we use async method so that method2 will not wait for complition of method1. the return type of this method is Task
            public static async Task Method1()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(" Method 1");
                        // Do something
                        Task.Delay(100).Wait();
                    }
                });
            }


            public static void Method2()
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine(" Method 2");
                    // Do something
                    Task.Delay(100).Wait();
                }
            }
        
    }
}
