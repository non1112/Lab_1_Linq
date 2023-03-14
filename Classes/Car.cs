using Lab_1_Linq.Enums;
using System.Collections.Generic;

namespace Lab_1_Linq.Class
{
     public class Car
    {
        public int Id { get; set; }
        public CarBrand Brand { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public CarBodyType BodyType { get; set; }
        public int Year { get; set; }
        public string VIN { get; set; }
        public CarColor Color { get; set; }
        public string LicensePlate { get; set; }
        public CarTechinacalCondition TechnicalCondition { get; set; }

        public Owner owner { get; set; }
        public List<Driver> Drivers { get; set; }
        public override string ToString()
        {
            return $"Авто: {Brand} {Model} VIN {VIN} ";
        }
    }
}
