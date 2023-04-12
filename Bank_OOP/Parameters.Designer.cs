namespace Bank_OOP
{
    partial class Parameters
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
            this.step_size = new System.Windows.Forms.NumericUpDown();
            this.queue_length = new System.Windows.Forms.NumericUpDown();
            this.clerks_count = new System.Windows.Forms.NumericUpDown();
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
            this.time_between1 = new System.Windows.Forms.NumericUpDown();
            this.time_between2 = new System.Windows.Forms.NumericUpDown();
            this.time_serve1 = new System.Windows.Forms.NumericUpDown();
            this.time_serve2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.step_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queue_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clerks_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_between1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_between2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_serve1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_serve2)).BeginInit();
            this.SuspendLayout();
            // 
            // step_size
            // 
            this.step_size.Location = new System.Drawing.Point(178, 127);
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
            this.step_size.TabIndex = 70;
            this.step_size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // queue_length
            // 
            this.queue_length.Location = new System.Drawing.Point(178, 87);
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
            this.queue_length.TabIndex = 69;
            this.queue_length.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.queue_length.ValueChanged += new System.EventHandler(this.queue_length_ValueChanged);
            // 
            // clerks_count
            // 
            this.clerks_count.Location = new System.Drawing.Point(178, 51);
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
            this.clerks_count.TabIndex = 68;
            this.clerks_count.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.clerks_count.ValueChanged += new System.EventHandler(this.clerks_count_ValueChanged);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_button.Location = new System.Drawing.Point(39, 382);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(131, 34);
            this.start_button.TabIndex = 67;
            this.start_button.Text = "Начать";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 64;
            this.label11.Text = "мин.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "до";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 20);
            this.label13.TabIndex = 62;
            this.label13.Text = "от";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Время обслуживания клиентов";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Равномерное",
            "Нормальное"});
            this.comboBox1.Location = new System.Drawing.Point(131, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 28);
            this.comboBox1.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Распределение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "мин.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "до";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "от";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Время между приходом клиентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 40);
            this.label4.TabIndex = 52;
            this.label4.Text = "Шаг моделирования, \r\nмин.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Длина очереди\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Количество клерков\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Параметры моделирования";
            // 
            // time_between1
            // 
            this.time_between1.Location = new System.Drawing.Point(34, 210);
            this.time_between1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.time_between1.Name = "time_between1";
            this.time_between1.Size = new System.Drawing.Size(44, 27);
            this.time_between1.TabIndex = 71;
            this.time_between1.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // time_between2
            // 
            this.time_between2.Location = new System.Drawing.Point(124, 210);
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
            this.time_between2.TabIndex = 72;
            this.time_between2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // time_serve1
            // 
            this.time_serve1.Location = new System.Drawing.Point(34, 331);
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
            this.time_serve1.TabIndex = 73;
            this.time_serve1.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // time_serve2
            // 
            this.time_serve2.Location = new System.Drawing.Point(124, 331);
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
            this.time_serve2.TabIndex = 74;
            this.time_serve2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.time_serve2);
            this.Controls.Add(this.time_serve1);
            this.Controls.Add(this.time_between2);
            this.Controls.Add(this.time_between1);
            this.Controls.Add(this.step_size);
            this.Controls.Add(this.queue_length);
            this.Controls.Add(this.clerks_count);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Parameters";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.step_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queue_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clerks_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_between1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_between2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_serve1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_serve2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown step_size;
        private NumericUpDown queue_length;
        private NumericUpDown clerks_count;
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
        private NumericUpDown time_between1;
        private NumericUpDown time_between2;
        private NumericUpDown time_serve1;
        private NumericUpDown time_serve2;
    }
}