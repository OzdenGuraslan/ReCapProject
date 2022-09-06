using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,ColorId=1,BrandId=1,ModelYear=2022,DailyPrice=10000,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 2 ve üzeri"},
                new Car{Id=2,ColorId=2,BrandId=2,ModelYear=2003,DailyPrice=500,Description="Manuel vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri"},
                new Car{Id=3,ColorId=2,BrandId=2,ModelYear=2017,DailyPrice=6000,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri"},
                new Car{Id=4,ColorId=5,BrandId=3,ModelYear=2018,DailyPrice=4000,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri"},
                new Car{Id=5,ColorId=3,BrandId=2,ModelYear=2010,DailyPrice=1000,Description="Manuel vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri"},
                new Car{Id=6,ColorId=5,BrandId=1,ModelYear=2019,DailyPrice=7000,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 2 ve üzeri"}
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
