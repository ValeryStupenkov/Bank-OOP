namespace Bank_OOP
{
    partial class Statistics
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.profitCounter = new System.Windows.Forms.Label();
            this.avgQueueCounter = new System.Windows.Forms.Label();
            this.maxQueueCounter = new System.Windows.Forms.Label();
            this.avgBusynessCounter = new System.Windows.Forms.Label();
            this.avgWaitingCounter = new System.Windows.Forms.Label();
            this.lostClientsCounter = new System.Windows.Forms.Label();
            this.servedClientsCounter = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.saveResults_button = new System.Windows.Forms.Button();
            this.startAgain_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.profitCounter);
            this.groupBox1.Controls.Add(this.avgQueueCounter);
            this.groupBox1.Controls.Add(this.maxQueueCounter);
            this.groupBox1.Controls.Add(this.avgBusynessCounter);
            this.groupBox1.Controls.Add(this.avgWaitingCounter);
            this.groupBox1.Controls.Add(this.lostClientsCounter);
            this.groupBox1.Controls.Add(this.servedClientsCounter);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // profitCounter
            // 
            this.profitCounter.AutoSize = true;
            this.profitCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profitCounter.Location = new System.Drawing.Point(24, 197);
            this.profitCounter.Name = "profitCounter";
            this.profitCounter.Size = new System.Drawing.Size(165, 28);
            this.profitCounter.TabIndex = 7;
            this.profitCounter.Text = "Прибыль банка: ";
            // 
            // avgQueueCounter
            // 
            this.avgQueueCounter.AutoSize = true;
            this.avgQueueCounter.Location = new System.Drawing.Point(409, 139);
            this.avgQueueCounter.Name = "avgQueueCounter";
            this.avgQueueCounter.Size = new System.Drawing.Size(184, 20);
            this.avgQueueCounter.TabIndex = 6;
            this.avgQueueCounter.Text = "Средняя длина очереди: ";
            // 
            // maxQueueCounter
            // 
            this.maxQueueCounter.AutoSize = true;
            this.maxQueueCounter.Location = new System.Drawing.Point(409, 45);
            this.maxQueueCounter.Name = "maxQueueCounter";
            this.maxQueueCounter.Size = new System.Drawing.Size(229, 20);
            this.maxQueueCounter.TabIndex = 4;
            this.maxQueueCounter.Text = "Максимальная длина очереди: ";
            // 
            // avgBusynessCounter
            // 
            this.avgBusynessCounter.AutoSize = true;
            this.avgBusynessCounter.Location = new System.Drawing.Point(24, 139);
            this.avgBusynessCounter.Name = "avgBusynessCounter";
            this.avgBusynessCounter.Size = new System.Drawing.Size(207, 20);
            this.avgBusynessCounter.TabIndex = 3;
            this.avgBusynessCounter.Text = "Средняя занятость клерков: ";
            this.avgBusynessCounter.Click += new System.EventHandler(this.label4_Click);
            // 
            // avgWaitingCounter
            // 
            this.avgWaitingCounter.AutoSize = true;
            this.avgWaitingCounter.Location = new System.Drawing.Point(409, 92);
            this.avgWaitingCounter.Name = "avgWaitingCounter";
            this.avgWaitingCounter.Size = new System.Drawing.Size(198, 20);
            this.avgWaitingCounter.TabIndex = 2;
            this.avgWaitingCounter.Text = "Среднее время ожидания: ";
            // 
            // lostClientsCounter
            // 
            this.lostClientsCounter.AutoSize = true;
            this.lostClientsCounter.Location = new System.Drawing.Point(24, 92);
            this.lostClientsCounter.Name = "lostClientsCounter";
            this.lostClientsCounter.Size = new System.Drawing.Size(254, 20);
            this.lostClientsCounter.TabIndex = 1;
            this.lostClientsCounter.Text = "Количество потерянных клиентов: ";
            // 
            // servedClientsCounter
            // 
            this.servedClientsCounter.AutoSize = true;
            this.servedClientsCounter.Location = new System.Drawing.Point(24, 45);
            this.servedClientsCounter.Name = "servedClientsCounter";
            this.servedClientsCounter.Size = new System.Drawing.Size(264, 20);
            this.servedClientsCounter.TabIndex = 0;
            this.servedClientsCounter.Text = "Количество обслуженных клиентов: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exit_button);
            this.groupBox2.Controls.Add(this.saveResults_button);
            this.groupBox2.Controls.Add(this.startAgain_button);
            this.groupBox2.Location = new System.Drawing.Point(14, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(537, 66);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(159, 29);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // saveResults_button
            // 
            this.saveResults_button.Location = new System.Drawing.Point(271, 66);
            this.saveResults_button.Name = "saveResults_button";
            this.saveResults_button.Size = new System.Drawing.Size(201, 29);
            this.saveResults_button.TabIndex = 4;
            this.saveResults_button.Text = "Сохранить результаты";
            this.saveResults_button.UseVisualStyleBackColor = true;
            this.saveResults_button.Click += new System.EventHandler(this.saveResults_button_Click);
            // 
            // startAgain_button
            // 
            this.startAgain_button.Location = new System.Drawing.Point(50, 66);
            this.startAgain_button.Name = "startAgain_button";
            this.startAgain_button.Size = new System.Drawing.Size(166, 29);
            this.startAgain_button.TabIndex = 3;
            this.startAgain_button.Text = "Начать заново";
            this.startAgain_button.UseVisualStyleBackColor = true;
            this.startAgain_button.Click += new System.EventHandler(this.startAgain_button_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label avgBusynessCounter;
        private Label avgWaitingCounter;
        private Label lostClientsCounter;
        private Label servedClientsCounter;
        private Label maxQueueCounter;
        private Label avgQueueCounter;
        private Label profitCounter;
        private GroupBox groupBox2;
        private Button startAgain_button;
        private Button exit_button;
        private Button saveResults_button;
    }
}