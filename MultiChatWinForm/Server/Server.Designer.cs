namespace Server
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.txbInputServer = new System.Windows.Forms.TextBox();
            this.btnSendServer = new System.Windows.Forms.Button();
            this.lvContentServer = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txbInputServer
            // 
            this.txbInputServer.Location = new System.Drawing.Point(6, 461);
            this.txbInputServer.Multiline = true;
            this.txbInputServer.Name = "txbInputServer";
            this.txbInputServer.Size = new System.Drawing.Size(250, 41);
            this.txbInputServer.TabIndex = 5;
            // 
            // btnSendServer
            // 
            this.btnSendServer.Location = new System.Drawing.Point(256, 459);
            this.btnSendServer.Name = "btnSendServer";
            this.btnSendServer.Size = new System.Drawing.Size(53, 44);
            this.btnSendServer.TabIndex = 4;
            this.btnSendServer.Text = "Send";
            this.btnSendServer.UseVisualStyleBackColor = true;
            this.btnSendServer.Click += new System.EventHandler(this.btnSendServer_Click);
            // 
            // lvContentServer
            // 
            this.lvContentServer.HideSelection = false;
            this.lvContentServer.Location = new System.Drawing.Point(6, 10);
            this.lvContentServer.Name = "lvContentServer";
            this.lvContentServer.Size = new System.Drawing.Size(303, 443);
            this.lvContentServer.TabIndex = 6;
            this.lvContentServer.UseCompatibleStateImageBehavior = false;
            this.lvContentServer.View = System.Windows.Forms.View.List;
            // 
            // Server
            // 
            this.AcceptButton = this.btnSendServer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 511);
            this.Controls.Add(this.lvContentServer);
            this.Controls.Add(this.txbInputServer);
            this.Controls.Add(this.btnSendServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInputServer;
        private System.Windows.Forms.Button btnSendServer;
        private System.Windows.Forms.ListView lvContentServer;
    }
}

