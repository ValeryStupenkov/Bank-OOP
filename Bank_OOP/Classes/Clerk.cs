using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_OOP.Classes
{
    public class Clerk
    {
        // Номер клерка
        public int id;

        // Статус
        public bool free;

        // Методы
        // Конструктор
        public Clerk(int id)
        {
            this.id = id;
        }

        // Обработать заявку
        public void HandleClient(int requestId)
        {

        }
    }
}
