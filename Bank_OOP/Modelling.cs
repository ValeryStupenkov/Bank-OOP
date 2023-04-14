using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Bank_OOP.Classes;

namespace Bank_OOP
{
    public partial class Modelling : Form
    {
        private Model model;
        private List<Label> windows = new List<Label>();
        private List<Label> requestnums = new List<Label>();
        private EventHandler tickEvent;
        public Modelling(Model model)
        {
            InitializeComponent();
            this.model = model;
            clerks_count.Value = model.GetClerksCount();
            queue_length.Value = model.GetQueueLength();
            step_size.Value = model.GetStepSize();
            comboBox1.Text = model.GetDistributionType();
            time_between1.Value = model.GetTimeBetweenClients()[0];
            time_between2.Value = model.GetTimeBetweenClients()[1];
            time_serve1.Value = model.GetTimeToHandleClients()[0];
            time_serve2.Value = model.GetTimeToHandleClients()[1];

            windows.Add(window1);
            windows.Add(window2);
            windows.Add(window3);
            windows.Add(window4);
            windows.Add(window5);
            windows.Add(window6);
            windows.Add(window7);
            requestnums.Add(requestnum1);
            requestnums.Add(requestnum2);
            requestnums.Add(requestnum3);
            requestnums.Add(requestnum4);
            requestnums.Add(requestnum5);
            requestnums.Add(requestnum6);
            requestnums.Add(requestnum7);

            // Создание N окон
            for (int i=0; i < model.GetClerksCount(); i++)
            {
                windows[i].Visible = true;
                requestnums[i].Visible = true;
            }
            tickEvent = new EventHandler(tick_button_Click);
        }

        public Modelling()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void tick_button_Click(object sender, EventArgs e)
        {
            model.Tick();
            // TODO обновление всех полей в информационном табло
            // Заполнение окон
            int[] ids = model.GetHandlingRequests();
            for (int i=0; i < model.GetClerksCount(); i++)
            {
                if (ids[i] != 0)
                    requestnums[i].Text = ids[i].ToString();
                else
                    requestnums[i].Text = "0000";
            }
            clientsCounter.Text = $"Клиентов в очереди: {model.GetCurrentQueueSize()}";
            profitCounter.Text = $"Прибыль: {model.GetCurrentProfit()}";
            dayCounter.Text = $"День недели: {model.GetWeekDay()}";
            timeCounter.Text = $"Время: {model.GetCurrentTime()}";
            servedClientsCounter.Text = $"Клиентов обслужено: {model.GetServedRequestsCount()}";
            lostClientsCounter.Text = $"Клиентов потеряно: {model.GetLostRequestCount()}";

            if (model.stepsCount == model.numberOfSteps)
            {
                Statistics statistics = new Statistics(model);
                this.Visible = false;
                statistics.Show();
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            InitializeTimer();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Tick -= tickEvent;
        }

        private void InitializeTimer()
        {
            timer1.Interval = 1000;
            timer1.Tick += tickEvent;
            timer1.Enabled = true;
        }

        private void toTheEnd_button_Click(object sender, EventArgs e)
        {
            model.ToTheEnd();
            Statistics statistics = new Statistics(model);
            this.Visible = false;
            statistics.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics(model);
            this.Visible = false;
            statistics.Show();
        }
    }
}
