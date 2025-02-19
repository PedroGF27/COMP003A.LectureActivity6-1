using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_1
{
    /// <summary>
    /// Represent vehicle
    /// </summary>
    class Vehicle
    {
        // Fields
        private string _brand;

        // properties
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int  Year { get; set; }

        /// <summary>
        /// Display vehicle details.
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Year: {Year}");
        }
    }
}
