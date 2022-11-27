
namespace HangMan
{
    partial class Settings
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
            this.soundLabel = new Guna.UI.WinForms.GunaLabel();
            this.soundState = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.difficulty = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundLabel.Location = new System.Drawing.Point(2, 9);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(144, 45);
            this.soundLabel.TabIndex = 0;
            this.soundLabel.Text = "Sound : ";
            // 
            // soundState
            // 
            this.soundState.AutoSize = true;
            this.soundState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundState.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundState.ForeColor = System.Drawing.Color.LawnGreen;
            this.soundState.Location = new System.Drawing.Point(130, 9);
            this.soundState.Name = "soundState";
            this.soundState.Size = new System.Drawing.Size(147, 45);
            this.soundState.TabIndex = 1;
            this.soundState.Text = "Enabled";
            this.soundState.Click += new System.EventHandler(this.soundState_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(2, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(192, 45);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Difficulty : ";
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = true;
            this.difficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difficulty.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficulty.ForeColor = System.Drawing.Color.LawnGreen;
            this.difficulty.Location = new System.Drawing.Point(183, 64);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(92, 45);
            this.difficulty.TabIndex = 3;
            this.difficulty.Text = "Easy";
            this.difficulty.Click += new System.EventHandler(this.difficulty_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(515, 124);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.soundState);
            this.Controls.Add(this.soundLabel);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel soundLabel;
        private Guna.UI.WinForms.GunaLabel soundState;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel difficulty;
    }
}