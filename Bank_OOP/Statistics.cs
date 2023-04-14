using Bank_OOP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_OOP
{
    public partial class Statistics : Form
    {
        private Model model;

        public Statistics(Model model)
        {
            InitializeComponent();
            this.model = model;
            servedClientsCounter.Text = $"Количество обслуженных клиентов: {model.GetServedRequestsCount()}";
            lostClientsCounter.Text = $"Количество потерянных клиентов: {model.GetLostRequestCount()}";
            avgWaitingCounter.Text = $"Среднее время ожидания: {model.GetAvgWaitingTime()} мин.";
            avgBusynessCounter.Text = $"Средняя занятость клерков: {model.GetAvgClerkBusyness()}";
            maxQueueCounter.Text = $"Максимальная длина очереди: {model.GetMaxQueueSize()}";
            avgQueueCounter.Text = $"Средняя длина очереди: {model.GetAvgQueueSize()}";
            profitCounter.Text = $"Прибыль банка: {model.GetRealProfit()}";
        }

        public Statistics()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void startAgain_button_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters();
            this.Visible = false;
            parameters.Show();
        }

        private void saveResults_button_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
