using Business.Abstarct;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public List<Car> GetAll()
        {
            //iş kodları yazılır
            // iş kodlarını geçiyorsa veri erişimi çağırmam lazım bunun için de constructor oluşturdum.

            return _iCarDal.GetAll();
            
        }
    }
}
