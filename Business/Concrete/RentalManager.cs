using Business.Abstarct;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }



        public IResult Add(Rental rental)
        {
            var results = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            foreach (var result in results)
            {
                if (result.ReturnDate == null || rental.RentDate < result.ReturnDate)
                {
                    return new ErrorResult("Ekleme başarısız");
                }
            }

            _rentalDal.Add(rental);
            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.CarId == rentalId));
        }

        public IResult Update(Rental rental)
        {
            return new SuccessResult();
        }
    }
}
