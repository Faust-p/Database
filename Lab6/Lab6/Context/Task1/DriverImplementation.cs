using Lab6.Context.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Context.Task1
{
    public class DriverImplementation : IDriver
    {
        private Traffic_PoliceContext context;
        public DriverImplementation(Traffic_PoliceContext context)
        {
            this.context = context;
        }
        public void  AddDriver(Driver driver)
        {
            context.Drivers.Add(driver);
            context.SaveChanges();
        }
        public void DeleteDriver(Driver driver) 
        {
            context.Drivers.Remove(driver);
            context.SaveChanges();
        }
        public void ChangeDriver(Driver driver, string NewLicenseNumber, string NewFirstName, string NewLastName, string NewPhoneNumber, string NewAdress, DriverViolationCategory NewCategory)
        {
            driver.LicenseNumber = NewLicenseNumber;
            driver.FirstName = NewFirstName;
            driver.LastName = NewLastName;
            driver.PhoneNumber = NewPhoneNumber;
            driver.Adress = NewAdress;
            driver.Category = NewCategory;
            context.SaveChanges();
        }
    }
}
