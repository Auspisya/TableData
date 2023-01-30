using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableData.Models;

namespace TableData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpenCafe = true;

            Table[] tables =
            {
                new Table(1,4), //0
                new Table(2,7), //1
                new Table(3,10) //2
            };

                    //true
            while (isOpenCafe)
            {
                Console.WriteLine("Админ-панель");
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                #region Допфункции

                Console.Write("\nУслуги:");
                Console.Write("\n1.Забронировать стол.");
                Console.Write("\n2.Снять бронь со стола.");
                int firstService = 1;
                Console.Write("\nВведите цифру услуги:");
                if (firstService == Convert.ToInt32(Console.ReadLine())) {
                    Console.Write("\nВведите номер стола:");
                    int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.Write("\nВведите количество лиц для брони:");
                    int getPlaces = Convert.ToInt32(Console.ReadLine());

                    bool isReComplete = tables[wishTable].Reserve(getPlaces);

                    if (isReComplete) Console.WriteLine("Прошло успешно");
                    else Console.WriteLine("Бронь не прошла");

                    Console.ReadKey();
                    Console.Clear();
                } else { 
                    Console.Write("\nВведите номер стола:");
                    int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.Write("\nВведите количество лиц для снятия брони:");
                    int getPlaces = Convert.ToInt32(Console.ReadLine());

                    bool isReComplete = tables[wishTable].TakeOffReserve(getPlaces);

                    if (isReComplete) Console.WriteLine("Прошло успешно");
                    else Console.WriteLine("Снятие брони не прошло");

                    Console.ReadKey();
                    Console.Clear();
                
                }
                #endregion

            }
        }
    }
    
}
