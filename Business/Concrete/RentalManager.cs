using Business.Abstract;
using Core.Ultities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult AddRental(Rental rental)
        {
            var isRanted = _rentalDal.Get(r => r.ReturnDate == null && r.Id == rental.CarId);
            if(isRanted!=null)
            {
                return new ErrorResult("kiralanamadı");
            }
            _rentalDal.Add(rental);
            return new SuccessResult("Eklendi");
        }

        public IResult DeleteRental(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAllRentals()
        {
            var rentallist=_rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(rentallist);
        }

        public IDataResult<Rental> GetRantalById(int rentalId)
        {
            var rental = _rentalDal.Get(P=>P.Id==rentalId);
            return new SuccessDataResult<Rental>(rental);
        }

        public IResult UpdateRental(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
