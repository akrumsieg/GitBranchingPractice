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
        public string Color { get; set; }

        public virtual void Go()
        {
            Console.WriteLine("Vehicle is going");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle has stopped");
        }
    }
}
