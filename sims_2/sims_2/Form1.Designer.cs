namespace sims_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.input_speed = new System.Windows.Forms.NumericUpDown();
            this.speed = new System.Windows.Forms.Label();
            this.input_angle = new System.Windows.Forms.NumericUpDown();
            this.angl = new System.Windows.Forms.Label();
            this.input_height = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.input_speed);
            this.panel1.Controls.Add(this.speed);
            this.panel1.Controls.Add(this.input_angle);
            this.panel1.Controls.Add(this.angl);
            this.panel1.Controls.Add(this.input_height);
            this.panel1.Controls.Add(this.height);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 137);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_speed
            // 
            this.input_speed.Location = new System.Drawing.Point(65, 77);
            this.input_speed.Name = "input_speed";
            this.input_speed.Size = new System.Drawing.Size(120, 20);
            this.input_speed.TabIndex = 5;
            this.input_speed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(12, 79);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(38, 13);
            this.speed.TabIndex = 4;
            this.speed.Text = "Speed";
            // 
            // input_angle
            // 
            this.input_angle.Location = new System.Drawing.Point(65, 42);
            this.input_angle.Name = "input_angle";
            this.input_angle.Size = new System.Drawing.Size(120, 20);
            this.input_angle.TabIndex = 3;
            this.input_angle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // angl
            // 
            this.angl.AutoSize = true;
            this.angl.Location = new System.Drawing.Point(12, 44);
            this.angl.Name = "angl";
            this.angl.Size = new System.Drawing.Size(34, 13);
            this.angl.TabIndex = 2;
            this.angl.Text = "Angle";
            // 
            // input_height
            // 
            this.input_height.Location = new System.Drawing.Point(65, 7);
            this.input_height.Name = "input_height";
            this.input_height.Size = new System.Drawing.Size(120, 20);
            this.input_height.TabIndex = 1;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(12, 9);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(38, 13);
            this.height.TabIndex = 0;
            this.height.Text = "Height";
            // 
            // chart1
            // 
            chartArea2.AxisX.Maximum = 15D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Maximum = 5D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 137);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(330, 207);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 344);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown input_speed;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.NumericUpDown input_angle;
        private System.Windows.Forms.Label angl;
        private System.Windows.Forms.NumericUpDown input_height;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

