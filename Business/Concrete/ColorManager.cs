using Business.Abstarct;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            return new SuccessResult("Renk eklendi");
        }

        public IResult Delete(Color color)
        {
            return new SuccessResult("Renk eklendi");
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colordId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c=> c.Id == colordId));
        }

        public IResult Update(Color color)
        {
            return new SuccessResult("Renk eklendi");
        }
    }
}
