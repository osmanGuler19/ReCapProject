using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBaseOperationsService<T> where T:class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
