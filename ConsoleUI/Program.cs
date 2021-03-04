using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            List<Car> cars = carManager1.GetAll();

            Console.WriteLine("Tüm arabaları gösterdik: \n");
            foreach (Car car in carManager1.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.DailyPrice + " " + car.ModelYear);
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Verilen bilgilerle yeni arabamızı ekledik.\n");
            //carManager1.Add(new Car
            //{
            //    Id = 6,
            //    BrandId = 5,
            //    ColorId = 5,
            //    ModelYear = "2017",
            //    DailyPrice = 5500000,
            //    Description = "Ferrari 488 GTB Silver"
            //});

            //Id' si 5 olan arabayı sildik tablomuzdan. Bu komut bir kere çalıştığında sildiği için 2. defa denersek çalışmaz.
            //carManager1.Delete(new Car { Id = 6});

            //Id'si 3 olan arabayı güncelledik.
            carManager1.Update(new Car { Id = 3, DailyPrice = 600000, Description = "Mercedes beyaz" });

            foreach (Car car in carManager1.GetAll())
            {
                Console.WriteLine(car.Description + " | " + car.DailyPrice + " | " + car.ModelYear);
            }
            Console.WriteLine("---------------------------");

            ////Console.WriteLine("Araba Id' sine göre araba bilgilerini sildik.\n");
            ////carManager1.Delete(new Car { Id = 2 });

            //foreach (Car car in carManager1.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //Console.WriteLine("---------------------------");

            Console.WriteLine("Güncellemek istediğimiz ürünün bilgilerini gönderdik." +
                "Eğer Id doğruysa verilen bilgilerle ilgili güncelleme yapılacak. Aksi halde yapılamayacaktır.\n");
            carManager1.Update(new Car
            {
                Id = 3,
                BrandId = 4,
                ColorId = 2,
                DailyPrice = 1000000,
                Description = "Tesla Model S",
                ModelYear = "2012"
            });

            foreach (Car car in carManager1.GetAll())
            {
                Console.WriteLine(car.Description + "\n" + car.DailyPrice + "\n" + car.ModelYear);
            }

            CarManager carManager2 = new CarManager(new EfCarDal());

            foreach (var car in carManager2.GetCarsByBrandId(1))
            {
                Console.WriteLine("BrandId: {0} Description: {1}", car.BrandId, car.Description);
            }

            Console.WriteLine("------------------------Dto Kullandık.--------------------");
            foreach (var carDetail in carManager2.GetCarDetails())
            {
                Console.WriteLine(carDetail.CarName + " / " + carDetail.BrandName +
                    " / " + carDetail.ColorName + " / " + carDetail.DailyPrice);
            }
        }
    }
}
