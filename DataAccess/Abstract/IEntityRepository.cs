﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraint 
    //class : referans tip
    //Ientity : IEntity veya IEntity implemente eden bir nesne olabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Filtre = null, filtre vermeyedebilirsin demektir.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
