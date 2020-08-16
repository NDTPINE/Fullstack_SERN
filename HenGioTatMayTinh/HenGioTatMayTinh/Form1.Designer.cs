namespace HenGioTatMayTinh
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
            this.components = new System.ComponentModel.Container();
            this.nmHour = new System.Windows.Forms.NumericUpDown();
            this.nmMinutes = new System.Windows.Forms.NumericUpDown();
            this.nmSecond = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // nmHour
            // 
            this.nmHour.Location = new System.Drawing.Point(12, 48);
            this.nmHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmHour.Name = "nmHour";
            this.nmHour.Size = new System.Drawing.Size(59, 20);
            this.nmHour.TabIndex = 0;
            this.nmHour.ValueChanged += new System.EventHandler(this.nmHour_ValueChanged);
            // 
            // nmMinutes
            // 
            this.nmMinutes.Location = new System.Drawing.Point(133, 48);
            this.nmMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmMinutes.Name = "nmMinutes";
            this.nmMinutes.Size = new System.Drawing.Size(59, 20);
            this.nmMinutes.TabIndex = 1;
            this.nmMinutes.ValueChanged += new System.EventHandler(this.nmMinutes_ValueChanged);
            // 
            // nmSecond
            // 
            this.nmSecond.Location = new System.Drawing.Point(263, 48);
            this.nmSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmSecond.Name = "nmSecond";
            this.nmSecond.Size = new System.Drawing.Size(59, 20);
            this.nmSecond.TabIndex = 2;
            this.nmSecond.ValueChanged += new System.EventHandler(this.nmSecond_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phần mềm hẹn giờ tắt máy tính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(24, 92);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(75, 23);
            this.btnShutdown.TabIndex = 4;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(150, 92);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy lệnh";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phút";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giây";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 152);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.nmSecond);
            this.Controls.Add(this.nmMinutes);
            this.Controls.Add(this.nmHour);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hen Gio Tat May";
            ((System.ComponentModel.ISupportInitialize)(this.nmHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmHour;
        private System.Windows.Forms.NumericUpDown nmMinutes;
        private System.Windows.Forms.NumericUpDown nmSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

