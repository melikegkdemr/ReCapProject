using Business.Abstarct;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine("Model eklenmiştir");

        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Model silinmiştir.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b=> b.Id == brandId );
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
