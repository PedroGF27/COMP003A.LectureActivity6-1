using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_1
{
    /// <summary>
    /// Respresents a car
    /// </summary>
    class Car : Vehicle
    {
        // Auto-Implemented properties
        public int Doors { get; set; }

        /// <summary>
        /// Cunstructs car with brand, year, and number of doors
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="year"></param>
        /// <param name="doors"></param>
        public Car(string brand, int year, int doors)
        {
            Brand = brand;
            Year = year;
            Doors = doors;
        }

        /// <summary>
        /// Displayes car details
        /// </summary>
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doors: {Doors}");
        }
    }
}
