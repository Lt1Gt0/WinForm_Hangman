namespace Hangman_Form
{
    partial class game
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
            this.lblCurrentGuess = new System.Windows.Forms.Label();
            this.txtPlayerInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCurrentGuess
            // 
            this.lblCurrentGuess.AutoSize = true;
            this.lblCurrentGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentGuess.Location = new System.Drawing.Point(84, 43);
            this.lblCurrentGuess.Name = "lblCurrentGuess";
            this.lblCurrentGuess.Size = new System.Drawing.Size(13, 18);
            this.lblCurrentGuess.TabIndex = 0;
            this.lblCurrentGuess.Text = ".";
            // 
            // txtPlayerInput
            // 
            this.txtPlayerInput.Location = new System.Drawing.Point(66, 82);
            this.txtPlayerInput.Name = "txtPlayerInput";
            this.txtPlayerInput.Size = new System.Drawing.Size(148, 20);
            this.txtPlayerInput.TabIndex = 1;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 138);
            this.Controls.Add(this.txtPlayerInput);
            this.Controls.Add(this.lblCurrentGuess);
            this.Name = "game";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentGuess;
        private System.Windows.Forms.TextBox txtPlayerInput;
    }
}