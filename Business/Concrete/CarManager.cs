using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService //data access'e bağlanıp ordaki metotları çalıştıracağız. InMemoryCarDal'dan dolan ICarDal ile.
    {

        ICarDal _carDal; //dataaccess işlemleri çağırma

        public CarManager(ICarDal carDal) //InMemory'ye göre veya Entity'e göre ??
        {
            _carDal = carDal;
        }
        public void add(Car car)
        {
            _carDal.add(car);
        }

        public void delete(Car car)
        {
            _carDal.delete(car); //dataaccess'deki fonksiyonları çağırıyoruz.
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int Id)
        {
            return _carDal.GetById(Id);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
