using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetByDailyPrice(int min);
        List<CarDetailDto> GetCarDetails();

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
