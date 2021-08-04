
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{


    //Generic Constraint
    // class: referans tip olabilir 
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı çünkü IEntity newlenemez interface olduğu için 
    //ARTIK SİSTEMİMİZ SADECE VERİTABANI NESNELERİYELE ÇALIŞAN REPOSİTOR OLDU 
   public interface IEntityRepository<T> where T:class , IEntity,new() // REFERANS TİP OLMASI GEREKİR ve IEntity olabilir yada IEntityden implementesinden olması gerekiyor
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);


        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
