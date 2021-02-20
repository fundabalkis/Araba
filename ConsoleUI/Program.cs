using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal()); //veriyi nereden alacağım ?

            Car car = new Car();
            car.BrandId = 1;
            car.ColorId = 3;
            car.DailyPrice = 100000;
            car.Description = "Gıcır";
            car.ModelYear = 2020;
            car.Id = 1;

            carManager.add(car);

        }
    }
}
