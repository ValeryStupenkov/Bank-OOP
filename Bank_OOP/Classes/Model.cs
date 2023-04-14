using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_OOP.Classes
{
    public class Model
    {
        const int daysInWeek = 6;

        const int weeksInMonth = 4;

        const int hoursPerDay = 8;

        const int hoursPerWeekend = 6;

        const int clerksPayment = 2000;

        // Прибыль от одной заявки
        int[] requestProfit = new int[2] { 50, 3000 };

        // Тип распределения случайных величин
        DistributionType distribution;

        // Текущее время, с типом определюсь в будущем
        int[] currentTime = new int[] { 1, 0, 0};
        
        // Номер текущей недели
        int currentWeek = 0;

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

        // Общее количество поступивших заявок
        int requests_count = 0;

        // Статистика
        // Кол-во обслуженных клиентов 
        int servedRequestsCount = 0;

        // Кол-во потерянных клиентов 
        int lostRequestsCount = 0;

        // Суммарная длина очереди для статистики
        int sumQueueSize = 0; 

        // Число сделанных шагов
        public int stepsCount = 0;

        // Прибыль
        int realProfit = 0;

        // Номер заявки по дням
        int requestId = 0;

        bool requestHaveSafeTime = false;

        // Время до появления в системе новой заявки
        int timeNewRequest;

        // Общее количество шагов
        public int numberOfSteps;
        
        double sumAvgBusyness = 0;
        
        // Список потерянных заявок
        List<Request> lostRequests = new List<Request>();

        // Методы
        // Конструктор
        public Model(int n, int k, int step, string distribution, int[] timeBetweenClients, int[] timeToHandleClients) 
        {
            clerksCount = n;
            queueLength = k;
            this.step = step;
            if (distribution == "Нормальное")
                this.distribution = DistributionType.Normal;
            else
                this.distribution = DistributionType.Uniform;
            this.timeBetweenClients = timeBetweenClients;
            this.timeToHandleClients = timeToHandleClients;
            bank = new Bank(n, k);
            int minutesLeft = weeksInMonth * 5 * hoursPerDay * 60 + weeksInMonth * hoursPerWeekend * 60;
            numberOfSteps = minutesLeft / step;
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
            requests_count++;
            requestId++;
            return new Request(requestId, timeToServe, profit);
        }

        

        // Шаг 
        public void Tick()
        {
            int curTimeInStep = 0;
            var timeInterval = GenerateTimeIntervalForNewRequest();
            var r = new Random();
            while (true)
            {
                // Вычисление времени до появления новой заявки
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

                servedRequestsCount += bank.UpdateHandledList(timeNewRequest);

                bank.UpdateTimeWaiting(timeNewRequest);

                // Создание новой заявки
                Request newRequest = AddRequest();
                if (bank.HandleRequest(newRequest))
                {
                    bank.requests.Enqueue(newRequest);
                }
                else
                {
                    newRequest.servingTime = 0;
                    lostRequests.Add(newRequest);
                    lostRequestsCount++;
                }

                // Перемещение заявок из очереди в список обрабатывающихся
                servedRequestsCount += bank.UpdateHandledList(0);
            }
            servedRequestsCount += bank.UpdateHandledList(timeNewRequest - (curTimeInStep - step));

            bank.UpdateTimeWaiting(timeNewRequest - (curTimeInStep - step));
            requestHaveSafeTime = true;
            timeNewRequest = curTimeInStep - step;
            sumQueueSize += bank.requests.Count();
            stepsCount++;
            UpdateGlobalTime(step);
            sumAvgBusyness += bank.GetClerksBusyness();
            if (currentTime[1] == 0 && currentTime[2] == 0)
            {
                requestId = 0;
            }
        }

        // Перейти к концу моделирования
        public void ToTheEnd()
        {
            for (int i=stepsCount; i < numberOfSteps; i++)
            {
                Tick();
            }
        }

        private bool IsWeekend()
        {
            if (currentTime[0] == 6)
            {
                return true;
            }
            return false;
        }

        private bool IsTheTimeBetween6And8()
        {
            if (currentTime[1] >= 6)
            {
                return true;
            }
            return false;
        }

        private int[] GenerateTimeIntervalForNewRequest()
        {
            int forWeekend = 0;
            int forTheTimeBetween6And8 = 0;
            int longQueuePenalty = 0;
            if (IsWeekend())
            {
                forWeekend = 5;
            }
            if (IsTheTimeBetween6And8())
            {
                forTheTimeBetween6And8 = 5;
            }
            if (bank.requests.Count() == queueLength)
            {
                longQueuePenalty -= 5;
            }
            double avg = (timeBetweenClients[0] + timeBetweenClients[1]) / 2.0;
            double avg_in_minutes = 1.0 / avg;
            int fluxDensity = 100 - forWeekend + forTheTimeBetween6And8;
            avg_in_minutes = avg_in_minutes * fluxDensity / 100.0;
            double new_avg = 1.0 / avg_in_minutes;
            return new int[] { Math.Abs((int)(new_avg - avg)), (int)(new_avg + avg) };
        }

        private void UpdateGlobalTime(int step)
        {
            if ((currentTime[2] += step) >= 60)
            {
                currentTime[2] -= 60;
                if ((currentTime[1] += 1) >= hoursPerDay)
                {
                    currentTime[1] -= hoursPerDay;
                    currentTime[0] += 1;
                }
                else if (currentTime[0] == 6 && (currentTime[1] += 1) >= hoursPerWeekend)
                {
                    currentTime[1] -= hoursPerWeekend;
                    currentTime[0] = 1;
                }
            }
        }

        // Get методы для статистики и информ. полей
        public string GetCurrentTime()
        {
            int normal_hours = 10 + currentTime[1];
            string normal_time;
            if (currentTime[2] == 0)
                normal_time = $"{normal_hours}:00";
            else
                normal_time = $"{normal_hours}:{currentTime[2]}";
            return normal_time;
        }

        public int GetClerksCount()
        {
            return clerksCount;
        }

        public int GetQueueLength()
        {
            return queueLength;
        }

        public int GetStepSize()
        {
            return step;
        }

        public string GetDistributionType()
        {
            if (distribution == DistributionType.Normal)
                return "Нормальное";
            else
                return "Равномерное";
        }

        public int[] GetTimeBetweenClients()
        {
            return timeBetweenClients;
        }

        public int[] GetTimeToHandleClients()
        {
            return timeToHandleClients;
        }

        public double GetAvgQueueSize()
        {
            return sumQueueSize / stepsCount;
        }

        public double GetAvgWaitingTime()
        {
            if (servedRequestsCount != 0)
                return bank.allRequestTime / servedRequestsCount;
            else
                return 0;
        }

        public int GetRealProfit()
        {
            realProfit = bank.profit - clerksPayment * clerksCount * daysInWeek;
            return realProfit;
        }

        public int GetCurrentProfit()
        {
            return bank.profit;
        }

        public double GetAvgClerkBusyness()
        {
            return sumAvgBusyness/stepsCount;
        }

        public int[] GetHandlingRequests()
        {
            return bank.GetHandlingRequests();
        }

        public int GetCurrentQueueSize()
        {
            return bank.requests.Count;
        }

        public string GetWeekDay()
        {
            switch (currentTime[0])
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
            }
            return "Воскресенье";
        }

        public int GetServedRequestsCount()
        {
            return servedRequestsCount;
        }

        public int GetLostRequestCount()
        {
            return lostRequestsCount;
        }

        public int GetMaxQueueSize()
        {
            return bank.maxQueueSize;
        }

    }

    public enum DistributionType
    {
        Normal = 0,
        Uniform = 1
    }
}
