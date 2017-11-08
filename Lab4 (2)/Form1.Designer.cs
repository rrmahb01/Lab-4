namespace Lab4__2_
{
    partial class acceptOrReject
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
            this.decideButton = new System.Windows.Forms.Button();
            this.acceptTotalLabel = new System.Windows.Forms.Label();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.rejectTotalLabel = new System.Windows.Forms.Label();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.acceptLabel = new System.Windows.Forms.Label();
            this.rejectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decideButton
            // 
            this.decideButton.Location = new System.Drawing.Point(164, 129);
            this.decideButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decideButton.Name = "decideButton";
            this.decideButton.Size = new System.Drawing.Size(112, 35);
            this.decideButton.TabIndex = 0;
            this.decideButton.Text = "Decide";
            this.decideButton.UseVisualStyleBackColor = true;
            this.decideButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // acceptTotalLabel
            // 
            this.acceptTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptTotalLabel.Location = new System.Drawing.Point(144, 203);
            this.acceptTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acceptTotalLabel.Name = "acceptTotalLabel";
            this.acceptTotalLabel.Size = new System.Drawing.Size(149, 34);
            this.acceptTotalLabel.TabIndex = 1;
            this.acceptTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(254, 18);
            this.gpaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(148, 26);
            this.gpaTextBox.TabIndex = 2;
            this.gpaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rejectTotalLabel
            // 
            this.rejectTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectTotalLabel.Location = new System.Drawing.Point(144, 255);
            this.rejectTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rejectTotalLabel.Name = "rejectTotalLabel";
            this.rejectTotalLabel.Size = new System.Drawing.Size(149, 34);
            this.rejectTotalLabel.TabIndex = 3;
            this.rejectTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(254, 58);
            this.testTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(148, 26);
            this.testTextBox.TabIndex = 4;
            this.testTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(54, 23);
            this.gpaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(188, 20);
            this.gpaLabel.TabIndex = 5;
            this.gpaLabel.Text = "Enter your GPA ( i.e. 3.0 )";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(18, 63);
            this.testLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(223, 20);
            this.testLabel.TabIndex = 6;
            this.testLabel.Text = "Enter your Test Score ( i.e 70 )";
            // 
            // acceptLabel
            // 
            this.acceptLabel.AutoSize = true;
            this.acceptLabel.Location = new System.Drawing.Point(54, 218);
            this.acceptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acceptLabel.Name = "acceptLabel";
            this.acceptLabel.Size = new System.Drawing.Size(59, 20);
            this.acceptLabel.TabIndex = 7;
            this.acceptLabel.Text = "Accept";
            // 
            // rejectLabel
            // 
            this.rejectLabel.AutoSize = true;
            this.rejectLabel.Location = new System.Drawing.Point(58, 271);
            this.rejectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rejectLabel.Name = "rejectLabel";
            this.rejectLabel.Size = new System.Drawing.Size(55, 20);
            this.rejectLabel.TabIndex = 8;
            this.rejectLabel.Text = "Reject";
            // 
            // acceptOrReject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 322);
            this.Controls.Add(this.rejectLabel);
            this.Controls.Add(this.acceptLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.rejectTotalLabel);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.acceptTotalLabel);
            this.Controls.Add(this.decideButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "acceptOrReject";
            this.Text = "Accept or Reject";
            this.Load += new System.EventHandler(this.acceptOrReject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decideButton;
        private System.Windows.Forms.Label acceptTotalLabel;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.Label rejectTotalLabel;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label acceptLabel;
        private System.Windows.Forms.Label rejectLabel;
    }
}

