using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Additional_task
{
    abstract class Printed_matter
    {
        /// <summary>
        /// Automatic properties
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Calculating cost
        /// </summary>
        /// <returns>Cost</returns>
        public abstract double Cost();
        /// <summary>
        /// Output
        /// </summary>
        public abstract void Output();
    }
}
