
using Entities.Concrete;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
CarManager carManager = new CarManager(new EfCarDal());
carManager.Add(new Car {Id=5,DailyPrice=0,BrandId=3,ColorId=2,Description="güzel araba",ModelYear=2021 });

foreach (var item in carManager.GetAll())
{
    Console.WriteLine(item.Description);
}