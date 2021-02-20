using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void add(Brand entity)
        {
            using (RentaCarContext context = new RentaCarContext()) // context sınıfına bağlandık.CarContext içinde de veritabanına bağlandık.
            {
                var AddedEntity = context.Entry(entity); //context içine ekleme, ekleyeeğim şeyde tanımladığım örn car nesnesi tipinde entity(repositoryden gelen)
                AddedEntity.State = EntityState.Added; //ekledik
                context.SaveChanges(); //veritabanına kaydettik
            }
        }
            public void delete(Brand entity)
        {
            using (RentaCarContext context = new RentaCarContext()) // context sınıfına bağlandık.CarContext içinde de veritabanına bağlandık.
            {
                var DeletedEntity = context.Entry(entity); //context içine ekleme, ekleyeeğim şeyde tanımladığım örn car nesnesi tipinde entity(repositoryden gelen)
                DeletedEntity.State = EntityState.Deleted; //ekledik
                context.SaveChanges(); //veritabanına kaydettik
            }
        }

        

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public List<Brand> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
