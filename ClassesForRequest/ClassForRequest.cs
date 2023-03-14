using Lab_1_Linq.Class;


namespace Lab_1_Linq.ClassesForRequest
{
    class ClassForRequest
    {
        public class OwneCar1<T>
        {
            public Car Car { get; set; }
            public Owner Owner { get; set; }
            public T DateRegistration { get; set; }
        }

        public class OwneCar
        {
            public Car Car { get; set; }
            public Owner Owner { get; set; }
            public string RegistrationAddress { get; set; }


        }
        public class ValueDriverCar
        {
            public int ValueDriver { get; set; }
            public Car Car { get; set; }


        }
    }
}
