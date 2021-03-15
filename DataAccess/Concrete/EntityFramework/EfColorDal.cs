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
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarDataBaseContext>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            using(RentACarDataBaseContext context = new RentACarDataBaseContext())
            {
                var result = from color in context.Colors
                             join colorDetail in context.ColorDetails
                             on color.Id equals colorDetail.ColorId
                             select new ColorDetailDto
                             {
                                 Description = colorDetail.Description,
                                 Name = color.Name
                             };
                return result.ToList();
            }
        }
    }
}
