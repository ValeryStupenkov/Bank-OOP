namespace Bank_OOP
{
    partial class Modelling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stop_button = new System.Windows.Forms.Button();
            this.clerks_count = new System.Windows.Forms.NumericUpDown();
            this.queue_length = new System.Windows.Forms.NumericUpDown();
            this.step_size = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lostClientsCounter = new System.Windows.Forms.Label();
            this.servedClientsCounter = new System.Windows.Forms.Label();
            this.timeCounter = new System.Windows.Forms.Label();
            this.dayCounter = new System.Windows.Forms.Label();
            this.profitCounter = new System.Windows.Forms.Label();
            this.clientsCounter = new System.Windows.Forms.Label();
            this.requestnum7 = new System.Windows.Forms.Label();
            this.requestnum6 = new System.Windows.Forms.Label();
            this.requestnum5 = new System.Windows.Forms.Label();
            this.requestnum4 = new System.Windows.Forms.Label();
            this.requestnum3 = new System.Windows.Forms.Label();
            this.requestnum2 = new System.Windows.Forms.Label();
            this.requestnum1 = new System.Windows.Forms.Label();
            this.window7 = new System.Windows.Forms.Label();
            this.window6 = new System.Windows.Forms.Label();
            this.window5 = new System.Windows.Forms.Label();
            this.window4 = new System.Windows.Forms.Label();
            this.window3 = new System.Windows.Forms.Label();
            this.window2 = new System.Windows.Forms.Label();
            this.window1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toTheEnd_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.tick_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.time_serve2 = new System.Windows.Forms.NumericUpDown();
            this.time_serve1 = new System.Windows.Forms.NumericUpDown();
            this.time_between2 = new System.Windows.Forms.NumericUpDown();
            this.time_between1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clerks_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queue_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step_size)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_serve2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_serve1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_between2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_between1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_button.Location = new System.Drawing.Point(168, 21);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(116, 34);
            this.start_button.TabIndex = 43;
            this.start_button.Text = "Старт";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "мин.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "до";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "от";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Время обслуживания клиентов";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Равномерное",
            "Нормальное"});
            this.comboBox1.Location = new System.Drawing.Point(126, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 28);
            this.comboBox1.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Распределение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "мин.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "от";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Время между приходом клиентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 40);
            this.label4.TabIndex = 27;
            this.label4.Text = "Шаг моделирования, \r\nмин.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Длина очереди\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Количество клерков\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Параметры моделирования";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.Red;
            this.stop_button.Location = new System.Drawing.Point(308, 21);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(116, 34);
            this.stop_button.TabIndex = 44;
            this.stop_button.Text = "Стоп";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // clerks_count
            // 
            this.clerks_count.Enabled = false;
            this.clerks_count.Location = new System.Drawing.Point(173, 37);
            this.clerks_count.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.clerks_count.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.clerks_count.Name = "clerks_count";
            this.clerks_count.Size = new System.Drawing.Size(59, 27);
            this.clerks_count.TabIndex = 45;
            this.clerks_count.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.clerks_count.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // queue_length
            // 
            this.queue_length.Enabled = false;
            this.queue_length.Location = new System.Drawing.Point(173, 70);
            this.queue_length.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.queue_length.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.queue_length.Name = "queue_length";
            this.queue_length.Size = new System.Drawing.Size(59, 27);
            this.queue_length.TabIndex = 46;
            this.queue_length.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // step_size
            // 
            this.step_size.Enabled = false;
            this.step_size.Location = new System.Drawing.Point(173, 113);
            this.step_size.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.step_size.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.step_size.Name = "step_size";
            this.step_size.Size = new System.Drawing.Size(59, 27);
            this.step_size.TabIndex = 47;
            this.step_size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.lostClientsCounter);
            this.groupBox1.Controls.Add(this.servedClientsCounter);
            this.groupBox1.Controls.Add(this.timeCounter);
            this.groupBox1.Controls.Add(this.dayCounter);
            this.groupBox1.Controls.Add(this.profitCounter);
            this.groupBox1.Controls.Add(this.clientsCounter);
            this.groupBox1.Controls.Add(this.requestnum7);
            this.groupBox1.Controls.Add(this.requestnum6);
            this.groupBox1.Controls.Add(this.requestnum5);
            this.groupBox1.Controls.Add(this.requestnum4);
            this.groupBox1.Controls.Add(this.requestnum3);
            this.groupBox1.Controls.Add(this.requestnum2);
            this.groupBox1.Controls.Add(this.requestnum1);
            this.groupBox1.Controls.Add(this.window7);
            this.groupBox1.Controls.Add(this.window6);
            this.groupBox1.Controls.Add(this.window5);
            this.groupBox1.Controls.Add(this.window4);
            this.groupBox1.Controls.Add(this.window3);
            this.groupBox1.Controls.Add(this.window2);
            this.groupBox1.Controls.Add(this.window1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(283, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 274);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // lostClientsCounter
            // 
            this.lostClientsCounter.AutoSize = true;
            this.lostClientsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lostClientsCounter.Location = new System.Drawing.Point(15, 203);
            this.lostClientsCounter.Name = "lostClientsCounter";
            this.lostClientsCounter.Size = new System.Drawing.Size(153, 20);
            this.lostClientsCounter.TabIndex = 20;
            this.lostClientsCounter.Text = "Клиентов потеряно: ";
            // 
            // servedClientsCounter
            // 
            this.servedClientsCounter.AutoSize = true;
            this.servedClientsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.servedClientsCounter.Location = new System.Drawing.Point(15, 174);
            this.servedClientsCounter.Name = "servedClientsCounter";
            this.servedClientsCounter.Size = new System.Drawing.Size(163, 20);
            this.servedClientsCounter.TabIndex = 19;
            this.servedClientsCounter.Text = "Клиентов обслужано: ";
            // 
            // timeCounter
            // 
            this.timeCounter.AutoSize = true;
            this.timeCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.timeCounter.Location = new System.Drawing.Point(287, 214);
            this.timeCounter.Name = "timeCounter";
            this.timeCounter.Size = new System.Drawing.Size(61, 20);
            this.timeCounter.TabIndex = 18;
            this.timeCounter.Text = "Время: ";
            // 
            // dayCounter
            // 
            this.dayCounter.AutoSize = true;
            this.dayCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dayCounter.Location = new System.Drawing.Point(287, 163);
            this.dayCounter.Name = "dayCounter";
            this.dayCounter.Size = new System.Drawing.Size(105, 20);
            this.dayCounter.TabIndex = 17;
            this.dayCounter.Text = "День недели: ";
            // 
            // profitCounter
            // 
            this.profitCounter.AutoSize = true;
            this.profitCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.profitCounter.Location = new System.Drawing.Point(15, 232);
            this.profitCounter.Name = "profitCounter";
            this.profitCounter.Size = new System.Drawing.Size(81, 20);
            this.profitCounter.TabIndex = 16;
            this.profitCounter.Text = "Прибыль: ";
            // 
            // clientsCounter
            // 
            this.clientsCounter.AutoSize = true;
            this.clientsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clientsCounter.Location = new System.Drawing.Point(15, 145);
            this.clientsCounter.Name = "clientsCounter";
            this.clientsCounter.Size = new System.Drawing.Size(157, 20);
            this.clientsCounter.TabIndex = 15;
            this.clientsCounter.Text = "Клиентов в очереди: ";
            // 
            // requestnum7
            // 
            this.requestnum7.AutoSize = true;
            this.requestnum7.BackColor = System.Drawing.Color.Black;
            this.requestnum7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestnum7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.requestnum7.Location = new System.Drawing.Point(435, 85);
            this.requestnum7.Name = "requestnum7";
            this.requestnum7.Size = new System.Drawing.Size(43, 22);
            this.requestnum7.TabIndex = 14;
            this.requestnum7.Text = "0000";
            this.requestnum7.Visible = false;
            // 
            // requestnum6
            // 
            this.requestnum6.AutoSize = true;
            this.requestnum6.BackColor = System.Drawing.Color.Black;
            this.requestnum6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestnum6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.requestnum6.Location = new System.Drawing.Point(365, 85);
            this.requestnum6.Name = "requestnum6";
            this.requestnum6.Size = new System.Drawing.Size(43, 22);
            this.requestnum6.TabIndex = 13;
            this.requestnum6.Text = "0000";
            this.requestnum6.Visible = false;
            // 
            // requestnum5
            // 
            this.requestnum5.AutoSize = true;
            this.requestnum5.BackColor = System.Drawing.Color.Black;
            this.requestnum5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestnum5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.requestnum5.Location = new System.Drawing.Point(295, 85);
            this.requestnum5.Name = "requestnum5";
            this.requestnum5.Size = new System.Drawing.Size(43, 22);
            this.requestnum5.TabIndex = 12;
            this.requestnum5.Text = "0000";
            this.requestnum5.Visible = false;
            // 
            // requestnum4
            // 
            this.requestnum4.AutoSize = true;
            this.requestnum4.BackColor = System.Drawing.Color.Black;
            this.requestnum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestnum4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.requestnum4.Location = new System.Drawing.Point(225, 85);
            this.requestnum4.Name = "requestnum4";
            this.requestnum4.Size = new System.Drawing.Size(43, 22);
            this.requestnum4.TabIndex = 11;
            this.requestnum4.Text = "0000";
            this.requestnum4.Visible = false;
            // 
            // requestnum3
            // 
            this.requestnum3.AutoSize = true;
            this.requestnum3.BackColor = System.Drawing.Color.Black;
            this.requestnum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestnum3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.requestnum3.Location = new System.Drawing.Point(155, 85);
            this.requestnum3.Name = "requestnum3";
            this.requestnum3.Size = new System.Drawing.Size(43, 22);
            this.requestnum3.TabIndex = 10;
            this.requestnum3.Text = "0000";
            this.requestnum3.Visible = false;
            // 
            // requestnum2
            // 
            this.requestnum2.AutoSize = true;
            this.requestnum2.BackColor = System.Drawing.Color.Black;
            this.requestnum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestnum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.requestnum2.Location = new System.Drawing.Point(85, 85);
            this.requestnum2.Name = "requestnum2";
            this.requestnum2.Size = new System.Drawing.Size(43, 22);
            this.requestnum2.TabIndex = 9;
            this.requestnum2.Text = "0000";
            this.requestnum2.Visible = false;
            // 
            // requestnum1
            // 
            this.requestnum1.AutoSize = true;
            this.requestnum1.BackColor = System.Drawing.Color.Black;
            this.requestnum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestnum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.requestnum1.Location = new System.Drawing.Point(15, 85);
            this.requestnum1.Name = "requestnum1";
            this.requestnum1.Size = new System.Drawing.Size(43, 22);
            this.requestnum1.TabIndex = 8;
            this.requestnum1.Text = "0000";
            this.requestnum1.Visible = false;
            this.requestnum1.Click += new System.EventHandler(this.label22_Click);
            // 
            // window7
            // 
            this.window7.AutoSize = true;
            this.window7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.window7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.window7.Location = new System.Drawing.Point(435, 50);
            this.window7.Name = "window7";
            this.window7.Size = new System.Drawing.Size(59, 22);
            this.window7.TabIndex = 7;
            this.window7.Text = "Окно 7";
            this.window7.Visible = false;
            // 
            // window6
            // 
            this.window6.AutoSize = true;
            this.window6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.window6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.window6.Location = new System.Drawing.Point(365, 50);
            this.window6.Name = "window6";
            this.window6.Size = new System.Drawing.Size(59, 22);
            this.window6.TabIndex = 6;
            this.window6.Text = "Окно 6";
            this.window6.Visible = false;
            // 
            // window5
            // 
            this.window5.AutoSize = true;
            this.window5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.window5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.window5.Location = new System.Drawing.Point(295, 50);
            this.window5.Name = "window5";
            this.window5.Size = new System.Drawing.Size(59, 22);
            this.window5.TabIndex = 5;
            this.window5.Text = "Окно 5";
            this.window5.Visible = false;
            // 
            // window4
            // 
            this.window4.AutoSize = true;
            this.window4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.window4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.window4.Location = new System.Drawing.Point(225, 50);
            this.window4.Name = "window4";
            this.window4.Size = new System.Drawing.Size(59, 22);
            this.window4.TabIndex = 4;
            this.window4.Text = "Окно 4";
            this.window4.Visible = false;
            // 
            // window3
            // 
            this.window3.AutoSize = true;
            this.window3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.window3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.window3.Location = new System.Drawing.Point(155, 50);
            this.window3.Name = "window3";
            this.window3.Size = new System.Drawing.Size(59, 22);
            this.window3.TabIndex = 3;
            this.window3.Text = "Окно 3";
            this.window3.Visible = false;
            // 
            // window2
            // 
            this.window2.AutoSize = true;
            this.window2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.window2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.window2.Location = new System.Drawing.Point(85, 50);
            this.window2.Name = "window2";
            this.window2.Size = new System.Drawing.Size(59, 22);
            this.window2.TabIndex = 2;
            this.window2.Text = "Окно 2";
            this.window2.Visible = false;
            // 
            // window1
            // 
            this.window1.AutoSize = true;
            this.window1.BackColor = System.Drawing.Color.Black;
            this.window1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.window1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.window1.Location = new System.Drawing.Point(15, 50);
            this.window1.Name = "window1";
            this.window1.Size = new System.Drawing.Size(59, 22);
            this.window1.TabIndex = 1;
            this.window1.Text = "Окно 1";
            this.window1.Visible = false;
            this.window1.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(166, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Информационное табло";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toTheEnd_button);
            this.groupBox2.Controls.Add(this.exit_button);
            this.groupBox2.Controls.Add(this.tick_button);
            this.groupBox2.Controls.Add(this.start_button);
            this.groupBox2.Controls.Add(this.stop_button);
            this.groupBox2.Location = new System.Drawing.Point(283, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 132);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // toTheEnd_button
            // 
            this.toTheEnd_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toTheEnd_button.Location = new System.Drawing.Point(28, 80);
            this.toTheEnd_button.Name = "toTheEnd_button";
            this.toTheEnd_button.Size = new System.Drawing.Size(204, 29);
            this.toTheEnd_button.TabIndex = 53;
            this.toTheEnd_button.Text = "К концу моделирования";
            this.toTheEnd_button.UseVisualStyleBackColor = false;
            this.toTheEnd_button.Click += new System.EventHandler(this.toTheEnd_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(406, 103);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(116, 29);
            this.exit_button.TabIndex = 52;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // tick_button
            // 
            this.tick_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tick_button.Location = new System.Drawing.Point(28, 26);
            this.tick_button.Name = "tick_button";
            this.tick_button.Size = new System.Drawing.Size(116, 29);
            this.tick_button.TabIndex = 50;
            this.tick_button.Text = "Шаг вперёд";
            this.tick_button.UseVisualStyleBackColor = false;
            this.tick_button.Click += new System.EventHandler(this.tick_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.time_serve2);
            this.groupBox3.Controls.Add(this.time_serve1);
            this.groupBox3.Controls.Add(this.time_between2);
            this.groupBox3.Controls.Add(this.time_between1);
            this.groupBox3.Controls.Add(this.step_size);
            this.groupBox3.Controls.Add(this.queue_length);
            this.groupBox3.Controls.Add(this.clerks_count);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 409);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // time_serve2
            // 
            this.time_serve2.Enabled = false;
            this.time_serve2.Location = new System.Drawing.Point(119, 317);
            this.time_serve2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.time_serve2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.time_serve2.Name = "time_serve2";
            this.time_serve2.Size = new System.Drawing.Size(44, 27);
            this.time_serve2.TabIndex = 75;
            this.time_serve2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // time_serve1
            // 
            this.time_serve1.Enabled = false;
            this.time_serve1.Location = new System.Drawing.Point(34, 317);
            this.time_serve1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.time_serve1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.time_serve1.Name = "time_serve1";
            this.time_serve1.Size = new System.Drawing.Size(44, 27);
            this.time_serve1.TabIndex = 74;
            this.time_serve1.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // time_between2
            // 
            this.time_between2.Enabled = false;
            this.time_between2.Location = new System.Drawing.Point(119, 191);
            this.time_between2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.time_between2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.time_between2.Name = "time_between2";
            this.time_between2.Size = new System.Drawing.Size(46, 27);
            this.time_between2.TabIndex = 73;
            this.time_between2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // time_between1
            // 
            this.time_between1.Enabled = false;
            this.time_between1.Location = new System.Drawing.Point(34, 191);
            this.time_between1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.time_between1.Name = "time_between1";
            this.time_between1.Size = new System.Drawing.Size(44, 27);
            this.time_between1.TabIndex = 72;
            this.time_between1.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // Modelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 436);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modelling";
            this.Text = "Моделирование";
            ((System.ComponentModel.ISupportInitialize)(this.clerks_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queue_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step_size)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_serve2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_serve1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_between2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_between1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button start_button;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label10;
        private ComboBox comboBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button stop_button;
        private NumericUpDown clerks_count;
        private NumericUpDown queue_length;
        private NumericUpDown step_size;
        private GroupBox groupBox1;
        private Label label14;
        private Label window7;
        private Label window6;
        private Label window5;
        private Label window4;
        private Label window3;
        private Label window2;
        private Label window1;
        private Label requestnum1;
        private Label requestnum7;
        private Label requestnum6;
        private Label requestnum5;
        private Label requestnum4;
        private Label requestnum3;
        private Label requestnum2;
        private Label clientsCounter;
        private Label timeCounter;
        private Label dayCounter;
        private Label profitCounter;
        private GroupBox groupBox2;
        private Button tick_button;
        private Button exit_button;
        private GroupBox groupBox3;
        private NumericUpDown time_between1;
        private NumericUpDown time_between2;
        private NumericUpDown time_serve1;
        private NumericUpDown time_serve2;
        private Button toTheEnd_button;
        private Label lostClientsCounter;
        private Label servedClientsCounter;
        private System.Windows.Forms.Timer timer1;
    }
}