using System;
using System.Collections.Generic;
using Lab_1_Linq.Class;
using Lab_1_Linq.Enums;

namespace Lab_1_Linq
{
   public class ContentData : IContentData

    {
      
        
        public IEnumerable<Car> Cars => new List<Car>()
        {
        new Car() {Id=1,Brand=CarBrand.BMW,Model="M5",BodyType=CarBodyType.sedan,VIN="1231413432",Manufacturer="Germany",Year=2010,Color=CarColor.Black,LicensePlate="АМ1234КМ",TechnicalCondition=CarTechinacalCondition.After_the_crash,owner=owner1},
        new Car() {Id=2,Brand=CarBrand.Audi,Model="A34",BodyType=CarBodyType.univercsal,VIN="2343413432",Manufacturer="Germany",Year=2009,Color=CarColor.White,LicensePlate="АМ3243КП",TechnicalCondition=CarTechinacalCondition.New,owner=owner2},
        new Car() {Id=3,Brand=CarBrand.Bugatti,Model="Veyron",BodyType=CarBodyType.univercsal,VIN="7568765467",Manufacturer="France",Year=2008,Color=CarColor.Green,LicensePlate="АК7777НВ",TechnicalCondition=CarTechinacalCondition.Working,owner=owner3},
        new Car() {Id=4,Brand=CarBrand.Opel,Model="R3",BodyType=CarBodyType.sedan,VIN="1232973332",Manufacturer="France",Year=2017,Color=CarColor.Grey,LicensePlate="АК1534АС",TechnicalCondition=CarTechinacalCondition.After_the_crash,owner=owner4},
        new Car() {Id=5,Brand=CarBrand.Tayota,Model="G5",BodyType=CarBodyType.sedan,VIN="3457213432",Manufacturer="Japan",Year=2015,Color=CarColor.Black,LicensePlate="АП2343НА",TechnicalCondition=CarTechinacalCondition.After_the_crash,owner=owner5},
        new Car() {Id=6,Brand=CarBrand.BMW,Model="M435",BodyType=CarBodyType.hatchback,VIN="5263748368",Manufacturer="Germany",Year=2012,Color=CarColor.White,LicensePlate="КМ3243ТР",TechnicalCondition=CarTechinacalCondition.New,owner=owner6},
        new Car() {Id=7,Brand=CarBrand.Tayota,Model="M12",BodyType=CarBodyType.hatchback,VIN="0423943432",Manufacturer="Japan",Year=2013,Color=CarColor.Black,LicensePlate="АЕ2342РС",TechnicalCondition=CarTechinacalCondition.Working,owner=owner7}
        };

        private Owner owner1 = new Owner() 
        {
            Id = 1,
            LastName = "Поліщук",
            FirstName = "Віктор",
            MiddleName = "Вікторович",
            DateOfBirth = new DateTime(2004, 3, 2),
            DriverLicenseNumber = "23123123432",
            RegistrationAddress = "Шевченка 45А"
        };
        private Owner owner2 = new Owner() 
        {
            Id = 2,
            LastName = "Нікітіна",
            FirstName = "Наталія",
            MiddleName = "Юріївна",
            DateOfBirth = new DateTime(2002, 4, 12),
            DriverLicenseNumber = "31229887932",
            RegistrationAddress = "Сарни 12"
        };
        private Owner owner3 = new Owner() 
        {
            Id = 3,
            LastName = "Паламарчук",
            FirstName = "Дмитро",
            MiddleName = "Васильович",
            DateOfBirth = new DateTime(2000, 1, 22),
            DriverLicenseNumber = "56765543545",
            RegistrationAddress = "Котляревського 4А"
        };

        private Owner owner4 = new Owner()
        {
            Id = 4,
            LastName = "Поліщук",
            FirstName = "Степан",
            MiddleName = "Стенпанович",
            DateOfBirth = new DateTime(1998, 3, 23),
            DriverLicenseNumber = "96786574565",
            RegistrationAddress = "Мічурина 7"
        };

        private Owner owner5 = new Owner()
        {
            Id = 5,
            LastName = "Стефанюк",
            FirstName = "Віктор",
            MiddleName = "Денисович",
            DateOfBirth = new DateTime(1994, 6, 23),
            DriverLicenseNumber = "96796756756",
            RegistrationAddress = "Шевченка 45/А"
        };

        private Owner owner6 = new Owner()
        {
            Id = 6,
            LastName = "Кулінар",
            FirstName = "Євген",
            MiddleName = "Вікторович",
            DateOfBirth = new DateTime(2004, 7, 14),
            DriverLicenseNumber = "85676456453",
            RegistrationAddress = "Каневського 32"

        };
        private Owner owner7 = new Owner()
        {
            Id = 7,
            LastName = "Мозайчук",
            FirstName = "Микита",
            MiddleName = "Артемович",
            DateOfBirth = new DateTime(2002, 7, 13),
            DriverLicenseNumber = "96885463452",
            RegistrationAddress = "Коростенщина 36А"
        };
        private Owner owner8 = new Owner()
        {
            Id = 8,
            LastName = "Малярчук",
            FirstName = "Андрій",
            MiddleName = "Артемович",
            DateOfBirth = new DateTime(2004, 8, 8),
            DriverLicenseNumber = "64756354544",
            RegistrationAddress = "Мічурина 7"
        };
        private Owner owner9 = new Owner()
        {
            Id = 9,
            LastName = "Мазуренко",
            FirstName = "Дмитро",
            MiddleName = "Олександрович",
            DateOfBirth = new DateTime(2000, 11, 5),
            DriverLicenseNumber = "34563456765",
            RegistrationAddress = "Шевченка 45А"
        };

