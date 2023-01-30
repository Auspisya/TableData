using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableData.Models
{
    class Table
    {
        private int Number;
        private int MaxPlaces;
        private int FreePlaces;

        public Table(int number, int maxPlaces)
        {
            Number = number;
            MaxPlaces = maxPlaces;
            FreePlaces = maxPlaces;
        }

        public void ShowInfo() => Console.WriteLine($"Стол {Number}. Свободно мест {FreePlaces} из {MaxPlaces}.");

        #region Допфункции
        public bool Reserve(int places)
        {
            if (FreePlaces >= places)
            {
                FreePlaces -= places;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TakeOffReserve(int places)
        {
            if (places >= FreePlaces && places <= MaxPlaces)
            {
                FreePlaces += places;
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
