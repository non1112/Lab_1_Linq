using System;


namespace Lab_1_Linq
{
    class Passage : IPassage
    {
        private IDataLogic _dataLogic;
        public Passage(IDataLogic dataLogic)
        {
            _dataLogic = dataLogic;
        }

        public void Switch()
        {
            int a = 0;
            Message.WriteMassage(ConsoleColor.Green, "Введіть номер запиту (1-20) ");
            
            while (Int32.TryParse(Console.ReadLine(), out a))
            {

                if (a > 0 && a <= 20)
                {
                    switch (a)
                    {
                        case 1:
                            _dataLogic.AvarageCarYear();
                            break;
                        case 2:
                            _dataLogic.FindRegestrationInDate();
                            break;
                        case 3:
                            _dataLogic.GetAllOwnerCar();
                            break;
                        case 4:
                            _dataLogic.GetCarsAfterYears();
                            break;
                        case 5:
                            _dataLogic.GetCarsBrand();
                            break;
                        case 6:
                            _dataLogic.GetDriverForLastName();
                            break;
                        case 7:
                            _dataLogic.GetDriverNotRegistrationAddres();
                            break;
                        case 8:
                            _dataLogic.GetOwnerCar();
                            break;
                        case 9:
                            _dataLogic.GetSortCarsTypeColor();
                            break;
                        case 10:
                            _dataLogic.GetYoungestOwner();
                            break;
                        case 11:
                            _dataLogic.GroupCarManufacture();
                            break;
                        case 12:
                            _dataLogic.GroupDriverOwnerCar();
                            break;
                        case 13:
                            _dataLogic.SortAllCars();
                            break;
                        case 14:
                            _dataLogic.SortCarTechnicalCondition();
                            break;
                        case 15:
                            _dataLogic.UseSkip();
                            break;
                        case 16:
                            _dataLogic.UseElementAt();
                            break;
                        case 17:
                            _dataLogic.GetCarsForCondition();
                            break;
                        case 18:
                            _dataLogic.GetOldesDriver();
                            break;
                        case 19:
                            _dataLogic.GetOwnerForCondition();
                            break;
                        case 20:
                            _dataLogic.ValueCarManufacture();
                            break;

                    }
                }
                else
                { Message.WriteMassage(ConsoleColor.DarkRed, "Не коректний ввід даних.Введіть номер в проміжку 1 - 20"); }
            }
            
        }
    }
}