        public IEnumerable<Owner> Owners => new List<Owner>()
        {
           owner1,owner2,owner3,owner4,owner5,owner6,owner7,owner8,owner9
        };



        public IEnumerable<Registration> Registrations => new List<Registration>
        {
             new Registration(){Id=1, RegistrationDate=new DateTime(2020,5,23) ,CarId=1,OwnerId=1},
             new Registration(){Id=2, RegistrationDate=new DateTime(2015,7,1) ,CarId=2,OwnerId=2},
             new Registration(){Id=3, RegistrationDate=new DateTime(2016,6,2) ,CarId=3,OwnerId=3},
             new Registration(){Id=4, RegistrationDate=new DateTime(2018,1,3) ,CarId=4,OwnerId=4},
             new Registration(){Id=5, RegistrationDate=new DateTime(2019,12,12) ,CarId=5,OwnerId=5},
             new Registration(){Id=6, RegistrationDate=new DateTime(2021,11,10) ,CarId=6,OwnerId=6},
             new Registration(){Id=7, RegistrationDate=new DateTime(2022,1,11) ,CarId=7,OwnerId=7},
             new Registration(){Id=8, RegistrationDate=new DateTime(2019,10,12) ,CarId=3,OwnerId=8},
             new Registration(){Id=9, RegistrationDate=new DateTime(2018,9,10) ,CarId=6,OwnerId=8},
             new Registration(){Id=10,RegistrationDate=new DateTime(2014,7,9),CarId=1,OwnerId=3},
             new Registration(){Id=11,RegistrationDate=new DateTime(2012,6,8),CarId=2,OwnerId=9},
             new Registration(){Id=12,RegistrationDate=new DateTime(2011,5,7),CarId=2,OwnerId=3},
             new Registration(){Id=13,RegistrationDate=new DateTime(2017,3,6),CarId=3,OwnerId=4},
             new Registration(){Id=14,RegistrationDate=new DateTime(2016,2,5),CarId=5,OwnerId=9},
        };
       
        public IEnumerable<Driver> Drivers => new List<Driver> 
        {
            new Driver(){Id=1,LastName="Василенко",FirstName="Андрій",MiddleName="Вікторович" , DateOfBirth=new DateTime(1993,7,2), DriverLicenseNumber= "47367485737", RegistrationAddress="Шевченка 45А"},
            new Driver(){Id=2,LastName="Андрієнко",FirstName="Андрій",MiddleName="Михайлович" , DateOfBirth=new DateTime(2001,4,12), DriverLicenseNumber="32445225532", RegistrationAddress="Сарни 12"},
            new Driver(){Id=3,LastName="Гуцілюк",FirstName="Михайло",MiddleName="Степанович" , DateOfBirth=new DateTime(2003,1,22), DriverLicenseNumber= "23432423443", RegistrationAddress="Котляревського 4А"},
            new Driver(){Id=4,LastName="Білошицький",FirstName="Олег",MiddleName="Дмитриєвич" , DateOfBirth=new DateTime(1998,3,23), DriverLicenseNumber="67456553665", RegistrationAddress="Мічурина 7"},
            new Driver(){Id=5,LastName="Степаненко",FirstName="Олександр",MiddleName="Денисович" , DateOfBirth=new DateTime(1994,6,23), DriverLicenseNumber="35345435345", RegistrationAddress="Шевченка 45/А"},
            new Driver(){Id=6,LastName="Прокопюк",FirstName="Віктор",MiddleName="Макарович" , DateOfBirth=new DateTime(2004,7,14), DriverLicenseNumber=  "45345345534", RegistrationAddress="Каневського 32"},
            new Driver(){Id=7,LastName="Ярошовець",FirstName="Євген",MiddleName="Олегович" , DateOfBirth=new DateTime(2002,7,13), DriverLicenseNumber=   "85767463457", RegistrationAddress="Коростенщина 36А"},
            new Driver(){Id=8,LastName="Берчук",FirstName="Олексій",MiddleName="Артемович" , DateOfBirth=new DateTime(2004,8,8), DriverLicenseNumber=    "97897888888", RegistrationAddress="Мічурина 7"},
            new Driver(){Id=9,LastName="Білецький",FirstName="Захар",MiddleName="Олександрович" , DateOfBirth=new DateTime(2000,11,5), DriverLicenseNumber="89789897897", RegistrationAddress="Шевченка 45А"},
        };

        public IEnumerable<DriversCar> DriversCars => new List<DriversCar>
        {

            new DriversCar(){Id=1,DriverId=1,CarId=1},
            new DriversCar(){Id=2,DriverId=2,CarId=2},
            new DriversCar(){Id=3,DriverId=3,CarId=3},
            new DriversCar(){Id=4,DriverId=4,CarId=4},
            new DriversCar(){Id=5,DriverId=5,CarId=5},
            new DriversCar(){Id=6,DriverId=6,CarId=6},
            new DriversCar(){Id=7,DriverId=7,CarId=7},
            new DriversCar(){Id=8,DriverId=8,CarId=4},
            new DriversCar(){Id=9,DriverId=9,CarId=3},
        };

       

        public  void AddToCollection(IEnumerable<Car> car, IEnumerable<Driver> drivers, IEnumerable<DriversCar> driverscars)
        {
            
            foreach (var item in car)
            {
                item.Drivers = new List<Driver>();
                foreach (var item2 in driverscars)
                {
                    if (item.Id==item2.CarId) 
                    {
                        foreach (var item3 in drivers)
                        {
                            if (item2.DriverId == item3.Id)
                            {
                                
                                item.Drivers.Add(item3);
                            }

                        }
                    }

                }   
            }
        }
    }
}
