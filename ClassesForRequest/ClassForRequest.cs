using Lab_1_Linq.Class;
using System;

namespace Lab_1_Linq.ClassesForRequest
{
    class ClassForRequest
    {
      

        public class OwneCar
        {
            public Car Car { get; set; }
            public Owner Owner { get; set; }

        }
        public class OwnerWithDateRegistration : OwneCar
        {
            public DateTime Dateof { get; set; }
        }

        public class OwneCarYearRegistration : OwneCar
        {
            public int YearRegistartion { get; set; }

        }
        public class ValueDriverCar
        {
            public int ValueDriver { get; set; }
            public Car Car { get; set; }
        }
    
    }
}
