namespace Weather
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Checkbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Temp = new TextBox();
            WindSpeed = new TextBox();
            Weather = new TextBox();
            Time = new TextBox();
            WindDir = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TimeOfDay = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // Checkbtn
            // 
            Checkbtn.Location = new Point(408, 170);
            Checkbtn.Name = "Checkbtn";
            Checkbtn.Size = new Size(127, 41);
            Checkbtn.TabIndex = 0;
            Checkbtn.Text = "Sprawdź pogodę";
            Checkbtn.UseVisualStyleBackColor = true;
            Checkbtn.Click += Checkbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 128);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Temperatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 173);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Prędkość wiatru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 256);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 3;
            label3.Text = "Rodzaj pogody";
            // 
            // Temp
            // 
            Temp.Location = new Point(138, 125);
            Temp.Name = "Temp";
            Temp.Size = new Size(100, 23);
            Temp.TabIndex = 4;
            // 
            // WindSpeed
            // 
            WindSpeed.Location = new Point(138, 170);
            WindSpeed.Name = "WindSpeed";
            WindSpeed.Size = new Size(100, 23);
            WindSpeed.TabIndex = 5;
            // 
            // Weather
            // 
            Weather.Location = new Point(138, 253);
            Weather.Name = "Weather";
            Weather.Size = new Size(161, 23);
            Weather.TabIndex = 6;
            // 
            // Time
            // 
            Time.Location = new Point(138, 81);
            Time.Name = "Time";
            Time.Size = new Size(100, 23);
            Time.TabIndex = 7;
            // 
            // WindDir
            // 
            WindDir.Location = new Point(138, 212);
            WindDir.Name = "WindDir";
            WindDir.Size = new Size(100, 23);
            WindDir.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 215);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 9;
            label4.Text = "Kierunek wiatru";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 84);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "Godzina";
            // 
            // TimeOfDay
            // 
            TimeOfDay.Location = new Point(138, 42);
            TimeOfDay.Name = "TimeOfDay";
            TimeOfDay.Size = new Size(100, 23);
            TimeOfDay.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 45);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 12;
            label6.Text = "Pora dnia";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(TimeOfDay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(WindDir);
            Controls.Add(Time);
            Controls.Add(Weather);
            Controls.Add(WindSpeed);
            Controls.Add(Temp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Checkbtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Checkbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Temp;
        private TextBox WindSpeed;
        private TextBox Weather;
        private TextBox Time;
        private TextBox WindDir;
        private Label label4;
        private Label label5;
        private TextBox TimeOfDay;
        private Label label6;
    }
}