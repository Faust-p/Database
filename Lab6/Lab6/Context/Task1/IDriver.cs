using Lab6.Context.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Context.Task1
{
    public  interface IDriver
    {
        void AddDriver(Driver driver);
        void DeleteDriver(Driver driver);
        void ChangeDriver(Driver driver, string NewLicenseNumber, string NewFirstName, string NewLastName, string NewPhoneNumber, string NewAdress, DriverViolationCategory NewCategory);
    }
}
