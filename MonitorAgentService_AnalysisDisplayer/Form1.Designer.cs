
namespace MonitorAgentService_AnalysisDisplayer
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
            this.lblSystem = new System.Windows.Forms.Label();
            this.btn_openManual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBattery = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSSD = new System.Windows.Forms.Label();
            this.btn_scanBadFile = new System.Windows.Forms.Button();
            this.lblSSDBadFile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWifi1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWifi2 = new System.Windows.Forms.Label();
            this.lblCpuBadFile = new System.Windows.Forms.Label();
            this.lblFanBadFile = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSystem.Location = new System.Drawing.Point(12, 62);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(48, 19);
            this.lblSystem.TabIndex = 1;
            this.lblSystem.Text = "None";
            // 
            // btn_openManual
            // 
            this.btn_openManual.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_openManual.Location = new System.Drawing.Point(278, 12);
            this.btn_openManual.Name = "btn_openManual";
            this.btn_openManual.Size = new System.Drawing.Size(150, 88);
            this.btn_openManual.TabIndex = 2;
            this.btn_openManual.Text = "Open file";
            this.btn_openManual.UseVisualStyleBackColor = true;
            this.btn_openManual.Click += new System.EventHandler(this.btn_openManual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "System Version Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPU Info";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCPU.Location = new System.Drawing.Point(12, 324);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(48, 19);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(321, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Battery Info";
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBattery.Location = new System.Drawing.Point(321, 324);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(48, 19);
            this.lblBattery.TabIndex = 6;
            this.lblBattery.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(144, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fan Info";
            // 
            // lblFan
            // 
            this.lblFan.AutoSize = true;
            this.lblFan.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFan.Location = new System.Drawing.Point(144, 324);
            this.lblFan.Name = "lblFan";
            this.lblFan.Size = new System.Drawing.Size(48, 19);
            this.lblFan.TabIndex = 10;
            this.lblFan.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(540, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "SSD Info";
            // 
            // lblSSD
            // 
            this.lblSSD.AutoSize = true;
            this.lblSSD.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSSD.Location = new System.Drawing.Point(540, 324);
            this.lblSSD.Name = "lblSSD";
            this.lblSSD.Size = new System.Drawing.Size(48, 19);
            this.lblSSD.TabIndex = 8;
            this.lblSSD.Text = "None";
            // 
            // btn_scanBadFile
            // 
            this.btn_scanBadFile.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_scanBadFile.Location = new System.Drawing.Point(278, 106);
            this.btn_scanBadFile.Name = "btn_scanBadFile";
            this.btn_scanBadFile.Size = new System.Drawing.Size(150, 41);
            this.btn_scanBadFile.TabIndex = 12;
            this.btn_scanBadFile.Text = "Scan SSD Bad";
            this.btn_scanBadFile.UseVisualStyleBackColor = true;
            this.btn_scanBadFile.Click += new System.EventHandler(this.btn_scanBadFile_Click);
            // 
            // lblSSDBadFile
            // 
            this.lblSSDBadFile.AutoSize = true;
            this.lblSSDBadFile.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSSDBadFile.Location = new System.Drawing.Point(655, 374);
            this.lblSSDBadFile.Name = "lblSSDBadFile";
            this.lblSSDBadFile.Size = new System.Drawing.Size(0, 19);
            this.lblSSDBadFile.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wifi card 1 Info";
            // 
            // lblWifi1
            // 
            this.lblWifi1.AutoSize = true;
            this.lblWifi1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWifi1.Location = new System.Drawing.Point(12, 538);
            this.lblWifi1.Name = "lblWifi1";
            this.lblWifi1.Size = new System.Drawing.Size(48, 19);
            this.lblWifi1.TabIndex = 15;
            this.lblWifi1.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(409, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Wifi card 2 Info";
            // 
            // lblWifi2
            // 
            this.lblWifi2.AutoSize = true;
            this.lblWifi2.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWifi2.Location = new System.Drawing.Point(409, 538);
            this.lblWifi2.Name = "lblWifi2";
            this.lblWifi2.Size = new System.Drawing.Size(48, 19);
            this.lblWifi2.TabIndex = 17;
            this.lblWifi2.Text = "None";
            // 
            // lblCpuBadFile
            // 
            this.lblCpuBadFile.AutoSize = true;
            this.lblCpuBadFile.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCpuBadFile.Location = new System.Drawing.Point(794, 434);
            this.lblCpuBadFile.Name = "lblCpuBadFile";
            this.lblCpuBadFile.Size = new System.Drawing.Size(0, 19);
            this.lblCpuBadFile.TabIndex = 19;
            // 
            // lblFanBadFile
            // 
            this.lblFanBadFile.AutoSize = true;
            this.lblFanBadFile.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFanBadFile.Location = new System.Drawing.Point(900, 416);
            this.lblFanBadFile.Name = "lblFanBadFile";
            this.lblFanBadFile.Size = new System.Drawing.Size(0, 19);
            this.lblFanBadFile.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(434, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(318, 79);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7";
            this.textBox1.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(434, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "SSD bad file";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(437, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "SSD bad file";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(434, 134);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(318, 79);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7";
            this.textBox2.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(755, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "SSD bad file";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(758, 134);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(318, 79);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7";
            this.textBox3.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(758, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "SSD bad file";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(758, 33);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(318, 79);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7";
            this.textBox4.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(758, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "SSD bad file";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(758, 233);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(318, 79);
            this.textBox5.TabIndex = 29;
            this.textBox5.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7";
            this.textBox5.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 703);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFanBadFile);
            this.Controls.Add(this.lblCpuBadFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWifi2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWifi1);
            this.Controls.Add(this.lblSSDBadFile);
            this.Controls.Add(this.btn_scanBadFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSSD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_openManual);
            this.Controls.Add(this.lblSystem);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Diagnosis Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Button btn_openManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSSD;
        private System.Windows.Forms.Button btn_scanBadFile;
        private System.Windows.Forms.Label lblSSDBadFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWifi1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWifi2;
        private System.Windows.Forms.Label lblCpuBadFile;
        private System.Windows.Forms.Label lblFanBadFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
    }
}

