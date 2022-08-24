using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // generic constaint = > interfacea verilerecek tipleri kısıtlamak
    //artık buraya int gibi değişken gönderemeyecek,
    // where T : class burada class olacak demek değil referans tip olabilir demek 
    //where T : class,IEntity   T REF tip olacak ve IEntity ve onu implement eden nesne olabilir demek
    //new() new'lenebilir olmalı demek. yani IEntity yi direk veremeyiz artık
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
