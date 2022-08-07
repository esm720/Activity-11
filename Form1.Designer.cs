namespace Activity_11
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
            this.RollDiceButton = new System.Windows.Forms.Button();
            this.Dice1Label = new System.Windows.Forms.Label();
            this.Dice2Label = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RollDiceButton
            // 
            this.RollDiceButton.Location = new System.Drawing.Point(48, 68);
            this.RollDiceButton.Name = "RollDiceButton";
            this.RollDiceButton.Size = new System.Drawing.Size(163, 118);
            this.RollDiceButton.TabIndex = 0;
            this.RollDiceButton.Text = "Roll Dice";
            this.RollDiceButton.UseVisualStyleBackColor = true;
            this.RollDiceButton.Click += new System.EventHandler(this.RollDiceButton_Click);
            // 
            // Dice1Label
            // 
            this.Dice1Label.BackColor = System.Drawing.Color.Green;
            this.Dice1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice1Label.Location = new System.Drawing.Point(276, 64);
            this.Dice1Label.Name = "Dice1Label";
            this.Dice1Label.Size = new System.Drawing.Size(146, 122);
            this.Dice1Label.TabIndex = 1;
            this.Dice1Label.Text = "0";
            this.Dice1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dice2Label
            // 
            this.Dice2Label.BackColor = System.Drawing.Color.Green;
            this.Dice2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice2Label.Location = new System.Drawing.Point(485, 68);
            this.Dice2Label.Name = "Dice2Label";
            this.Dice2Label.Size = new System.Drawing.Size(146, 122);
            this.Dice2Label.TabIndex = 2;
            this.Dice2Label.Text = "0";
            this.Dice2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(283, 230);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(142, 60);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.RollDiceButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(698, 320);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Dice2Label);
            this.Controls.Add(this.Dice1Label);
            this.Controls.Add(this.RollDiceButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RollDiceButton;
        private System.Windows.Forms.Label Dice1Label;
        private System.Windows.Forms.Label Dice2Label;
        private System.Windows.Forms.Button ExitButton;
    }
}

