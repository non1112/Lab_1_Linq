
using System.Collections.Generic;
using Lab_1_Linq.Class;


namespace Lab_1_Linq
{
    interface IContentData
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Owner> Owners { get; }

        IEnumerable<Registration> Registrations { get; }

        IEnumerable<Driver> Drivers { get; }

        IEnumerable<DriversCar> DriversCars { get;}
    }
}
