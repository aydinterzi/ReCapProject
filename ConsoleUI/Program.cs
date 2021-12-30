
using Entities.Concrete;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager=new BrandManager(new EfBrandDal());
ColorManager colorManager=new ColorManager(new EfColorDal());
brandManager.Add(new Brand { Id = 1, Name = "Reno" });
brandManager.Add(new Brand { Id = 2, Name = "Reno" });
brandManager.Add(new Brand { Id = 3, Name = "Merco" });
colorManager.Add(new Color { Id = 1, Name = "Blue" });
colorManager.Add(new Color { Id = 2, Name = "Red" });
colorManager.Add(new Color { Id = 3, Name = "Grey" });
foreach (var item in carManager.GetCarDetails())
{
    Console.WriteLine(item.CarName+" "+item.ColorName+" "+item.BrandName);
}