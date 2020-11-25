namespace LogScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.lbIP = new System.Windows.Forms.ListBox();
            this.browse = new System.Windows.Forms.Button();
            this.btcopy = new System.Windows.Forms.Button();
            this.tbfilename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbIP
            // 
            this.lbIP.FormattingEnabled = true;
            this.lbIP.Location = new System.Drawing.Point(96, 41);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(159, 160);
            this.lbIP.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(12, 12);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 3;
            this.browse.Text = "browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // btcopy
            // 
            this.btcopy.BackColor = System.Drawing.Color.Transparent;
            this.btcopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcopy.BackgroundImage")));
            this.btcopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btcopy.ForeColor = System.Drawing.Color.Transparent;
            this.btcopy.Image = ((System.Drawing.Image)(resources.GetObject("btcopy.Image")));
            this.btcopy.Location = new System.Drawing.Point(58, 70);
            this.btcopy.Name = "btcopy";
            this.btcopy.Size = new System.Drawing.Size(29, 27);
            this.btcopy.TabIndex = 5;
            this.btcopy.UseVisualStyleBackColor = false;
            this.btcopy.Click += new System.EventHandler(this.btcopy_Click);
            // 
            // tbfilename
            // 
            this.tbfilename.BackColor = System.Drawing.Color.White;
            this.tbfilename.Location = new System.Drawing.Point(96, 14);
            this.tbfilename.Name = "tbfilename";
            this.tbfilename.ReadOnly = true;
            this.tbfilename.Size = new System.Drawing.Size(159, 20);
            this.tbfilename.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 212);
            this.Controls.Add(this.tbfilename);
            this.Controls.Add(this.btcopy);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbIP;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button btcopy;
        private System.Windows.Forms.TextBox tbfilename;
    }
}

