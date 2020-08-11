namespace NisargAssignment2
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
            this.exitButton = new System.Windows.Forms.Button();
            this.totalSalesButton = new System.Windows.Forms.Button();
            this.rpsGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1005, 53);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(220, 68);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalSalesButton
            // 
            this.totalSalesButton.Location = new System.Drawing.Point(703, 272);
            this.totalSalesButton.Name = "totalSalesButton";
            this.totalSalesButton.Size = new System.Drawing.Size(522, 169);
            this.totalSalesButton.TabIndex = 1;
            this.totalSalesButton.Text = "Total Sales and Analysis";
            this.totalSalesButton.UseVisualStyleBackColor = true;
            this.totalSalesButton.Click += new System.EventHandler(this.totalSalesButton_Click);
            // 
            // rpsGameButton
            // 
            this.rpsGameButton.Location = new System.Drawing.Point(45, 272);
            this.rpsGameButton.Name = "rpsGameButton";
            this.rpsGameButton.Size = new System.Drawing.Size(546, 169);
            this.rpsGameButton.TabIndex = 2;
            this.rpsGameButton.Text = "Rock, Paper, Scissors game";
            this.rpsGameButton.UseVisualStyleBackColor = true;
            this.rpsGameButton.Click += new System.EventHandler(this.rpsGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 617);
            this.Controls.Add(this.rpsGameButton);
            this.Controls.Add(this.totalSalesButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button totalSalesButton;
        private System.Windows.Forms.Button rpsGameButton;
    }
}

