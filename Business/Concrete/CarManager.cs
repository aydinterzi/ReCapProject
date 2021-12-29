using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public void Add(Car car)
        {
            if(car.Description.Length>2 && car.DailyPrice>0)
            {
                _iCarDal.Add(car);
                Console.WriteLine("araba eklendi.");
            }
            else
            {
                Console.WriteLine("araba eklenemez");
            }
            
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();             
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _iCarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _iCarDal.GetAll(c => c.ColorId == id);
        }
    }
}
