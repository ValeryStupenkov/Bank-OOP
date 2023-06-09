﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_OOP.Classes
{
    public class Model
    {
        // Количество рабочих дней в неделе
        const int daysInWeek = 6;
        // Количество будних дней в неделю
        const int workDaysInWeek = 5;
        // Количество недель в месяце
        const int weeksInMonth = 4;
        // Количество рабочих часов в будний день
        const int hoursPerDay = 8;
        // Количество рабочих часов в выходной
        const int hoursPerWeekend = 6;
        // Минут в часе
        const int minutesPerHour = 60;
        // Зарплата клерка в день
        const int clerksPayment = 2000;
        // Время начала работы банка (час)
        const int baseHours = 10;
        // Время (в часах) с которого наступает вечер
        const int timeEvening = 6;

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
        
        // Сумма для вычисления средней занятости клерков
        double sumAvgBusyness = 0;

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
            int minutesLeft = weeksInMonth * workDaysInWeek * hoursPerDay * minutesPerHour + weeksInMonth * hoursPerWeekend * minutesPerHour;
            numberOfSteps = minutesLeft / step;
        }

        // Создать заявку
        private Request AddRequest()
        {
            int timeToServe;
            int profit;
            if (distribution == DistributionType.Uniform)
            {
                Random r = new Random();
                timeToServe = Convert.ToInt32(r.NextDouble() * (timeToHandleClients[1] - timeToHandleClients[0]) + timeToHandleClients[0]);
                profit = Convert.ToInt32(r.NextDouble() * (requestProfit[1] - requestProfit[0]) + requestProfit[0]);
            }
            else
            {
                NormalRandom r = new NormalRandom();
                timeToServe = Convert.ToInt32(r.NextDouble() * (timeToHandleClients[1] - timeToHandleClients[0]) + timeToHandleClients[0]);
                profit = Convert.ToInt32(r.NextDouble() * (requestProfit[1] - requestProfit[0]) + requestProfit[0]);
            }
            requestId++;
            return new Request(requestId, timeToServe, profit);
        }
        

        // Шаг 
        public void Tick()
        {
            int curTimeInStep = 0;
            var timeInterval = GenerateTimeIntervalForNewRequest();
            while (true)
            {
                // Вычисление времени до появления новой заявки
                if (!requestHaveSafeTime)
                {
                    if (distribution == DistributionType.Uniform)
                    {
                        var r = new Random();
                        timeNewRequest = timeInterval[0] + (int)(r.NextDouble() * (timeInterval[1] - timeInterval[0]));
                    }
                    else
                    {
                        var r = new NormalRandom();
                        timeNewRequest = timeInterval[0] + (int)(r.NextDouble() * (timeInterval[1] - timeInterval[0]));
                    }
                }
                requestHaveSafeTime = false;
                curTimeInStep += timeNewRequest;
                if (curTimeInStep > step)
                {
                    break;
                }

                servedRequestsCount += bank.UpdateHandlingList(timeNewRequest);

                bank.UpdateTimeWaiting(timeNewRequest);

                // Создание новой заявки
                Request newRequest = AddRequest();
                if (bank.CheckRequestQueue())
                {
                    bank.requestsQueue.Enqueue(newRequest);
                }
                else
                {
                    newRequest.servingTime = 0;
                    lostRequestsCount++;
                }

                // Перемещение заявок из очереди в список обрабатывающихся
                servedRequestsCount += bank.UpdateHandlingList(0);
            }
            servedRequestsCount += bank.UpdateHandlingList(timeNewRequest - (curTimeInStep - step));

            bank.UpdateTimeWaiting(timeNewRequest - (curTimeInStep - step));
            requestHaveSafeTime = true;
            timeNewRequest = curTimeInStep - step;
            sumQueueSize += bank.requestsQueue.Count();
            stepsCount++;
            UpdateCurrentTime(step);
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

        // Проверить, что день - выходной
        private bool IsWeekend()
        {
            // Последний день недели
            
            return currentTime[0] == daysInWeek;
        }

        // Поверить, что время - между 16 и 18 часов
        private bool IsTheTimeBetween6And8()
        {
            // Клиенты приходят чаще вечером
            return currentTime[1] >= timeEvening;
        }

        // Определить временной интервал перед поступлением очередной заявки
        private int[] GenerateTimeIntervalForNewRequest()
        {
            int forWeekend = 0;
            int forTheTimeBetween6And8 = 0;
            int longQueuePenalty = 0;
            if (IsWeekend())
            {
                forWeekend = 2;
            }
            if (IsTheTimeBetween6And8())
            {
                forTheTimeBetween6And8 = 2;
            }
            if (bank.requestsQueue.Count() == queueLength)
            {
                longQueuePenalty = 2;
            }
            int correction = forWeekend + forTheTimeBetween6And8 - longQueuePenalty;
            return new int[] { Math.Max(timeBetweenClients[0] - correction, 0), timeBetweenClients[1] - correction };
        }

        // Обновление текущего времени
        private void UpdateCurrentTime(int step)
        {
            if ((currentTime[2] += step) >= minutesPerHour)
            {
                currentTime[2] -= minutesPerHour;
                if ((currentTime[1] += 1) >= hoursPerDay)
                {
                    currentTime[1] -= hoursPerDay;
                    currentTime[0] += 1;
                }
                else if (currentTime[0] == daysInWeek && (currentTime[1] += 1) >= hoursPerWeekend)
                {
                    currentTime[1] -= hoursPerWeekend;
                    currentTime[0] = 1;
                }
            }
        }

        // Get методы для статистики и информ. полей
        public string GetCurrentTime()
        {
            int normal_hours = baseHours + currentTime[1];
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
            if (stepsCount != 0)
                return (double)sumQueueSize/stepsCount;
            else
                return 0.0;
        }

        public double GetAvgWaitingTime()
        {
            if (servedRequestsCount != 0)
                return (double)bank.allRequestTime/servedRequestsCount;
            else
                return 0.0;
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
            if (stepsCount != 0)
                return sumAvgBusyness/stepsCount;
            else
                return 0.0;
        }

        public int[] GetHandlingRequests()
        {
            return bank.GetHandlingRequests();
        }

        public int GetCurrentQueueSize()
        {
            return bank.requestsQueue.Count;
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
