namespace STM32F4_RF_PROG
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCOM = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.gettingText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveConfig = new System.Windows.Forms.Button();
            this.BarSpeed = new System.Windows.Forms.ComboBox();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelCzulosc = new System.Windows.Forms.Label();
            this.BarCzulosc = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelPower = new System.Windows.Forms.Label();
            this.BarPower = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelKanal = new System.Windows.Forms.Label();
            this.BarKanal = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxSend = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarCzulosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarKanal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj nr portu ( COM3/COM4/etc )";
            // 
            // textCOM
            // 
            this.textCOM.Location = new System.Drawing.Point(55, 39);
            this.textCOM.Name = "textCOM";
            this.textCOM.Size = new System.Drawing.Size(78, 20);
            this.textCOM.TabIndex = 1;
            this.textCOM.Text = "COM3";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(148, 34);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(77, 29);
            this.start.TabIndex = 2;
            this.start.Text = "Połącz";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // gettingText
            // 
            this.gettingText.Location = new System.Drawing.Point(284, 34);
            this.gettingText.Name = "gettingText";
            this.gettingText.Size = new System.Drawing.Size(233, 304);
            this.gettingText.TabIndex = 3;
            this.gettingText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odebrane dane";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveConfig);
            this.groupBox1.Controls.Add(this.BarSpeed);
            this.groupBox1.Controls.Add(this.LabelSpeed);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LabelCzulosc);
            this.groupBox1.Controls.Add(this.BarCzulosc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LabelPower);
            this.groupBox1.Controls.Add(this.BarPower);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LabelKanal);
            this.groupBox1.Controls.Add(this.BarKanal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(530, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 325);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konfiguracja";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(24, 290);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(145, 24);
            this.saveConfig.TabIndex = 12;
            this.saveConfig.Text = "Zapisz";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // BarSpeed
            // 
            this.BarSpeed.FormattingEnabled = true;
            this.BarSpeed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56"});
            this.BarSpeed.Location = new System.Drawing.Point(19, 253);
            this.BarSpeed.Name = "BarSpeed";
            this.BarSpeed.Size = new System.Drawing.Size(151, 21);
            this.BarSpeed.TabIndex = 11;
            this.BarSpeed.SelectedIndexChanged += new System.EventHandler(this.BarSpeed_SelectedIndexChanged);
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.Location = new System.Drawing.Point(157, 222);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(19, 13);
            this.LabelSpeed.TabIndex = 10;
            this.LabelSpeed.Text = "55";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Prędkość wysyłania";
            // 
            // LabelCzulosc
            // 
            this.LabelCzulosc.AutoSize = true;
            this.LabelCzulosc.Location = new System.Drawing.Point(157, 155);
            this.LabelCzulosc.Name = "LabelCzulosc";
            this.LabelCzulosc.Size = new System.Drawing.Size(13, 13);
            this.LabelCzulosc.TabIndex = 8;
            this.LabelCzulosc.Text = "0";
            // 
            // BarCzulosc
            // 
            this.BarCzulosc.Location = new System.Drawing.Point(6, 174);
            this.BarCzulosc.Maximum = 7;
            this.BarCzulosc.Name = "BarCzulosc";
            this.BarCzulosc.Size = new System.Drawing.Size(175, 45);
            this.BarCzulosc.TabIndex = 7;
            this.BarCzulosc.ValueChanged += new System.EventHandler(this.BarCzulosc_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Czułość sygnału";
            // 
            // LabelPower
            // 
            this.LabelPower.AutoSize = true;
            this.LabelPower.Location = new System.Drawing.Point(157, 88);
            this.LabelPower.Name = "LabelPower";
            this.LabelPower.Size = new System.Drawing.Size(13, 13);
            this.LabelPower.TabIndex = 5;
            this.LabelPower.Text = "0";
            // 
            // BarPower
            // 
            this.BarPower.Location = new System.Drawing.Point(6, 107);
            this.BarPower.Maximum = 7;
            this.BarPower.Name = "BarPower";
            this.BarPower.Size = new System.Drawing.Size(175, 45);
            this.BarPower.TabIndex = 4;
            this.BarPower.ValueChanged += new System.EventHandler(this.BarPower_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Moc sygnału";
            // 
            // LabelKanal
            // 
            this.LabelKanal.AutoSize = true;
            this.LabelKanal.Location = new System.Drawing.Point(157, 21);
            this.LabelKanal.Name = "LabelKanal";
            this.LabelKanal.Size = new System.Drawing.Size(13, 13);
            this.LabelKanal.TabIndex = 2;
            this.LabelKanal.Text = "0";
            // 
            // BarKanal
            // 
            this.BarKanal.Location = new System.Drawing.Point(6, 40);
            this.BarKanal.Maximum = 9;
            this.BarKanal.Name = "BarKanal";
            this.BarKanal.Size = new System.Drawing.Size(175, 45);
            this.BarKanal.TabIndex = 1;
            this.BarKanal.ValueChanged += new System.EventHandler(this.BarKanal_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numer kanału";
            // 
            // BoxSend
            // 
            this.BoxSend.Location = new System.Drawing.Point(19, 25);
            this.BoxSend.Name = "BoxSend";
            this.BoxSend.Size = new System.Drawing.Size(208, 20);
            this.BoxSend.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSend);
            this.groupBox2.Controls.Add(this.BoxSend);
            this.groupBox2.Location = new System.Drawing.Point(36, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 89);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wysyłanie";
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(55, 51);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(117, 28);
            this.BtnSend.TabIndex = 7;
            this.BtnSend.Text = "Wyślij";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 350);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gettingText);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textCOM);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program Kontroli Radiowej";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarCzulosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarKanal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCOM;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.RichTextBox gettingText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar BarKanal;
        private System.Windows.Forms.Label LabelKanal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BarSpeed;
        private System.Windows.Forms.Label LabelSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelCzulosc;
        private System.Windows.Forms.TrackBar BarCzulosc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelPower;
        private System.Windows.Forms.TrackBar BarPower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.TextBox BoxSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSend;
    }
}

