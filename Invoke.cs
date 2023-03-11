using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    public class Invoke
    {
        public async Task Run()
        {
            //StopWatch start
            Stopwatch sw = Stopwatch.StartNew();

            //Initial thread count
            Console.WriteLine("Total thread count at start:" + Process.GetCurrentProcess().Threads.Count);
            Console.WriteLine();

            Console.WriteLine("Tasks starts at:" + DateTime.Now);
            Task<string> task1 = Person.CookBreakFast();
            Task task2 = Person.Excercise();

            await Task.WhenAll(task1, task2);
            Task task3 = Person.EatBreakFast(await task1);
            //Task task3 = Person.EatBreakFast(task1.Result);

            Task task4 = Person.AttendMeeting();
            await Task.WhenAll(task3, task4);
            Console.WriteLine("Tasks ends at:" + DateTime.Now);

            //Final thread count
            Console.WriteLine("Total thread count at end:" + Process.GetCurrentProcess().Threads.Count);

            sw.Stop();
            Console.WriteLine();
            //StopWatch end
            Console.WriteLine("Total time taken:" + sw.Elapsed);
        }
               
    }
}
