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
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarDataBaseContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            using(RentACarDataBaseContext context = new RentACarDataBaseContext())
            {
                var result = from brand in context.Brands
                             join brandDetail in context.BrandModels
                             on brand.Id equals brandDetail.BrandId
                             select new BrandDetailDto
                             {
                                 Description = brandDetail.Description,
                                 Name = brand.Name
                             };
                return result.ToList();
            }
        }
    }
}
