using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionTestMyHazimIn160420190453pm
{
    class Program
    {
        struct std
        {
            string name;
            int d1;
            int d2;
            int d3;
            double av;

            public void Funinput(string n,int s1,int s2,int s3)
            {
                name = n;
                d1 = s1;
                d2 = s2;
                d3 = s3;
                av = (d1 + d2 + d3) / 3;
                               
            }
            public void funPrint()
            {
                Console.WriteLine("_________________ Student__________________");
                Console.WriteLine("name: "+ name);
                Console.WriteLine("mark1: "+ d1);
                Console.WriteLine("mark2: "+ d2);
                Console.WriteLine("mark3: "+ d3);
                Console.WriteLine("Averag:"+ av);
                Console.WriteLine("___________________________________________");
            }
        }

        static void Main(string[] args)
        {
            // define two var for two recored
            std fstd = new std();
            std sstd = new std();
            // Call function "Funinput" for read values .
            fstd.Funinput("ali", 49, 38, 47);
            sstd.Funinput("walied", 50, 45, 42);
            // print values by  function "funprint" .
            fstd.funPrint();
            sstd.funPrint();

            Console.ReadKey();
        }
    }
}
