using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_OOP.Classes
{
    public class Request
    {
        // Номер заявки
        public int id;

        // Длительность обслуживания в мин.
        public int servingTime;

        // Прибыль банка от заявки
        public int profit;

        // Статус заявки
        public RequestStatus status;

        public int timeUntilEnd;

        // Методы
        public Request(int servingTime, int profit)
        {
            this.servingTime = servingTime;
            this.profit = profit;
        }
    }

    public enum RequestStatus 
    {

    }

}
