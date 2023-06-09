using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Context.Task1
{
    public class CarImplementation : ICar
    {
        private Traffic_PoliceContext context;
        public CarImplementation(Traffic_PoliceContext context)
        {
            this.context = context;
        }
        public void AddCar(Car car) 
        {
            context.Cars.Add(car);
            context.SaveChanges();
        }
        public void DeleteCar(Car car) 
        {
            context.Cars.Remove(car);
            context.SaveChanges();
        }
        public void ChangeCar(Car car, string NewPlateNumber, Driver NewDriver)
        {
            car.PlateNumber = NewPlateNumber;
            car.Driver = NewDriver;
            context.SaveChanges();
        }
    }
}
