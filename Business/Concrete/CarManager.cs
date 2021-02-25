using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IRulesService<IEntity> _rules;

        public CarManager(ICarDal carDal, IRulesService<IEntity> rules)
        {
            _carDal = carDal;
            _rules = rules;
        }

        public void Add(Car entity)
        {
            _rules.MinNameRule(entity);
            _rules.MinNameRule(entity);
            _carDal.Add(entity);
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> GetAll()
        {
            //İş kodları
            return _carDal.GetAll();
            
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId ==id);
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}
