using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_OOP.Classes;

namespace Bank_OOP
{
    public partial class Parameters : Form
    {
        public Model model;

        public Parameters()
        {
            InitializeComponent();
        }

        private void clerks_count_ValueChanged(object sender, EventArgs e)
        {

        }

        private void queue_length_ValueChanged(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            int n = (int)clerks_count.Value;
            int k = (int)queue_length.Value;
            int step = (int)step_size.Value;
            int tb1 = (int)time_between1.Value;
            int tb2 = (int)time_between2.Value;
            int ts1 = (int)time_serve1.Value;
            int ts2 = (int)time_serve2.Value;
            int[] time_between = new int[2] { tb1, tb2};
            int[] time_serve = new int[2] { ts1, ts2 };
            string distribution = comboBox1.Text;
            model = new Model(n, k, step, distribution, time_between, time_serve);
            Modelling modelling = new Modelling(model);
            modelling.Show();
        }

        private void time_serve1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
