namespace DynamicMonitor
{
    partial class SerialPortOption
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
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.textBox_com = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_com = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(77, 6);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(66, 21);
            this.comboBox_baudrate.TabIndex = 14;
            this.comboBox_baudrate.Text = "115200";
            // 
            // label_baudrate
            // 
            this.label_baudrate.AutoSize = true;
            this.label_baudrate.Font = new System.Drawing.Font("SimSun", 9F);
            this.label_baudrate.Location = new System.Drawing.Point(12, 9);
            this.label_baudrate.Name = "label_baudrate";
            this.label_baudrate.Size = new System.Drawing.Size(59, 12);
            this.label_baudrate.TabIndex = 3;
            this.label_baudrate.Text = "BaudRate:";
            // 
            // textBox_com
            // 
            this.textBox_com.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_com.Location = new System.Drawing.Point(77, 33);
            this.textBox_com.Name = "textBox_com";
            this.textBox_com.Size = new System.Drawing.Size(66, 21);
            this.textBox_com.TabIndex = 5;
            this.textBox_com.Text = "10";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(14, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_com
            // 
            this.label_com.AutoSize = true;
            this.label_com.Font = new System.Drawing.Font("SimSun", 9F);
            this.label_com.Location = new System.Drawing.Point(12, 37);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(29, 12);
            this.label_com.TabIndex = 4;
            this.label_com.Text = "COM:";
            // 
            // SerialPortOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 96);
            this.Controls.Add(this.label_baudrate);
            this.Controls.Add(this.label_com);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_baudrate);
            this.Controls.Add(this.textBox_com);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SerialPortOption";
            this.Text = "SerialPortOption";
            this.Load += new System.EventHandler(this.SerialPortOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label_baudrate;
        private System.Windows.Forms.TextBox textBox_com;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_com;
    }
}