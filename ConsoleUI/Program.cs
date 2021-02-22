using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            List<Car> cars = carManager.GetAll();

            Console.WriteLine("Tüm arabaları gösterdik: \n");
            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.DailyPrice + " " + car.ModelYear);
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Verilen Id' ye göre arabaların tanımını gösterdik.\n");
            foreach (Car car in carManager.GetById(1))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Verilen bilgilerle yeni arabamızı ekledik.\n");
            carManager.Add(new Car
            {
                Id = 5,
                BrandId = 5,
                ColorId = 5,
                ModelYear = "2017",
                DailyPrice = 5500000,
                Description = "Ferrari 488 GTB Silver"
            });

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " | " + car.DailyPrice + " | " + car.ModelYear);
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Araba Id' sine göre araba bilgilerini sildik.\n");
            carManager.Delete(new Car { Id = 2 });

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("---------------------------");

            Console.WriteLine("Güncellemek istediğimiz ürünün bilgilerini gönderdik." +
                "Eğer Id doğruysa verilen bilgilerle ilgili güncelleme yapılacak. Aksi halde yapılamayacaktır.\n");
            carManager.Update(new Car
            {
                Id = 3,
                BrandId = 4,
                ColorId = 2,
                DailyPrice = 1000000,
                Description = "Tesla Model S",
                ModelYear = "2012"
            });

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "\n" + car.DailyPrice + "\n" + car.ModelYear);
            }
        }
    }
}
