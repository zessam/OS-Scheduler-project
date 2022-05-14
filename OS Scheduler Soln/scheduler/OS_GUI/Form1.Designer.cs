namespace OS
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Algos = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Selectionalgo = new System.Windows.Forms.Button();
            this.Algo_01 = new System.Windows.Forms.RadioButton();
            this.Algo_02 = new System.Windows.Forms.RadioButton();
            this.Algo_04 = new System.Windows.Forms.RadioButton();
            this.Algo_03 = new System.Windows.Forms.RadioButton();
            this.lo = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Algos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = global::OS.Properties.Resources.home;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OS.Properties.Resources.man;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Algos
            // 
            this.Algos.Controls.Add(this.textBox1);
            this.Algos.Controls.Add(this.Selectionalgo);
            this.Algos.Controls.Add(this.Algo_01);
            this.Algos.Controls.Add(this.Algo_02);
            this.Algos.Controls.Add(this.Algo_04);
            this.Algos.Controls.Add(this.Algo_03);
            resources.ApplyResources(this.Algos, "Algos");
            this.Algos.Name = "Algos";
            this.Algos.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Selectionalgo
            // 
            resources.ApplyResources(this.Selectionalgo, "Selectionalgo");
            this.Selectionalgo.Name = "Selectionalgo";
            this.Selectionalgo.UseVisualStyleBackColor = true;
            this.Selectionalgo.Click += new System.EventHandler(this.Selectionalgo_Click);
            // 
            // Algo_01
            // 
            resources.ApplyResources(this.Algo_01, "Algo_01");
            this.Algo_01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Algo_01.Name = "Algo_01";
            this.Algo_01.TabStop = true;
            this.Algo_01.UseVisualStyleBackColor = true;
            // 
            // Algo_02
            // 
            resources.ApplyResources(this.Algo_02, "Algo_02");
            this.Algo_02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Algo_02.Name = "Algo_02";
            this.Algo_02.TabStop = true;
            this.Algo_02.UseVisualStyleBackColor = true;
            // 
            // Algo_04
            // 
            resources.ApplyResources(this.Algo_04, "Algo_04");
            this.Algo_04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Algo_04.Name = "Algo_04";
            this.Algo_04.TabStop = true;
            this.Algo_04.UseVisualStyleBackColor = true;
            // 
            // Algo_03
            // 
            resources.ApplyResources(this.Algo_03, "Algo_03");
            this.Algo_03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Algo_03.Name = "Algo_03";
            this.Algo_03.TabStop = true;
            this.Algo_03.UseVisualStyleBackColor = true;
            this.Algo_03.CheckedChanged += new System.EventHandler(this.Algo_03_CheckedChanged);
            // 
            // lo
            // 
            resources.ApplyResources(this.lo, "lo");
            this.lo.Name = "lo";
            this.lo.UseVisualStyleBackColor = true;
            this.lo.Click += new System.EventHandler(this.lo_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "FinalTime";
            this.chart1.Series.Add(series1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lo);
            this.Controls.Add(this.Algos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Algos.ResumeLayout(false);
            this.Algos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Algos;
        private System.Windows.Forms.RadioButton Algo_01;
        private System.Windows.Forms.RadioButton Algo_02;
        private System.Windows.Forms.RadioButton Algo_04;
        private System.Windows.Forms.RadioButton Algo_03;
        private System.Windows.Forms.Button lo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Selectionalgo;
        private System.Windows.Forms.TextBox textBox1;
    }
}

