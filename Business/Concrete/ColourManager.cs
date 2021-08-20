using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;
        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }
        [ValidationAspect(typeof(ColourValidator))]
        [CacheRemoveAspect("IColourService.Get")]
        public IResult Add(Colour colour)
        {
            _colourDal.Add(colour);
            return new SuccessResult(Messages.ColourAdded);
        }

        public IResult Remove(Colour colour)
        {
            _colourDal.Remove(colour);
            return new SuccessResult(Messages.CarRemoved);
        }
        [CacheAspect]
        public IDataResult<List<Colour>> GetAll()
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll());
        }
        [CacheAspect]
        public IDataResult<Colour> GetById(int colourId)
        {
            return new SuccessDataResult<Colour>(_colourDal.Get(p => p.ColourId == colourId));
        }
        [CacheRemoveAspect("IColourService.Get")]
        public IResult Update(Colour colour)
        {
            _colourDal.Update(colour);
            return new SuccessResult(Messages.ColourUpdated);
        }

        public IResult AddTransactionalTest(Colour colour)
        {
            _colourDal.Update(colour);
            _colourDal.Add(colour);
            return new SuccessResult(Messages.ColourUpdated);
        }
    }
}
