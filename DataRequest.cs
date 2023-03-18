using Lab_1_Linq.Class;
using Lab_1_Linq.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using static Lab_1_Linq.ClassesForRequest.ClassForRequest;

namespace Lab_1_Linq
{
    class DataRequest : IDataRequest
    {
        private IContentData _dataContent;
        public DataRequest(IContentData dataContent)
        {
            _dataContent = dataContent;
        }
        // dont concat
        public double AvarageCarYear()
        {
            return _dataContent.Cars.Average(x => x.Year);
        }
        
        public IEnumerable<OwneCarYearRegistration> FindRegestrationInDate(int year1, int year2 )
        {
            return from registration in _dataContent.Registrations
                   join owner in _dataContent.Owners on registration.OwnerId equals owner.Id
                   join car in _dataContent.Cars on registration.CarId equals car.Id
                   where registration.RegistrationDate.Year >= year1 && registration.RegistrationDate.Year <= year2
                   select new OwneCarYearRegistration { Car = car, Owner = owner, YearRegistartion = registration.RegistrationDate.Year };


        }

        
        public IEnumerable<OwneCar> GetAllOwnerCar(string vin )
        {
            return from registration in _dataContent.Registrations
                   join owner in _dataContent.Owners on registration.OwnerId equals owner.Id
                   join car in _dataContent.Cars on registration.CarId equals car.Id
                   where car.VIN == vin
                   select new OwneCar { Car = car, Owner = owner };
        }

        

        public IEnumerable<Car> GetCarsAfterYears(int year )
        {
            return _dataContent.Cars.Where(x => x.Year > year);
        }

        public IEnumerable<Car> GetCarsBrand(CarBrand brand)
        {

            return _dataContent.Cars.Where(x => x.Brand == brand);
        }

        public IEnumerable<Driver> GetDriverForLastName(string partLastName)
        {
            return _dataContent.Drivers.Where(x => x.LastName.Contains(partLastName));
        }

        public IEnumerable<OwnerWithDateRegistration> GetOwnerCar()
        {
            return from registration in _dataContent.Registrations
                   join owner in _dataContent.Owners on registration.OwnerId equals owner.Id
                   join car in _dataContent.Cars on registration.CarId equals car.Id
                   orderby car.Brand,car.Model,registration.RegistrationDate
                   select new OwnerWithDateRegistration { Car = car, Owner = owner,Dateof=registration.RegistrationDate };
        }

        public IEnumerable<ValueDriverCar> GroupDriverOwnerCar()
        {
            return _dataContent.Cars.GroupJoin(_dataContent.DriversCars, x => x.Id, y => y.CarId, (car, driver) => new ValueDriverCar { Car=car,ValueDriver= driver.Count() });
        }
        

        public IEnumerable<Car> GetSortCarsTypeColor(CarBodyType type , CarColor color )
        {

            return _dataContent.Cars.Where(x => x.Color == color && x.BodyType == type).OrderBy(x => x.Brand);


        }

        public int GetYoungestOwner()
        {
            return _dataContent.Owners.Max(x => x.DateOfBirth.Year);
        }



        public IEnumerable<IGrouping<CarTechinacalCondition, Car>> GroupCarManufacture()
        {
            return _dataContent.Cars.GroupBy(x => x.TechnicalCondition);
        }

        public IEnumerable<Car> SortAllCars()
        {
            return _dataContent.Cars.OrderBy(x => x.Brand);
        }

        public IEnumerable<Car> SortCarTechnicalCondition(CarTechinacalCondition tech)
        {
            return _dataContent.Cars.Where(x => x.TechnicalCondition == tech).OrderByDescending(x => x.Brand).ThenByDescending(x => x.Model);
        }

        public IEnumerable<Owner> UseSkip(int index )
        {
            return _dataContent.Owners.Skip(index);
        }

        public IEnumerable<Driver> GetDriverNotRegistrationAddres(string reg)
        {
            return _dataContent.Drivers.Where(x => x.RegistrationAddress != reg);
        }
        
     

        public Driver GetOldesDriver()
        {
            return _dataContent.Drivers.OrderBy(x => x.DateOfBirth).FirstOrDefault();
        }

        public Owner UseElementAt(int index)
        {
            return _dataContent.Owners.ElementAt(index);
        }

        public int ValueCarManufacture(string country)
        {
            return _dataContent.Cars.Count(x => x.Manufacturer == country);
        }

        public bool GetOwnerForCondition(int lenght)
        {
            return _dataContent.Owners.All(x => x.DriverLicenseNumber.Length == lenght);
        }

        public IEnumerable<string> GetLicenseNumber()
        {
            return _dataContent.Drivers.Select(x => x.DriverLicenseNumber).Concat(_dataContent.Owners.Select(x => x.DriverLicenseNumber)).Distinct();
        }
    }
}
