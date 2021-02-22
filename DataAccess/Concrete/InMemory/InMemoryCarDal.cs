using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2010"
                ,DailyPrice = 200000, Description = "Dark Black BMW",  },
                new Car{Id = 2, BrandId = 2, ColorId = 3, ModelYear = "2012"
                ,DailyPrice = 500000, Description = "White Mercedes",  },
                new Car{Id = 3, BrandId = 1, ColorId = 4, ModelYear = "2014"
                ,DailyPrice = 350000, Description = "Ocean Blue BMW",  },
                new Car{Id = 4, BrandId = 3, ColorId = 5, ModelYear = "2014"
                ,DailyPrice = 1000000, Description = "Silver Maserati",  }
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
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        
    }
}
