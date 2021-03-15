using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandDetailId = 1, ColorDetailId = 1, ModelYear = "2010"
                ,DailyPrice = 200000, DetailedDescription = "Dark Black BMW",  },
                new Car{Id = 2, BrandDetailId = 2, ColorDetailId = 3, ModelYear = "2012"
                ,DailyPrice = 500000, DetailedDescription = "White Mercedes",  },
                new Car{Id = 3, BrandDetailId = 1, ColorDetailId = 4, ModelYear = "2014"
                ,DailyPrice = 350000, DetailedDescription = "Ocean Blue BMW",  },
                new Car{Id = 4, BrandDetailId = 3, ColorDetailId = 5, ModelYear = "2014"
                ,DailyPrice = 1000000, DetailedDescription = "Silver Maserati",  }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandDetailId = car.BrandDetailId;
            carToUpdate.ColorDetailId = car.ColorDetailId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.DetailedDescription = car.DetailedDescription;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandDetailId == BrandId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
