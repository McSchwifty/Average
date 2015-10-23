namespace Average
{
    partial class frmAverage
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnEnterNumber = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(153, 26);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Enter the next number 0 to 100\r\nEnter -1 to end";
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(13, 43);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(100, 20);
            this.txtNumbers.TabIndex = 1;
            // 
            // btnEnterNumber
            // 
            this.btnEnterNumber.Location = new System.Drawing.Point(12, 69);
            this.btnEnterNumber.Name = "btnEnterNumber";
            this.btnEnterNumber.Size = new System.Drawing.Size(101, 23);
            this.btnEnterNumber.TabIndex = 2;
            this.btnEnterNumber.Text = "Enter Number";
            this.btnEnterNumber.UseVisualStyleBackColor = true;
            this.btnEnterNumber.Click += new System.EventHandler(this.btnEnterNumber_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(13, 95);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(131, 13);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "The running average is: ...";
            // 
            // frmAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 120);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnEnterNumber);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmAverage";
            this.Text = "Average";
            this.Load += new System.EventHandler(this.frmAverage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnEnterNumber;
        private System.Windows.Forms.Label lblAverage;
    }
}

