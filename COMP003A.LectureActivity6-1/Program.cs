// Pedro Garcia
// COMP003A
// Jonathan Cruz
// 
namespace COMP003A.LectureActivity6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create vehicle with brand and year
            Vehicle myVehicle = new Vehicle() { Brand = "Toyota", Year = 2020 };
            // Create A Car with brand, year, and number of doors
            Car myCar = new Car("Honda", 2022, 4);
            // Display vehicle and car details.
            myVehicle.DisplayInfo();
            myCar.DisplayInfo();
            
        }
    }
}
