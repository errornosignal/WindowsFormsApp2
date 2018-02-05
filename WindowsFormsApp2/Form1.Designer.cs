namespace WindowsFormsApp2
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
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.radiusALabel = new System.Windows.Forms.Label();
            this.radiusBLabel = new System.Windows.Forms.Label();
            this.radiusCLabel = new System.Windows.Forms.Label();
            this.RadiusATextBox = new System.Windows.Forms.TextBox();
            this.RadiusBTextBox = new System.Windows.Forms.TextBox();
            this.RadiusCTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(77, 19);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 56);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(28, 25);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(43, 13);
            this.radiusLabel.TabIndex = 0;
            this.radiusLabel.Text = "Radius:";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Enabled = false;
            this.volumeTextBox.Location = new System.Drawing.Point(77, 97);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.ReadOnly = true;
            this.volumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.volumeTextBox.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(93, 56);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(26, 104);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(45, 13);
            this.volumeLabel.TabIndex = 5;
            this.volumeLabel.Text = "Volume:";
            // 
            // radiusALabel
            // 
            this.radiusALabel.AutoSize = true;
            this.radiusALabel.Location = new System.Drawing.Point(201, 22);
            this.radiusALabel.Name = "radiusALabel";
            this.radiusALabel.Size = new System.Drawing.Size(34, 13);
            this.radiusALabel.TabIndex = 6;
            this.radiusALabel.Text = "rad a:";
            //this.radiusALabel.Click += new System.EventHandler(this.radiusALabel_Click);
            // 
            // radiusBLabel
            // 
            this.radiusBLabel.AutoSize = true;
            this.radiusBLabel.Location = new System.Drawing.Point(201, 56);
            this.radiusBLabel.Name = "radiusBLabel";
            this.radiusBLabel.Size = new System.Drawing.Size(34, 13);
            this.radiusBLabel.TabIndex = 7;
            this.radiusBLabel.Text = "rad b:";
            // 
            // radiusCLabel
            // 
            this.radiusCLabel.AutoSize = true;
            this.radiusCLabel.Location = new System.Drawing.Point(201, 89);
            this.radiusCLabel.Name = "radiusCLabel";
            this.radiusCLabel.Size = new System.Drawing.Size(34, 13);
            this.radiusCLabel.TabIndex = 8;
            this.radiusCLabel.Text = "rad c:";
            // 
            // RadiusATextBox
            // 
            this.RadiusATextBox.Location = new System.Drawing.Point(241, 15);
            this.RadiusATextBox.Name = "RadiusATextBox";
            this.RadiusATextBox.Size = new System.Drawing.Size(49, 20);
            this.RadiusATextBox.TabIndex = 9;
            // 
            // RadiusBTextBox
            // 
            this.RadiusBTextBox.Location = new System.Drawing.Point(241, 53);
            this.RadiusBTextBox.Name = "RadiusBTextBox";
            this.RadiusBTextBox.Size = new System.Drawing.Size(49, 20);
            this.RadiusBTextBox.TabIndex = 10;
            // 
            // RadiusCTextBox
            // 
            this.RadiusCTextBox.Location = new System.Drawing.Point(241, 89);
            this.RadiusCTextBox.Name = "RadiusCTextBox";
            this.RadiusCTextBox.Size = new System.Drawing.Size(49, 20);
            this.RadiusCTextBox.TabIndex = 11;
            // 
            // calculateButton2
            // 
            this.calculateButton2.Location = new System.Drawing.Point(204, 124);
            this.calculateButton2.Name = "calculateButton2";
            this.calculateButton2.Size = new System.Drawing.Size(75, 23);
            this.calculateButton2.TabIndex = 12;
            this.calculateButton2.Text = "Calculate";
            this.calculateButton2.UseVisualStyleBackColor = true;
            this.calculateButton2.Click += new System.EventHandler(this.calculateButton2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(321, 159);
            this.Controls.Add(this.calculateButton2);
            this.Controls.Add(this.RadiusCTextBox);
            this.Controls.Add(this.RadiusBTextBox);
            this.Controls.Add(this.RadiusATextBox);
            this.Controls.Add(this.radiusCLabel);
            this.Controls.Add(this.radiusBLabel);
            this.Controls.Add(this.radiusALabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.radiusTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label radiusALabel;
        private System.Windows.Forms.Label radiusBLabel;
        private System.Windows.Forms.Label radiusCLabel;
        private System.Windows.Forms.TextBox RadiusATextBox;
        private System.Windows.Forms.TextBox RadiusBTextBox;
        private System.Windows.Forms.TextBox RadiusCTextBox;
        private System.Windows.Forms.Button calculateButton2;
    }
}

