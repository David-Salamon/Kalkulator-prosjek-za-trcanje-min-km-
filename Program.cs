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
            double sati, minute, sekunde;
            int distance;

            Console.Write("Upisite sate: ");
            sati = Convert.ToDouble(Console.ReadLine());

            Console.Write("Upisite minute: ");
            minute = Convert.ToDouble(Console.ReadLine());

            Console.Write("Upisite sekunde: ");
            sekunde = Convert.ToDouble(Console.ReadLine());

            Console.Write("Upisite kilometre: ");
            distance = Convert.ToInt32(Console.ReadLine());


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
