using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService : IBaseOperationsService<Color>
    {
        List<Color> GetAll();
        Color Get(int id);
    }
}
