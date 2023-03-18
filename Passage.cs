using System;
using System.Collections.Generic;

namespace Lab_1_Linq


//code smell switch refactoring guru
{
    delegate void function();
    class Passage : IPassage
    {
        private IDataOutput _dataOutput;
        public Passage(IDataOutput dataOutput)
        {
            _dataOutput = dataOutput;
        }

        public void Step()
        {
            var dictionary = new Dictionary<Comand, function>()
            {
               { Comand.GetCarsBrand ,()=>_dataOutput.GetCarsBrand() },
               { Comand.AvarageCarYear,() =>_dataOutput.AvarageCarYear() },
               { Comand.FindRegestrationInDate,()=> _dataOutput.FindRegestrationInDate() },
               { Comand.GetAllOwnerCar,()=>_dataOutput.GetAllOwnerCar()},
               { Comand.GetCarsAfterYears,()=>_dataOutput.GetCarsAfterYears()},
               { Comand.GetDriverForLastName,()=>_dataOutput.GetDriverForLastName() },
               { Comand.GetDriverNotRegistrationAddres ,() => _dataOutput.GetDriverNotRegistrationAddres() },
               { Comand.GetLicenseNumber,() =>_dataOutput.GetLicenseNumber() },
               { Comand.GetOldesDriver,()=> _dataOutput.GetOldesDriver() },
               { Comand.GetOwnerCar,()=>_dataOutput.GetOwnerCar()},
               { Comand.GetOwnerForCondition,()=>_dataOutput.GetOwnerForCondition()},
               { Comand.GetSortCarsTypeColor,()=>_dataOutput.GetSortCarsTypeColor() },
               { Comand.GetYoungestOwner,() => _dataOutput.GetYoungestOwner() },
               { Comand.GroupCarManufacture,() =>_dataOutput.GroupCarManufacture() },
               { Comand.GroupDriverOwnerCar,()=> _dataOutput.GroupDriverOwnerCar() },
               { Comand.SortAllCars,()=>_dataOutput.SortAllCars()},
               { Comand.SortCarTechnicalCondition,()=>_dataOutput.SortCarTechnicalCondition()},
               { Comand.UseElementAt,()=>_dataOutput.UseElementAt() },
               { Comand.UseSkip ,() => _dataOutput.UseSkip() },
               { Comand.ValueCarManufacture,() =>_dataOutput.ValueCarManufacture() },
               { Comand.Exit,() =>_dataOutput.Exit() },

           };
            Message.WriteMassage(ConsoleColor.DarkYellow, "Введіть номер запиту від 1-20. Для завершення програми напишіть 0. ");
            while (true)
            {
                string number = Console.ReadLine();
                if(Enum.TryParse(number,out Comand comand) && dictionary.ContainsKey(comand))
                {
                    dictionary[comand]();
                }
                else
                {
                    Message.WriteMassage(ConsoleColor.DarkRed, "НЕ вірно ведене число , введіть число від 1-20");
                }
            }
        }
    }
}
