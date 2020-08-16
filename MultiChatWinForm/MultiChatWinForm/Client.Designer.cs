namespace MultiChatWinForm
{
    partial class frClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frClient));
            this.btnSendClient = new System.Windows.Forms.Button();
            this.txbInputClient = new System.Windows.Forms.TextBox();
            this.lvContentClient = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnSendClient
            // 
            this.btnSendClient.Location = new System.Drawing.Point(255, 461);
            this.btnSendClient.Name = "btnSendClient";
            this.btnSendClient.Size = new System.Drawing.Size(53, 44);
            this.btnSendClient.TabIndex = 1;
            this.btnSendClient.Text = "Send";
            this.btnSendClient.UseVisualStyleBackColor = true;
            this.btnSendClient.Click += new System.EventHandler(this.btnSendClient_Click);
            // 
            // txbInputClient
            // 
            this.txbInputClient.Location = new System.Drawing.Point(5, 463);
            this.txbInputClient.Multiline = true;
            this.txbInputClient.Name = "txbInputClient";
            this.txbInputClient.Size = new System.Drawing.Size(250, 41);
            this.txbInputClient.TabIndex = 2;
            // 
            // lvContentClient
            // 
            this.lvContentClient.HideSelection = false;
            this.lvContentClient.Location = new System.Drawing.Point(5, 12);
            this.lvContentClient.Name = "lvContentClient";
            this.lvContentClient.Size = new System.Drawing.Size(303, 443);
            this.lvContentClient.TabIndex = 3;
            this.lvContentClient.UseCompatibleStateImageBehavior = false;
            this.lvContentClient.View = System.Windows.Forms.View.List;
            // 
            // frClient
            // 
            this.AcceptButton = this.btnSendClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 511);
            this.Controls.Add(this.lvContentClient);
            this.Controls.Add(this.txbInputClient);
            this.Controls.Add(this.btnSendClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frClient";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frClient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSendClient;
        private System.Windows.Forms.TextBox txbInputClient;
        private System.Windows.Forms.ListView lvContentClient;
    }
}

