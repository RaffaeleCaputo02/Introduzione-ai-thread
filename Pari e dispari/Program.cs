using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pari_e_dispari
{
    class Program
    {
        static void Main(string[] args)
        {
            //VisualizzaDispari();
            //Console.WriteLine();
            //VisualizzaPari();

            Task.Factory.StartNew(VisualizzaDispari);
            Task.Factory.StartNew(VisualizzaPari);

            Console.ReadLine();
        }

        public static void VisualizzaPari()
        {
          
            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+" ");
                    Console.WriteLine($"Il thread corrente è {Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }

        public static void VisualizzaDispari()
        {
            for(int i=0;i<200;i++)
            {
                if(i%2==1)
                {
                    Console.Write (i+" ");
                    Console.WriteLine($"Il thread corrente è {Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }
    }
}
