using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService 
    {
        //GetCarsByBrandId , GetCarsByColorId servislerini yazınız.

        void add(Car car);

        List<Car> GetById(int Id); 

        List<Car> GetAll();

        void Update(Car car);

        void delete(Car car);

        List<Car> GetCarsByBrandId(int brandId);

        List<Car> GetCarsByColorId(int colorId);

    }
}
