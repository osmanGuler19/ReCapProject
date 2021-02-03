using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId = 1,BrandId = 1,ColorId=1,DailyPrice=15000,Description = "2005 Model Opel Astra",ModelYear =2005},
                new Car{CarId = 2,BrandId = 2,ColorId=2,DailyPrice=30000,Description = "2010 Model Hyundai Getz",ModelYear =2010},
                new Car{CarId = 3,BrandId = 3,ColorId=3,DailyPrice=45000,Description = "2015 Model Fiat Egea",ModelYear =2015},
                new Car{CarId = 4,BrandId = 1,ColorId=4,DailyPrice=25000,Description = "2009 Model Opel Corsa",ModelYear =2009},
                new Car{CarId = 5,BrandId = 2,ColorId=5,DailyPrice=20000,Description = "2007 Model Opel Accord",ModelYear =2007}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c =>c.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId ==Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
