using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        IRulesService<IEntity> _rules;

        public BrandManager(IBrandDal brandDal, IRulesService<IEntity> rules)
        {
            _brandDal = brandDal;
            _rules = rules;
        }

        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public void Delete(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public Brand Get(int id)
        {
            return _brandDal.Get(p=>p.Id==id);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
