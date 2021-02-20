using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void add(Color entity)
        {
            using (RentaCarContext context = new RentaCarContext()) // context sınıfına bağlandık.CarContext içinde de veritabanına bağlandık.
            {
                var AddedEntity = context.Entry(entity); //context içine ekleme, ekleyeeğim şeyde tanımladığım örn car nesnesi tipinde entity(repositoryden gelen)
                AddedEntity.State = EntityState.Added; //ekledik
                context.SaveChanges(); //veritabanına kaydettik
            }
        }

        public void delete(Color entity)
        {
            using (RentaCarContext context = new RentaCarContext()) // context sınıfına bağlandık.CarContext içinde de veritabanına bağlandık.
            {
                var DeletedEntity = context.Entry(entity); //context içine ekleme, ekleyeeğim şeyde tanımladığım örn car nesnesi tipinde entity(repositoryden gelen)
                DeletedEntity.State = EntityState.Deleted; //ekledik
                context.SaveChanges(); //veritabanına kaydettik
            }
        }

       
        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
