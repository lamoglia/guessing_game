namespace GuessingGame
{
    partial class ReadAnimalTraitForm
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
            this.label = new System.Windows.Forms.Label();
            this.animalTraitTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(176, 17);
            this.label.TabIndex = 0;
            this.label.Text = "A ______ but a does not...";
            // 
            // animalTraitTextBox
            // 
            this.animalTraitTextBox.Location = new System.Drawing.Point(12, 48);
            this.animalTraitTextBox.Name = "animalTraitTextBox";
            this.animalTraitTextBox.Size = new System.Drawing.Size(578, 22);
            this.animalTraitTextBox.TabIndex = 1;
            this.animalTraitTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.animalTraitTextBox_KeyUp);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(470, 85);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(120, 30);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ReadAnimalTraitForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 127);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.animalTraitTextBox);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReadAnimalTraitForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox animalTraitTextBox;
        private System.Windows.Forms.Button okButton;
    }
}