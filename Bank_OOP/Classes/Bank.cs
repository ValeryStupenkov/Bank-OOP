using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bank_OOP.Classes
{
    public class Bank
    {
        // Количество клерков
        int N;

        // Макс.возможная длина очереди
        int K;

        // Очередь заявок
        public Queue<Request> requestsQueue = new Queue<Request>();

        // Массив брабатываемых заявок
        public Request?[] handlingRequests;

        // Максимальная длина очереди 
        public int maxQueueSize = 0;

        // Общая прибыль
        public int profit = 0;

        // Суммарное время ожидания для заявок
        public int allRequestTime = 0;

        // Методы
        // Конструктор
        public Bank(int n, int k)
        {
            N = n;
            K = k;
            handlingRequests = new Request?[N];
        }

        // Проверить, можно ли добавить заявку в очередь
        public bool CheckRequestQueue()
        {
            int newQueueSize = requestsQueue.Count() + 1;
            if (newQueueSize <= K)
            {
                if (newQueueSize > maxQueueSize)
                    maxQueueSize = newQueueSize;
                return true;
            }
            else
                return false;
        }

        public int UpdateHandlingList(int timeNewRequest)
        {
            int servedRequests = 0;
            foreach (var request in handlingRequests)
            {
                if (request != null)
                {
                    request.residue = request.servingTime - timeNewRequest;
                    request.servingTime = Math.Max(request.servingTime - timeNewRequest, 0);
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (handlingRequests[i] != null && handlingRequests[i].servingTime == 0)
                {
                    profit += handlingRequests[i].profit;
                    servedRequests++;
                    if (requestsQueue.Count() == 0)
                        handlingRequests[i] = null;
                    while (requestsQueue.Count() > 0)
                    {
                        var new_req = requestsQueue.Dequeue();
                        new_req.servingTime += handlingRequests[i].residue;
                        // Добавление времени ожидания одной заявки
                        allRequestTime += new_req.timeWaiting + Math.Abs(handlingRequests[i].residue);

                        handlingRequests[i] = new_req;
                        if (new_req.servingTime > 0)
                            break;
                        else
                        {
                            handlingRequests[i].residue = handlingRequests[i].servingTime;
                            profit += handlingRequests[i].profit;
                            servedRequests++;
                        }
                    }
                }
                else if (handlingRequests[i] == null)
                {
                    while (requestsQueue.Count() > 0)
                    {
                        var new_req = requestsQueue.Dequeue();
                        if (handlingRequests[i] != null)
                        {
                            new_req.servingTime += handlingRequests[i].residue;
                            // Добавление времени ожидания одной заявки
                            allRequestTime += new_req.timeWaiting + Math.Abs(handlingRequests[i].residue);
                        }

                        handlingRequests[i] = new_req;
                        if (new_req.servingTime > 0)
                            break;
                        else
                        {
                            handlingRequests[i].residue = handlingRequests[i].servingTime;
                            profit += handlingRequests[i].profit;
                            servedRequests++;
                        }
                    }
                }
            }
            return servedRequests;

        }

        public void UpdateTimeWaiting(int timeToAdd)
        {
            foreach (var request in requestsQueue)
            {
                request.timeWaiting += timeToAdd;
            }
        }

        public double GetClerksBusyness()
        {
            int busyClerks = 0;
            for (int i=0; i < N; i++)
            {
                if (handlingRequests[i] != null)
                    busyClerks++;
            }
            return busyClerks/N;
        }

        public int[] GetHandlingRequests()
        {
            int[] ids = new int[N];
            for (int i=0; i < N; i++)
            {
                if (handlingRequests[i] != null)
                    ids[i] = handlingRequests[i].id;
                else
                    ids[i] = 0;
            }

            return ids;
        }
    }
}
