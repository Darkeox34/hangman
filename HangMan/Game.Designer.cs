
namespace HangMan
{
    partial class Game
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
            this.wordToBeGuessed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordToBeGuessed
            // 
            this.wordToBeGuessed.AutoSize = true;
            this.wordToBeGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordToBeGuessed.Location = new System.Drawing.Point(-4, 9);
            this.wordToBeGuessed.Name = "wordToBeGuessed";
            this.wordToBeGuessed.Size = new System.Drawing.Size(210, 73);
            this.wordToBeGuessed.TabIndex = 0;
            this.wordToBeGuessed.Text = "label1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(690, 540);
            this.Controls.Add(this.wordToBeGuessed);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordToBeGuessed;
    }
}