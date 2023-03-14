using Lab_1_Linq.Enums;
using System;

namespace Lab_1_Linq
{
    class DataLogic : IDataLogic
    {
        private IDataRequest _dataRequest;
        public DataLogic(IDataRequest dataRequest)
        {
            _dataRequest = dataRequest;
        }

        public void AvarageCarYear()
        {
            var cars = _dataRequest.AvarageCarYear();
            Message.WriteMassage(ConsoleColor.DarkCyan, "Avarage. Вивести середній рік виготовлення машин");
            Console.WriteLine($"  {cars} \n");
        }
        
        public void FindRegestrationInDate()
        {
            const int  year1= 2015;
            const int year2 = 2016;
            var reg = _dataRequest.FindRegestrationInDate(year1, year2);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Фільтрація. Вивести всі регістрації у проміжку з {year1} по {year2}");
            foreach (var item in reg)
            {
                Console.WriteLine($"  {item.Owner} - {item.Car}  registration in {item.DateRegistration}");
            }

        }

        public void GetAllOwnerCar()
        {
            const string vin = "5263748368";
            var ownercar = _dataRequest.GetAllOwnerCar(vin);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Фільтрація. Вивести всіх власників машини за VIN - {vin} ");
            foreach (var item in ownercar)
            {
                Console.WriteLine($"   {item.Car} - {item.Owner} ");
            }
      
        }

        public void GetCarsAfterYears()
        {
            const int year = 2016;
            var cars = _dataRequest.GetCarsAfterYears(year);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Фільтрація. Вивести всі машини виготовленні після - {year} ");
            foreach (var item in cars)
            {
                Console.WriteLine($"  {item.Brand}  {item.Model} - {item.Year} року ");
            }
        }

        public void GetCarsBrand()
        {
            const CarBrand brand = CarBrand.BMW;
            var cars = _dataRequest.GetCarsBrand(brand);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Фільтрація.Вивести всі зареєстровані машини бренду {brand} ");
            foreach (var item in cars)
            {
                Console.WriteLine($"  {item.Brand}  {item.Model}  {item.VIN}");
            }

        }

        public void GetDriverForLastName()
        {
            const string partLastName = "Біл";
            var driver = _dataRequest.GetDriverForLastName(partLastName);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Отримати колекцію водіїв у яких призвіще має частину `{partLastName}` ");
            foreach (var item in driver)
            {
                Console.WriteLine($"  {item.LastName} {item.FirstName} {item.MiddleName}");
            }
        }

        public void GetOwnerCar()
        {
            var ownercar = _dataRequest.GetOwnerCar();
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Фільтрація та сортування. Вивести всі реєстрації  ");
            foreach (var item in ownercar)
            {
                Console.WriteLine($"  {item.Owner} - {item.Car} registration {item.DateRegistration}");

            }
        }

       public void GroupDriverOwnerCar()
        {
            var group = _dataRequest.GroupDriverOwnerCar();
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Використання GroupJoin. Вивести машини та кількість водіїв , які мають право водити її  ");
            foreach (var item in group)
            {
                if (item.ValueDriver == 1)
                {
                    Console.WriteLine($"  { item.Car} має право водити { item.ValueDriver} людина ");
                }
                else
                {
                    Console.WriteLine($"  { item.Car} має право водити { item.ValueDriver} людей ");
                }
            }
        }

        public void GetSortCarsTypeColor()
        {
            const CarBodyType body = CarBodyType.sedan;
            const CarColor color = CarColor.Black;
            var cars = _dataRequest.GetSortCarsTypeColor(body,color);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Фільтрація та сортування . Вивести всі машини типу {body} та кольору {color} ");
            foreach (var item in cars)
            {
                Console.WriteLine($"  {item.Brand} {item.Model}");
            }
        }

        public void GetYoungestOwner()
        {
            var yearsOwner = _dataRequest.GetYoungestOwner();
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Використання Max. Вивести рік наймолодшого власника ");
            Console.WriteLine($"  {yearsOwner}");
        }

        public void GroupCarManufacture()
        {
            var cars = _dataRequest.GroupCarManufacture();
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Використання Group. Отримати групу машин за технічним станом.  ");
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var item1 in item)
                {
                    Console.WriteLine($"  {item1.Brand} {item1.Model}");
                }
            }
        }

        public void SortAllCars()
        {
            var cars = _dataRequest.SortAllCars();
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Сортирування. Отримати відсортовану колекцію машин ");
            foreach (var item in cars)
            {
                Console.WriteLine($" {item.Brand} {item.Model}");
            }

        }

        public void SortCarTechnicalCondition()
        {
            const CarTechinacalCondition tech= CarTechinacalCondition.After_the_crash;
            var cars = _dataRequest.SortCarTechnicalCondition(tech);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Сортування та фільтрація. Вивести всі машини станом {tech} ");
            foreach (var item in cars)
            {
                Console.WriteLine($" {item.Brand} {item.Model} ");
            }
        }

        public void UseSkip()
        {
            const int index = 2;
            var owners = _dataRequest.UseSkip(index);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Використання Skip. Вивести всю колекцію починаю з {index} індексу ");
            foreach (var item in owners)
            {
                Console.WriteLine($" {item}");
            }
        }

        public void GetDriverNotRegistrationAddres()
        {
            const string ad = "Бандери";
            var drivers = _dataRequest.GetDriverNotRegistrationAddres(ad);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Фільтрація. Вивести всіх водіїв які реєструвалися НЕ за адресою {ad} ");
            foreach (var item in drivers)
            {
                Console.WriteLine($"  {item.LastName}  {item.FirstName} - {item.RegistrationAddress}");

            }
        }

        public void GetCarsForCondition()
        {
            const string word = "АМ";
            var car = _dataRequest.GetCarsForCondition(word);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Використання Any. Перевірити чи є хоча б одна машина з номерним знаком {word} ");
            Console.WriteLine(car);
            if (car==true)
            {
                Console.WriteLine($"  В реєстрі є хоча б одна машини з номером {word}");
            }
            else
            {
                Console.WriteLine($"  В реєстрі немає машини з номером {word}");
            }
        }

        public void GetOldesDriver()
        {
            var driver = _dataRequest.GetOldesDriver();
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Використання FirstOrDefaul. Вивести найстаршого водія  ");
            Console.WriteLine($"  {driver} -{driver.DateOfBirth} ");
        }

        public void UseElementAt()
        {
            const int index = 3;
            var owner = _dataRequest.UseElementAt(index);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Використання ElementAt. Вивести власника за {index} індексом  ");
            Console.WriteLine($" {owner}");

        }

        public void ValueCarManufacture()
        {
            const string country = "Germany";
            var car = _dataRequest.ValueCarManufacture(country);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Використання Count. Вивести кількість машин виготовлених  в {country} ");
            Console.WriteLine(car);
            if (car > 0)
            {
                Console.WriteLine($"  Всього {car} машин виготовлено в {country}");
            }
            else
            {
                Console.WriteLine($"  Нажаль, в реєстрі {car} машин виготовлено в {country}");
            }
        }

        public void GetOwnerForCondition()
        {
            const int lenght = 11;

            var owner = _dataRequest.GetOwnerForCondition(lenght);
            Message.WriteMassage(ConsoleColor.DarkCyan, $"Використання All.Перевірити чи у всіх власників номер водія підлягає правильності?   ");
            Console.WriteLine(owner);
            if (owner == true)
            {
                Console.WriteLine(" У всіх власників  правильні водійські номера");
            }
            else
            {
                Console.WriteLine(" У когось з власників не коректно введені данні");
            }
        }
    }
}
