using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Additional_task
{
    class Newspaper : Printed_matter
    {
        /// <summary>
        /// Auto. fields
        /// </summary>
        public int Circulation { get; set; }
        public double Price { get; set; }
        /// <summary>
        /// Constructors
        /// </summary>
        public Newspaper() { }
        public Newspaper(string name, int circulation, double price)
        {
            Name = name; Circulation = circulation; Price = price;
        }
        /// <summary>
        /// Input
        /// </summary>
        /// <returns>New Newspaper</returns>
        public static Newspaper Input()
        {
            Write("Enter the name: ");
            string name = ReadLine();
            Write("Enter the circulation: ");
            int circulation = Convert.ToInt32(ReadLine());
            Write("Enter the price for one: ");
            double price = Convert.ToDouble(ReadLine());
            return new Newspaper(name, circulation, price);
        }
        /// <summary>
        /// Overriden calculating cost
        /// </summary>
        /// <returns>Price for all</returns>
        public override double Cost() => Circulation * Price;
        /// <summary>
        /// Overriden output
        /// </summary>
        public override void Output() => WriteLine($"Name: {Name}\nCirculation: {Circulation}\nPrice for one: {Price}\nPrice for all: {Cost()}");
    }
}
