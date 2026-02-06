
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
            this.btn_openManual.Location = new System.Drawing.Point(513, 14);
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
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPU Info";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCPU.Location = new System.Drawing.Point(12, 286);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(48, 19);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(153, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Battery Info";
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBattery.Location = new System.Drawing.Point(153, 286);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(48, 19);
            this.lblBattery.TabIndex = 6;
            this.lblBattery.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(332, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fan Info";
            // 
            // lblFan
            // 
            this.lblFan.AutoSize = true;
            this.lblFan.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFan.Location = new System.Drawing.Point(332, 286);
            this.lblFan.Name = "lblFan";
            this.lblFan.Size = new System.Drawing.Size(48, 19);
            this.lblFan.TabIndex = 10;
            this.lblFan.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(540, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "SSD Info";
            // 
            // lblSSD
            // 
            this.lblSSD.AutoSize = true;
            this.lblSSD.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSSD.Location = new System.Drawing.Point(540, 286);
            this.lblSSD.Name = "lblSSD";
            this.lblSSD.Size = new System.Drawing.Size(48, 19);
            this.lblSSD.TabIndex = 8;
            this.lblSSD.Text = "None";
            // 
            // btn_scanBadFile
            // 
            this.btn_scanBadFile.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_scanBadFile.Location = new System.Drawing.Point(669, 15);
            this.btn_scanBadFile.Name = "btn_scanBadFile";
            this.btn_scanBadFile.Size = new System.Drawing.Size(134, 23);
            this.btn_scanBadFile.TabIndex = 12;
            this.btn_scanBadFile.Text = "Scan SSD Bad";
            this.btn_scanBadFile.UseVisualStyleBackColor = true;
            this.btn_scanBadFile.Click += new System.EventHandler(this.btn_scanBadFile_Click);
            // 
            // lblSSDBadFile
            // 
            this.lblSSDBadFile.AutoSize = true;
            this.lblSSDBadFile.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSSDBadFile.Location = new System.Drawing.Point(670, 45);
            this.lblSSDBadFile.Name = "lblSSDBadFile";
            this.lblSSDBadFile.Size = new System.Drawing.Size(0, 19);
            this.lblSSDBadFile.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 546);
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
    }
}

