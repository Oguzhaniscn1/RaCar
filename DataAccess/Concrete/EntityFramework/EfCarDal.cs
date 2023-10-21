using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RaCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(RaCarContext context = new RaCarContext())
            {
                var result = from c in context.Cars
                             from a in context.Colors
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 ColorName=a.ColorName,
                                 DailyPrice=c.DailyPrice,
                                 BrandName=b.BrandName,
                             };
                return result.ToList();
            }
        }
    }
}
