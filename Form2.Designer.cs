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
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.gpuppaLabel = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.grouppaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(269, 150);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(266, 191);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(269, 371);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(487, 371);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(462, 147);
            this.idText.Name = "idText";
            this.idText.ReadOnly = true;
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 4;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(462, 188);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(269, 74);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Age";
            // 
            // gpuppaLabel
            // 
            this.gpuppaLabel.AutoSize = true;
            this.gpuppaLabel.Location = new System.Drawing.Point(269, 112);
            this.gpuppaLabel.Name = "gpuppaLabel";
            this.gpuppaLabel.Size = new System.Drawing.Size(48, 13);
            this.gpuppaLabel.TabIndex = 7;
            this.gpuppaLabel.Text = "Grouppa";
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(462, 71);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 20);
            this.ageText.TabIndex = 8;
            // 
            // grouppaText
            // 
            this.grouppaText.Location = new System.Drawing.Point(462, 109);
            this.grouppaText.Name = "grouppaText";
            this.grouppaText.Size = new System.Drawing.Size(100, 20);
            this.grouppaText.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grouppaText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.gpuppaLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label gpuppaLabel;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox grouppaText;
    }
}