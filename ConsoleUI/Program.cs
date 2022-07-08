using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.CarId+" "+car.BrandId+" "+car.ColorId+" "+ car.ModelYear+" "+car.DailyPrice+" "+car.Description);
}
