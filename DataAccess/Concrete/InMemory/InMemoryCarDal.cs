using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; // >> öncelikle liste oluşturduk - global değişken 
        public InMemoryCarDal()  // >>ctor bellekte referans aldığı zaman çalışacak olan blok
        {
            _cars = new List<Car> 
            {
                new Car{Id = 1,BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = 2010, Description= "2. el"},
                new Car{Id = 2,BrandId = 2, ColorId = 2, DailyPrice = 500, ModelYear = 2019, Description= "Galeriden"},
                new Car{Id = 3,BrandId = 3, ColorId = 2, DailyPrice = 250, ModelYear = 2020, Description= "Galeriden"}

            };
        }

        

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LİNQ 
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id );
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.Id = car.Id;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.Description = car.Description;

        }
    }
}
