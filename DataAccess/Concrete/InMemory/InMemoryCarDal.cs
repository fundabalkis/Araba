using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //constructorda ekliyoruz ki memoryde çağırınca eklensin

        public InMemoryCarDal()
        {
            _cars = new List<Car>
                {
                    new Car
                    {
                        Id = 1, BrandId = 3, ColorId =7, DailyPrice=800, Description = "RangeRover", ModelYear = 2010
                    },new Car
                    {
                        Id = 2, BrandId = 5, ColorId =10, DailyPrice=500, Description = "Cıvıc", ModelYear = 2018
                    }
                };

        }
        public void add(Car car)
        {
            _cars.Add(car);
        }

        public void delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id); //singleordefault bu idye ait tek bir değer gönder.c'lerin Idsine bak.
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id); //singleordefault bu idye ait tek bir değer gönder.c'lerin Idsine bak.
            carUpdate.Id = car.Id;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            
        }
    }
}
