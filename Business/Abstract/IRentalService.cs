﻿using Core.Ultities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAllRentals();
        IResult AddRental(Rental rental);
        IResult UpdateRental(Rental rental);
        IResult DeleteRental(Rental rental);
        IDataResult<Rental> GetRantalById(int rentalId);
    }
}
