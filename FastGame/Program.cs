using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Click Enter, to start!");
            Console.ReadLine();
            Console.WriteLine("Complete!");
            Console.WriteLine("Click Enter again, as soon as 'GO' appears!."); /*як тільки з'явиться ГО натискайте Enter*/
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();
            while (true)
            {
                Console.ReadLine();
                Console.Clear();
                int delay = random.Next(1000, 3000);
                System.Threading.Thread.Sleep(delay);
                Console.WriteLine("GO!");
                stopwatch.Restart();
                Console.ReadKey();
                stopwatch.Stop();
                Console.WriteLine($"Your reaction time: {stopwatch.ElapsedMilliseconds} ms");
                Console.WriteLine("Click Enter, to start again, or 'q' for Exit.");
                var key = Console.ReadKey(true);
                if (key.KeyChar == 'q')
                    break;
                Console.Clear();
            }
        }
    }
}