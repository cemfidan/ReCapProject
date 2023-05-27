using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            _cars = new List<Car>()
                {
                    new Car {CarId = 1, CarName = "Nissan Micra", BrandId = 1, ColorId = 1, ModelYear = 2018, DailyPrice = 23, Description = "Lorem ipsum dolor sit amet"},
                    new Car {CarId = 2, CarName = "Peugeot 2008", BrandId = 1, ColorId = 3, ModelYear = 2022, DailyPrice = 65, Description = "Lorem ipsum dolor sit amet"},
                    new Car {CarId = 3, CarName = "Fiat Egea", BrandId = 2, ColorId = 2, ModelYear = 2015, DailyPrice = 20, Description = "Lorem ipsum dolor sit amet"},
                    new Car {CarId = 4, CarName = "Opel Insignia", BrandId = 3, ColorId = 4, ModelYear = 2022, DailyPrice = 92, Description = "Lorem ipsum dolor sit amet"},
                    new Car {CarId = 5, CarName = "Skoda Scala", BrandId = 4, ColorId = 4, ModelYear = 2017, DailyPrice = 40, Description = "Lorem ipsum dolor sit amet"}
                };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
