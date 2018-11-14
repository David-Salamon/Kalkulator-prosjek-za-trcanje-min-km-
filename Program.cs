using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double minute=37, sekunde=49;
            int distance = 10;

            var time1 = TimeSpan.FromMinutes(minute);
            var time2 = TimeSpan.FromSeconds(sekunde);
            var time12 = time1 + time2;
            var time3 = new TimeSpan(time12.Ticks / distance);

            //ispisuje Ukupno vrijeme
            Console.WriteLine( "Ukupno vrijeme je-> {0}", time12.ToString(@"mm\:ss"));

            //Ispisuje prosjek minuta po kilometru
            Console.WriteLine("Prosjek po kilometru je-> {0}", time3.ToString(@"mm\:ss"));
        }
        

    }
}
