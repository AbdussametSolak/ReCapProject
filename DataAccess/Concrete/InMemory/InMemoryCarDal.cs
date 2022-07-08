using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=1000, ModelYear=2015,Description="Sedan"},
                new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=700, ModelYear=2015,Description="Hatchbag"},
                new Car{CarId=3,BrandId=1,ColorId=3,DailyPrice=1200, ModelYear=2015,Description="Sedan"},
                new Car{CarId=4,BrandId=2,ColorId=4,DailyPrice=1600, ModelYear=2019,Description="Suv"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(x=>x.CarId==id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(x => x.CarId == car.CarId);
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.Description=car.Description;
        }
    }
}
