using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBranchingPractice
{
    internal abstract class Vehicle
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int TopSpeed { get; set; }

        public virtual void Go()
        {
            Console.WriteLine($"{Name} is going");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"{Name} has stopped");
        }
    }
}
