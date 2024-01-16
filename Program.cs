using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 120);
            Car Volvo = new Car("XC-90");

            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
            Ford.fullThrottle();
           
            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Opel.year);
            Opel.fullThrottle();

            Console.Read();
            
        }
       

}   }
