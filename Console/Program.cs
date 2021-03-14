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
            //carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 200, Description = "Otomatik Benzin", ModelYear = 2017 });
            //carManager.Add(new Car { BrandId = 2, ColorId = 1, DailyPrice = 500, Description = "ikinci el", ModelYear = 2018 });

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { Name = "Tesla" });
            //brandManager.Add(new Brand { Name = "Audi" });


            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { Name = "Turuncu" });
            //colorManager.Add(new Color { Name = "Mor" });

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

             var rentStation1 = rentalManager.Add(new Rental { CarId = 1, CustomerId = 2, RentDate = new DateTime(2021,02,12), ReturnDate = new DateTime(2021,03,12) });

            Console.WriteLine(rentStation1.Message);
            

            var rentStation2 = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 03, 10) });

            Console.WriteLine(rentStation2.Message);
            
            

             rentalManager.Add(new Rental { CarId = 2, CustomerId = 3, RentDate = new DateTime(2021, 03, 11) });
            



            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetUserDetailDto();

            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName + ">>" + user.CompanyName);
                }
            }




            //var result = carManager.GetCarDetails();

            //if (result.Success)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.CarName + "/" + car.BrandName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            


        }



    }
}
