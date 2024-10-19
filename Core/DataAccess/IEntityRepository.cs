using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //where ve sonrası generic constraint. sadece IEntity olan referans tipler T yerine kullanılabilir demek. Ama IEntity kullanamaz çünkü newlenebilir olmalı şartını koyduk ve
    //interfaceler newlenemez.
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        // içindeki yapı tüm datalar adına managerda linq sorguları yazabilmemizi sağlar. filtre vermeyedebilir tüm datayı istiyo demektir.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        // tek bir datanın detayları için, filtre zorunlu
        T Get(Expression<Func<T, bool>> filter);


        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
