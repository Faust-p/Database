using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Context.Task1
{
    public interface ICar
    {
        void AddCar(Car car);
        void DeleteCar(Car car);
        void ChangeCar(Car car, string NewPlateNumber, Driver NewDriver);
    }
}
