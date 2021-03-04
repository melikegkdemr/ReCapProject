using Business.Abstarct;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //SOLİD >> O harfi 
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public void Add(Car car)
        {
            _iCarDal.Add(car);
            Console.WriteLine("Eklendi!");
            
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            //iş kodları yazılır
            // iş kodlarını geçiyorsa veri erişimi çağırmam lazım bunun için de constructor oluşturdum.

            return _iCarDal.GetAll();
            
        }

        public List<Car> GetByDailyPrice(int min)
        {
            return _iCarDal.GetAll(p=> p.DailyPrice>= min);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _iCarDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _iCarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _iCarDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
        }
    }
}
