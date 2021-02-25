using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRulesService<T> where T : class
    {
        void MinNameRule(T entity);
        void MinPriceRule(T entity);
    }
}
