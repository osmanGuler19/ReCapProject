using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID prensipleri
    // O : Open closed principle
    class Program
    {
        static void Main(string[] args)
        {
            IRulesService<IEntity> rulesService = new RulesManager();

            //Id ler auto increment olduğu için id verilmez. Database artan sırada id'leri otomatik olarak atar
            Car car1 = new Car
            {
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 45,
                Description = "4 koltuk",
                ModelYear = 2010
            };
            Color color1 = new Color { Name = "Beyaz" };
            Brand brand1 = new Brand { Name = "Honda" };



            //IRulesService<Car> rulesService = (IRulesService<Car>)Activator.CreateInstance(typeof(IRulesService<Car>));
            ICarService carManager = new CarManager(new EfCarDal(), rulesService);
            IBrandService brandManager = new BrandManager(new EfBrandDal(), rulesService);
            IColorService colorManager = new ColorManager(new EfColorDal(),rulesService);
            //colorManager.Add(color1);
            //brandManager.Add(brand1);

            //carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }


            Console.ReadLine();
        }
    }
}
