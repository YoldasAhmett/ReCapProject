using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarDataBaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarDataBaseContext context = new RentACarDataBaseContext())
            {
                var result = from car in context.Cars
                             join colorDetail in context.ColorDetails
                             on car.ColorDetailId equals colorDetail.Id
                             join brandModel in context.BrandModels
                             on car.BrandDetailId equals brandModel.Id
                             select new CarDetailDto
                             {
                                 BrandName = brandModel.Description,
                                 CarName = car.DetailedDescription,
                                 ColorName = colorDetail.Description,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
