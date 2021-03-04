using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Text;
using static System.Console;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car {BrandId = 1,ColorId = 2, DailyPrice = 200, Description = "Otomatik Benzin",ModelYear= 2017 });
            carManager.Add(new Car {BrandId = 2,ColorId = 1,DailyPrice = 500,Description = "ikinci el",ModelYear = 2018 });

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Name = "Tesla" });
            brandManager.Add(new Brand { Name = "Audi" });


            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Name = "Turuncu" });
            colorManager.Add(new Color { Name = "Mor" });

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName);
            }






            




        }

        

    }
}
