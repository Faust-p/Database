using Lab6.Context;
using Lab6.Context.Task1;
using Lab6.Context.Task2;
using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver()
            {
                LicenseNumber = "12345678",
                FirstName = "Denis",
                LastName = "Ostap",
                PhoneNumber = "77998822",
                Adress = "Street Dr.",
                Category = DriverViolationCategory.Absent
            };

            var penaltyPoints = new PenaltyPoints()
            {
                Date = DateTime.Now,
                Points = 5
            };

            using (var db = new Traffic_PoliceContext())
            {
                var driverImplementation = new DriverImplementation(db);

                driverImplementation.AddDriver(driver);
                driver.PenaltiesPoints.Add(penaltyPoints);
                driverImplementation.DeleteDriver(driver);
                driver.PenaltiesPoints.Remove(penaltyPoints);
            }
        }
    }
}
