namespace ListBoxListingNonStringObjects
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTopSpeed = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSedan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTopSpeed
            // 
            this.lblTopSpeed.AutoSize = true;
            this.lblTopSpeed.Location = new System.Drawing.Point(12, 318);
            this.lblTopSpeed.Name = "lblTopSpeed";
            this.lblTopSpeed.Size = new System.Drawing.Size(63, 13);
            this.lblTopSpeed.TabIndex = 1;
            this.lblTopSpeed.Tag = "Top Speed:";
            this.lblTopSpeed.Text = "Top Speed:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 343);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Tag = "Color:";
            this.lblColor.Text = "Color:";
            // 
            // lblSedan
            // 
            this.lblSedan.AutoSize = true;
            this.lblSedan.Location = new System.Drawing.Point(12, 368);
            this.lblSedan.Name = "lblSedan";
            this.lblSedan.Size = new System.Drawing.Size(52, 13);
            this.lblSedan.TabIndex = 3;
            this.lblSedan.Tag = "Is Sedan:";
            this.lblSedan.Text = "Is Sedan:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 390);
            this.Controls.Add(this.lblSedan);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTopSpeed);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTopSpeed;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSedan;
    }
}

