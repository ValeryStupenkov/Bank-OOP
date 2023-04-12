using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_OOP.Classes
{
    public class Bank
    {
        // Количество клерков
        int N;

        // Макс. длина очереди
        int K;

        // Список клерков
        public List<Clerk> clerks;

        // Очередь заявок
        public List<Request> requests = new List<Request>();


        // Методы
        // Конструктор
        public Bank(int n, int k)
        {
            N = n;
            for (int i=0; i<n; i++)
            {
                clerks.Add(new Clerk(i));
            }
        }

        // Передать заявку клерку
        public bool HandleRequest(Request request)
        {
            int newQueueSize = requests.Count() + 1;
            if (newQueueSize < K)
            {
                requests.Add(request);
                return true;
            }
            else
                return false;
        }

        public void DeleteTheEnd()
        {

        }
    }
}
