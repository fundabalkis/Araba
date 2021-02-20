using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class // T sadece class tipinde olabilir diye sınırlandırıyoruz. Başka bir veri tipi gömderilemesin.
    {
        void add(T entity);

        List<T> GetById(int Id); //Örneğin Id'si 1 olan arabanın özelliklerini gönder. Burda car tipinde istedik. Void'de bi dönüş yok.

        List<T> GetAll(Expression<Func<T, bool>> filter = null); //listeleme yapıyor. Geriye dönüş var. Tüm araç bilgileri.

        void Update(T entity); // ekle güncelle sil sadece işlem

        void delete(T entity);
    
   }
}
