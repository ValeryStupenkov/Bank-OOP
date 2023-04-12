using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_OOP.Classes
{
    public class Model
    {
        const int daysInWeek = 7;

        // Прибыль от одной заявки
        int[] requestProfit = new int[2] { 50, 3000 };

        // Тип распределения случайных величин
        DistributionType distribution;

        // Текущее время, с типом определюсь в будущем
        int[] currentTime = new int[] { 1, 0, 0};

        // Параметры моделирования
        // Время между приходом клиентов (промежуток в мин.)
        int[] timeBetweenClients;

        // Время обслуживания клиентов (промежуток в мин.)
        int[] timeToHandleClients;

        // Кол-во клерков N
        int clerksCount;

        // Макс. возможная длина очереди K
        int queueLength;

        // Шаг моделирования в мин.
        int step;

        // Банк
        Bank bank;

        // Статистика
        // Кол-во обслуженных клиентов
        int servedClientsCount;

        // Кол-во потерянных клиентов
        int lostClientsCount;

        // Среднее время ожилания (в мин.)
        double avgWaitingTime;

        // Средняя занятость клерков
        double avgClerkBusyness;

        // Максимальная длина очереди за время работы
        int maxQueueLength;

        // Минимальная длина очереди за время работы
        int minQueueLength;

        // Средняя длина очереди за время работы
        int avgQueueLength;

        // Прибыль
        int profit;

        bool requestHaveSafeTime = false;

        int timeNewRequest;

        List<Request> requestsList = new List<Request>();
        
        List<Request> lostRequests = new List<Request>();

        // Методы
        // Конструктор
        public Model(int n, int k, int step, string distribution, int[] timeBetweenClients, int[] timeToHandleCLients) 
        {
            clerksCount = n;
            queueLength = k;
            this.step = step;
            if (distribution == DistributionType.Normal.ToString())
                this.distribution = DistributionType.Normal;
            else
                this.distribution = DistributionType.Uniform;
            this.timeBetweenClients = timeBetweenClients;
            this.timeToHandleClients = timeToHandleCLients;
            bank = new Bank(n, k);
        }

        // Добавление клиента в очередь
        private Request AddRequest()
        {
            int timeToServe;
            int profit;
            if (distribution == DistributionType.Uniform)
            {
                Random r = new Random();
                timeToServe = (int)(r.NextDouble() * (timeToHandleClients[1] - timeToHandleClients[0]) + timeToHandleClients[0]);
                profit = (int)(r.NextDouble() * (requestProfit[1] - requestProfit[0]) + requestProfit[0]);
            }
            else
            {
                NormalRandom r = new NormalRandom();
                timeToServe = (int)(r.NextDouble() * (timeToHandleClients[1] - timeToHandleClients[0]) + timeToHandleClients[0]);
                profit = (int)(r.NextDouble() * (requestProfit[1] - requestProfit[0]) + requestProfit[0]);
            }

            return new Request(timeToServe, profit);
        }

        

        // Шаг 
        public void Tick()
        {
            int curTimeInStep = 0;
            var timeInterval = GenerateTimeIntervalForNewRequest();
            var r = new Random();
            while (true)
            {
                if (!requestHaveSafeTime)
                {
                    timeNewRequest = timeInterval[0] + (int)(r.NextDouble() * (timeInterval[1] - timeInterval[0]));
                }
                requestHaveSafeTime = false;
                curTimeInStep += timeNewRequest;
                if (curTimeInStep > step)
                {
                    break;
                }
                UpdateTimeForRequest(timeNewRequest);
                bank.DeleteTheEnd();

                Request newRequest = AddRequest();
                if (bank.HandleRequest(newRequest))
                {
                    requestsList.Add(newRequest);
                }
                else
                {
                    newRequest.timeUntilEnd = 0;
                    lostRequests.Add(newRequest);
                }
            }

            UpdateTimeForRequest(timeNewRequest - (curTimeInStep - step));
            bank.DeleteTheEnd();
            requestHaveSafeTime = true;
            timeNewRequest = curTimeInStep - step;
            UpdateGlobalTime(step);

        }

        // Перейти к концу моделирования
        public void ToTheEnd()
        {
            var r = new Random();
            while (true)
            {
                int[] timeInterval = GenerateTimeIntervalForNewRequest();
                if (!requestHaveSafeTime)
                {
                    timeNewRequest = timeInterval[0] + (int)(r.NextDouble() * (timeInterval[1] - timeInterval[0]));
                }
                requestHaveSafeTime = false;
                UpdateGlobalTime(timeNewRequest);
                if (currentTime[0] > daysInWeek)
                {
                    break;
                }

                UpdateTimeForRequest(timeNewRequest);
                bank.DeleteTheEnd();

                Request newRequest = AddRequest();
                if (bank.HandleRequest(newRequest))
                {
                    requestsList.Add(newRequest);
                }
                else
                {
                    newRequest.timeUntilEnd = 0;
                    lostRequests.Add(newRequest);
                }
            }
            foreach (var request in requestsList)
            {
                request.timeUntilEnd = 0;
            }
        }

        private int IsWeekend()
        {
            if (currentTime[0] == 6 || currentTime[0] == 7)
            {
                return 1;
            }
            return 0;
        }

        private int IsTheTimeBetween16And22()
        {
            if (currentTime[1] >= 16 && currentTime[1] < 22)
            {
                return 1;
            }
            return 0;
        }

        private int[] GenerateTimeIntervalForNewRequest()
        {
            int forWeekend = 5;
            int forTheTimeBetween16And22 = 3;
            double avg = (timeBetweenClients[0] + timeBetweenClients[1]) / 2.0;
            double avg_in_minutes = 1.0 / avg;
            int fluxDensity = 100 - forWeekend * IsWeekend() + forTheTimeBetween16And22 * IsTheTimeBetween16And22();
            avg_in_minutes = avg_in_minutes * fluxDensity / 100.0;
            double new_avg = 1.0 / avg_in_minutes;
            return new int[] { Math.Abs((int)(new_avg - avg)), (int)(new_avg + avg) };
        }

        private void UpdateTimeForRequest(int timeNewRequest)
        {
            for (int i = 0; i < requestsList.Count(); ++i)
            {
                requestsList[i].timeUntilEnd = Math.Max(requestsList[i].timeUntilEnd - timeNewRequest, 0);
            }
        }

        private void UpdateGlobalTime(int step)
        {
            if ((currentTime[2] += step) >= 60)
            {
                currentTime[2] -= 60;
                if ((currentTime[1] += 1) >= 24)
                {
                    currentTime[1] -= 24;
                    currentTime[0] += 1;
                }
            }
        }

        // Get методы для статистики и информ. полей
        public int[] GetCurrentTime()
        {
            return currentTime;
        }

    }

    public enum DistributionType
    {
        Normal = "Нормальное",
        Uniform = "Равномерное"
    }
}
