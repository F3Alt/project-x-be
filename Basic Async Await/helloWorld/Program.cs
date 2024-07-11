/* using System;


namespace helloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld(); //method call
            // Console.WriteLine("Hello, World!") // direct printing
            
        }


        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello, world!");

        }
    }

    
}
*/


using System;
using System.Threading.Tasks;

namespace helloWorld
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Greeter greeter = new Greeter();
            greeter.SayHello();
            await Task.Delay(2000);
            greeter.SayGoodbye();
        }
    }
    /* The Main method is marked as async because it contains await operations(await Task.Delay).
It returns Task instead of void to indicate it's an asynchronous entry point. */


    public class Greeter
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye, World!");
        }
    }
}
