using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>() {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=50000,Description="BMW M5",ModelYear=2018},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=10000,Description="BMW M3",ModelYear=2002},
                new Car{Id=3,BrandId=1,ColorId=2,DailyPrice=50000,Description="BMW M5",ModelYear=2017},
                new Car{Id=4,BrandId=1,ColorId=3,DailyPrice=30000,Description="BMW M4",ModelYear=2015},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
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
    }
}
