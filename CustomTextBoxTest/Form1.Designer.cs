namespace CustomTextBoxTest
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.regExAutocompleteTextBox1 = new CustomTextBoxTest.RegExAutocompleteTextBox();
            this.SuspendLayout();
            // 
            // regExAutocompleteTextBox1
            // 
            this.regExAutocompleteTextBox1.Location = new System.Drawing.Point(13, 13);
            this.regExAutocompleteTextBox1.Name = "regExAutocompleteTextBox1";
            this.regExAutocompleteTextBox1.Size = new System.Drawing.Size(423, 20);
            this.regExAutocompleteTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 45);
            this.Controls.Add(this.regExAutocompleteTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegExAutocompleteTextBox regExAutocompleteTextBox1;
    }
}

