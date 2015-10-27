namespace twozerofoureight
{
    partial class TwoZeroFourEightScoreView
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
            this.iii = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblscoree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iii
            // 
            this.iii.AutoSize = true;
            this.iii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.iii.Location = new System.Drawing.Point(81, 122);
            this.iii.Name = "iii";
            this.iii.Size = new System.Drawing.Size(61, 17);
            this.iii.TabIndex = 0;
            this.iii.Text = "Score  ::";
            this.iii.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblscoree
            // 
            this.lblscoree.AutoSize = true;
            this.lblscoree.Location = new System.Drawing.Point(160, 125);
            this.lblscoree.Name = "lblscoree";
            this.lblscoree.Size = new System.Drawing.Size(13, 13);
            this.lblscoree.TabIndex = 2;
            this.lblscoree.Text = "4";
            // 
            // TwoZeroFourEightScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblscoree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iii);
            this.Name = "TwoZeroFourEightScoreView";
            this.Text = "TwoZeroFourEightScoreView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblscoree;
    }
}