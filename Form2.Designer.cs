namespace DataBaseTest
{
    partial class Form2
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
            this.nomerLabel = new System.Windows.Forms.Label();
            this.vladelecLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nomerText = new System.Windows.Forms.TextBox();
            this.vladelecText = new System.Windows.Forms.TextBox();
            this.vozrastLabel = new System.Windows.Forms.Label();
            this.markaLabel = new System.Windows.Forms.Label();
            this.vozrastText = new System.Windows.Forms.TextBox();
            this.markaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nomerLabel
            // 
            this.nomerLabel.AutoSize = true;
            this.nomerLabel.Location = new System.Drawing.Point(120, 79);
            this.nomerLabel.Name = "nomerLabel";
            this.nomerLabel.Size = new System.Drawing.Size(38, 13);
            this.nomerLabel.TabIndex = 0;
            this.nomerLabel.Text = "Nomer";
            // 
            // vladelecLabel
            // 
            this.vladelecLabel.AutoSize = true;
            this.vladelecLabel.Location = new System.Drawing.Point(117, 179);
            this.vladelecLabel.Name = "vladelecLabel";
            this.vladelecLabel.Size = new System.Drawing.Size(48, 13);
            this.vladelecLabel.TabIndex = 1;
            this.vladelecLabel.Text = "Vladelec";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(85, 243);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(303, 243);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // nomerText
            // 
            this.nomerText.Location = new System.Drawing.Point(313, 76);
            this.nomerText.Name = "nomerText";
            this.nomerText.Size = new System.Drawing.Size(100, 20);
            this.nomerText.TabIndex = 4;
            // 
            // vladelecText
            // 
            this.vladelecText.Location = new System.Drawing.Point(313, 176);
            this.vladelecText.Name = "vladelecText";
            this.vladelecText.Size = new System.Drawing.Size(100, 20);
            this.vladelecText.TabIndex = 5;
            // 
            // vozrastLabel
            // 
            this.vozrastLabel.AutoSize = true;
            this.vozrastLabel.Location = new System.Drawing.Point(120, 115);
            this.vozrastLabel.Name = "vozrastLabel";
            this.vozrastLabel.Size = new System.Drawing.Size(42, 13);
            this.vozrastLabel.TabIndex = 6;
            this.vozrastLabel.Text = "Vozrast";
            // 
            // markaLabel
            // 
            this.markaLabel.AutoSize = true;
            this.markaLabel.Location = new System.Drawing.Point(120, 153);
            this.markaLabel.Name = "markaLabel";
            this.markaLabel.Size = new System.Drawing.Size(37, 13);
            this.markaLabel.TabIndex = 7;
            this.markaLabel.Text = "Marka";
            // 
            // vozrastText
            // 
            this.vozrastText.Location = new System.Drawing.Point(313, 112);
            this.vozrastText.Name = "vozrastText";
            this.vozrastText.Size = new System.Drawing.Size(100, 20);
            this.vozrastText.TabIndex = 8;
            // 
            // markaText
            // 
            this.markaText.Location = new System.Drawing.Point(313, 150);
            this.markaText.Name = "markaText";
            this.markaText.Size = new System.Drawing.Size(100, 20);
            this.markaText.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 310);
            this.Controls.Add(this.markaText);
            this.Controls.Add(this.vozrastText);
            this.Controls.Add(this.markaLabel);
            this.Controls.Add(this.vozrastLabel);
            this.Controls.Add(this.vladelecText);
            this.Controls.Add(this.nomerText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.vladelecLabel);
            this.Controls.Add(this.nomerLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomerLabel;
        private System.Windows.Forms.Label vladelecLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox nomerText;
        private System.Windows.Forms.TextBox vladelecText;
        private System.Windows.Forms.Label vozrastLabel;
        private System.Windows.Forms.Label markaLabel;
        private System.Windows.Forms.TextBox vozrastText;
        private System.Windows.Forms.TextBox markaText;
    }
}