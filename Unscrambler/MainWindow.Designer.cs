namespace scrabbleMoreAble
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScrambledTextBox = new System.Windows.Forms.TextBox();
            this.UnscrambleButton = new System.Windows.Forms.Button();
            this.FoundWordsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScrambledTextBox
            // 
            this.ScrambledTextBox.Location = new System.Drawing.Point(12, 12);
            this.ScrambledTextBox.Name = "ScrambledTextBox";
            this.ScrambledTextBox.Size = new System.Drawing.Size(227, 20);
            this.ScrambledTextBox.TabIndex = 0;
            // 
            // UnscrambleButton
            // 
            this.UnscrambleButton.Location = new System.Drawing.Point(12, 38);
            this.UnscrambleButton.Name = "UnscrambleButton";
            this.UnscrambleButton.Size = new System.Drawing.Size(227, 39);
            this.UnscrambleButton.TabIndex = 1;
            this.UnscrambleButton.Text = "Unscramble";
            this.UnscrambleButton.UseVisualStyleBackColor = true;
            this.UnscrambleButton.Click += new System.EventHandler(this.UnscrambleButton_Click);
            // 
            // FoundWordsTextBox
            // 
            this.FoundWordsTextBox.Location = new System.Drawing.Point(12, 83);
            this.FoundWordsTextBox.Multiline = true;
            this.FoundWordsTextBox.Name = "FoundWordsTextBox";
            this.FoundWordsTextBox.Size = new System.Drawing.Size(227, 250);
            this.FoundWordsTextBox.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 345);
            this.Controls.Add(this.FoundWordsTextBox);
            this.Controls.Add(this.UnscrambleButton);
            this.Controls.Add(this.ScrambledTextBox);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Words Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScrambledTextBox;
        private System.Windows.Forms.Button UnscrambleButton;
        private System.Windows.Forms.TextBox FoundWordsTextBox;
    }
}

