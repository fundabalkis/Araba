using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal   //ICarDal daki metotları burda doldurup gerçekleştiricez
    {
        public void add(Car entity)
        {
            using (RentaCarContext context = new RentaCarContext () ) // context sınıfına bağlandık.CarContext içinde de veritabanına bağlandık.
            {
                if(entity.Description.Length >2 && entity.DailyPrice > 0)
                {
                 var AddedEntity = context.Entry(entity); //context içine ekleme, ekleyeeğim şeyde tanımladığım örn car nesnesi tipinde entity(repositoryden gelen)
                 AddedEntity.State = EntityState.Added; //ekledik
                 context.SaveChanges(); //veritabanına kaydettik
                }
                else
                {
                    Console.WriteLine("Description 2 karakterden büyük olmalı ve günlük fiyat 0'dan farklı!");
                }
                
            }
        }

        public void delete(Car entity)
        {
            throw new NotImplementedException();
        }

    
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
