using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService : IBaseOperationsService<Brand>
    {
        List<Brand> GetAll();
        Brand Get(int id);
    }
}
