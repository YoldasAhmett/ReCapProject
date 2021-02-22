using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //Business classların içinde sakın newleme yapma.
        ICarDal _carDal;
        public CarManager(ICarDal cardal)
        {
            _carDal = cardal;
        }

        public void Add(Car car)
        {
            //İş kodları buraya yazılır.
            //Yetkisi var mı? gibi...
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int BrandId)
        {
            return _carDal.GetById(BrandId);
        }
    }
}
