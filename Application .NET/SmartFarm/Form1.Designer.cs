namespace SmartFarmV3
{
    partial class Form1
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
            this.sensorTemp1 = new System.Windows.Forms.Label();
            this.sensor1Data = new System.Windows.Forms.Button();
            this.labelSensor1Temp = new System.Windows.Forms.Label();
            this.labelSensor1 = new System.Windows.Forms.Label();
            this.labelSensor1Hum = new System.Windows.Forms.Label();
            this.sensorHum1 = new System.Windows.Forms.Label();
            this.labelSensor1Light = new System.Windows.Forms.Label();
            this.sensorLight1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSmarFarmbyKarlo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sensor1HistoryData = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sensorTemp1
            // 
            this.sensorTemp1.AutoSize = true;
            this.sensorTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorTemp1.Location = new System.Drawing.Point(232, 238);
            this.sensorTemp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sensorTemp1.Name = "sensorTemp1";
            this.sensorTemp1.Size = new System.Drawing.Size(95, 20);
            this.sensorTemp1.TabIndex = 2;
            this.sensorTemp1.Text = "Measuring...";
            this.sensorTemp1.Click += new System.EventHandler(this.sensorTemp1_Click);
            // 
            // sensor1Data
            // 
            this.sensor1Data.BackColor = System.Drawing.SystemColors.Control;
            this.sensor1Data.Location = new System.Drawing.Point(102, 162);
            this.sensor1Data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sensor1Data.Name = "sensor1Data";
            this.sensor1Data.Size = new System.Drawing.Size(347, 209);
            this.sensor1Data.TabIndex = 3;
            this.sensor1Data.UseVisualStyleBackColor = false;
            this.sensor1Data.Click += new System.EventHandler(this.sensor1Data_Click);
            // 
            // labelSensor1Temp
            // 
            this.labelSensor1Temp.AutoSize = true;
            this.labelSensor1Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensor1Temp.Location = new System.Drawing.Point(120, 238);
            this.labelSensor1Temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSensor1Temp.Name = "labelSensor1Temp";
            this.labelSensor1Temp.Size = new System.Drawing.Size(104, 20);
            this.labelSensor1Temp.TabIndex = 4;
            this.labelSensor1Temp.Text = "Temperatura:";
            this.labelSensor1Temp.Click += new System.EventHandler(this.labelSensor1Temp_Click);
            // 
            // labelSensor1
            // 
            this.labelSensor1.AutoSize = true;
            this.labelSensor1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.labelSensor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensor1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSensor1.Location = new System.Drawing.Point(219, 179);
            this.labelSensor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSensor1.Name = "labelSensor1";
            this.labelSensor1.Size = new System.Drawing.Size(98, 25);
            this.labelSensor1.TabIndex = 5;
            this.labelSensor1.Text = "Senzor 1";
            this.labelSensor1.Click += new System.EventHandler(this.labelSensor1_Click);
            // 
            // labelSensor1Hum
            // 
            this.labelSensor1Hum.AutoSize = true;
            this.labelSensor1Hum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensor1Hum.Location = new System.Drawing.Point(170, 274);
            this.labelSensor1Hum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSensor1Hum.Name = "labelSensor1Hum";
            this.labelSensor1Hum.Size = new System.Drawing.Size(54, 20);
            this.labelSensor1Hum.TabIndex = 6;
            this.labelSensor1Hum.Text = "Vlaga:";
            this.labelSensor1Hum.Click += new System.EventHandler(this.labelSensor1Hum_Click);
            // 
            // sensorHum1
            // 
            this.sensorHum1.AutoSize = true;
            this.sensorHum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorHum1.Location = new System.Drawing.Point(232, 274);
            this.sensorHum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sensorHum1.Name = "sensorHum1";
            this.sensorHum1.Size = new System.Drawing.Size(95, 20);
            this.sensorHum1.TabIndex = 7;
            this.sensorHum1.Text = "Measuring...";
            this.sensorHum1.Click += new System.EventHandler(this.sensorHum1_Click);
            // 
            // labelSensor1Light
            // 
            this.labelSensor1Light.AutoSize = true;
            this.labelSensor1Light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensor1Light.Location = new System.Drawing.Point(161, 309);
            this.labelSensor1Light.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSensor1Light.Name = "labelSensor1Light";
            this.labelSensor1Light.Size = new System.Drawing.Size(63, 20);
            this.labelSensor1Light.TabIndex = 8;
            this.labelSensor1Light.Text = "Svijetlo:";
            this.labelSensor1Light.Click += new System.EventHandler(this.labelSensor1Light_Click);
            // 
            // sensorLight1
            // 
            this.sensorLight1.AutoSize = true;
            this.sensorLight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorLight1.Location = new System.Drawing.Point(232, 309);
            this.sensorLight1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sensorLight1.Name = "sensorLight1";
            this.sensorLight1.Size = new System.Drawing.Size(95, 20);
            this.sensorLight1.TabIndex = 9;
            this.sensorLight1.Text = "Measuring...";
            this.sensorLight1.Click += new System.EventHandler(this.sensorLight1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Location = new System.Drawing.Point(102, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 62);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.labelSmarFarmbyKarlo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 57);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelSmarFarmbyKarlo
            // 
            this.labelSmarFarmbyKarlo.AutoSize = true;
            this.labelSmarFarmbyKarlo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmarFarmbyKarlo.Location = new System.Drawing.Point(12, 16);
            this.labelSmarFarmbyKarlo.Name = "labelSmarFarmbyKarlo";
            this.labelSmarFarmbyKarlo.Size = new System.Drawing.Size(170, 25);
            this.labelSmarFarmbyKarlo.TabIndex = 0;
            this.labelSmarFarmbyKarlo.Text = "SmartFarmbyKarlo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(610, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Senzor 2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Location = new System.Drawing.Point(493, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 62);
            this.panel3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(623, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Measuring...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Svijetlo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Measuring...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(561, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vlaga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Temperatura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Measuring...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(493, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 209);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(999, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Senzor 3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Location = new System.Drawing.Point(882, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 62);
            this.panel4.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1012, 309);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Measuring...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(941, 309);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Svijetlo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1012, 274);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Measuring...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(950, 274);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Vlaga:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(900, 238);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Temperatura:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1012, 238);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Measuring...";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(882, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 209);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // sensor1HistoryData
            // 
            this.sensor1HistoryData.FormattingEnabled = true;
            this.sensor1HistoryData.ItemHeight = 20;
            this.sensor1HistoryData.Location = new System.Drawing.Point(69, 444);
            this.sensor1HistoryData.Name = "sensor1HistoryData";
            this.sensor1HistoryData.Size = new System.Drawing.Size(409, 444);
            this.sensor1HistoryData.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 412);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Temperatura";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(195, 412);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Vlaga";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(289, 412);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Svijetlo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(389, 412);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 20);
            this.label18.TabIndex = 34;
            this.label18.Text = "Datum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 930);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.sensor1HistoryData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelSensor1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sensorLight1);
            this.Controls.Add(this.labelSensor1Light);
            this.Controls.Add(this.sensorHum1);
            this.Controls.Add(this.labelSensor1Hum);
            this.Controls.Add(this.labelSensor1Temp);
            this.Controls.Add(this.sensorTemp1);
            this.Controls.Add(this.sensor1Data);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sensorTemp1;
        private System.Windows.Forms.Button sensor1Data;
        private System.Windows.Forms.Label labelSensor1Temp;
        private System.Windows.Forms.Label labelSensor1;
        private System.Windows.Forms.Label labelSensor1Hum;
        private System.Windows.Forms.Label sensorHum1;
        private System.Windows.Forms.Label labelSensor1Light;
        private System.Windows.Forms.Label sensorLight1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSmarFarmbyKarlo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox sensor1HistoryData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

