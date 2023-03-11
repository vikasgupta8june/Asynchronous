using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    public class Person
    {
        // add await for non-blocking API calls or use task.run for cpu bound process i.e; parallel
        public static async Task<string> CookBreakFast()
        {
            Console.WriteLine("Cooking started at " + DateTime.Now);
            // add await for non-blocking API calls or use task.run for cpu bound process i.e; parallel
            await Task.Delay(2000);
            Console.WriteLine("Cooking done at " + DateTime.Now);
            return "Pizza";
        }

        public static async Task EatBreakFast(string foodToEat)
        {
            Console.WriteLine("I have started eating " + foodToEat + " at " + DateTime.Now);
            await Task.Delay(1000);
            //thread.sleep blocks current thread ..task.delay non blocking
            Console.WriteLine("Finished my breakfast at " + DateTime.Now);
            Console.WriteLine();
        }

        public static async Task Excercise()
        {
            Console.WriteLine("Excercise started at " + DateTime.Now);
            await Task.Delay(0);
            Console.WriteLine("Excercise done at " + DateTime.Now);
            Console.WriteLine();
        }

        public static async Task AttendMeeting()
        {
            Console.WriteLine("Meeting started at " + DateTime.Now);
            await Task.Delay(0);
            Console.WriteLine("Meeting done at " + DateTime.Now);
            Console.WriteLine();
        }
    }
}
