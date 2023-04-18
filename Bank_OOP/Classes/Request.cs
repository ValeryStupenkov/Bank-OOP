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

        // Остаток времени на текущем шаге
        public int residue;

        // Время ожидания в очереди
        public int timeWaiting = 0;

        // Методы
        public Request(int id, int servingTime, int profit)
        {
            this.id = id;
            this.servingTime = servingTime;
            this.profit = profit;
        }
    }

}
