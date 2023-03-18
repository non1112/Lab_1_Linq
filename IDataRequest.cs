using Lab_1_Linq.Class;
using Lab_1_Linq.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using static Lab_1_Linq.ClassesForRequest.ClassForRequest;


namespace Lab_1_Linq
{
    interface IDataRequest
    {
        IEnumerable<Car> GetCarsBrand(CarBrand brand );
        IEnumerable<Car> GetCarsAfterYears(int year);

        IEnumerable<Car> SortAllCars();
        IEnumerable<Car> GetSortCarsTypeColor(CarBodyType type , CarColor color );

        IEnumerable<IGrouping<CarTechinacalCondition, Car>> GroupCarManufacture();
        IEnumerable<Owner> UseSkip(int index);
        IEnumerable<OwnerWithDateRegistration> GetOwnerCar();

        IEnumerable<OwneCar> GetAllOwnerCar(string vin);

        double AvarageCarYear();

        IEnumerable<ValueDriverCar> GroupDriverOwnerCar();

        IEnumerable<OwneCarYearRegistration> FindRegestrationInDate(int year1,int year2);
        int GetYoungestOwner();
        IEnumerable<Driver> GetDriverForLastName(string partLastName);

        IEnumerable<Car> SortCarTechnicalCondition(CarTechinacalCondition tech);

        IEnumerable<Driver> GetDriverNotRegistrationAddres(string reg);

        IEnumerable<string> GetLicenseNumber();

        Driver GetOldesDriver();


        Owner UseElementAt(int index);

        int ValueCarManufacture(string country);

        bool GetOwnerForCondition(int lenght);
    }
}
