namespace Cloubs_Chooser
{
    partial class sendtextchat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendtextchat));
            this.leaveorjoinButton = new System.Windows.Forms.Button();
            this.statuslabel = new System.Windows.Forms.Label();
            this.connectedstatuslabel = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // leaveorjoinButton
            // 
            this.leaveorjoinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveorjoinButton.Location = new System.Drawing.Point(209, -3);
            this.leaveorjoinButton.Name = "leaveorjoinButton";
            this.leaveorjoinButton.Size = new System.Drawing.Size(141, 42);
            this.leaveorjoinButton.TabIndex = 0;
            this.leaveorjoinButton.Text = "Join";
            this.leaveorjoinButton.UseVisualStyleBackColor = true;
            this.leaveorjoinButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Location = new System.Drawing.Point(3, 13);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(131, 17);
            this.statuslabel.TabIndex = 1;
            this.statuslabel.Text = "Status:Not included";
            // 
            // connectedstatuslabel
            // 
            this.connectedstatuslabel.AutoSize = true;
            this.connectedstatuslabel.Location = new System.Drawing.Point(3, 41);
            this.connectedstatuslabel.Name = "connectedstatuslabel";
            this.connectedstatuslabel.Size = new System.Drawing.Size(173, 17);
            this.connectedstatuslabel.TabIndex = 2;
            this.connectedstatuslabel.Text = "Connection: Disconnected";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(6, 114);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(99, 35);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Visible = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(6, 73);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(99, 35);
            this.disconnect.TabIndex = 4;
            this.disconnect.Text = "Disonnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Visible = false;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "<Server> Player joined"});
            this.listBox1.Location = new System.Drawing.Point(168, 248);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 244);
            this.listBox1.TabIndex = 5;
            // 
            // send
            // 
            this.send.Enabled = false;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(528, 498);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(79, 40);
            this.send.TabIndex = 6;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 507);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 7;
            // 
            // sendtextchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 541);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.connectedstatuslabel);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.leaveorjoinButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sendtextchat";
            this.Text = "Informacje o klubie";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leaveorjoinButton;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label connectedstatuslabel;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textBox1;
    }
}