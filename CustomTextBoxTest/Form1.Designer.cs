﻿namespace CustomTextBoxTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.customAutoCompleteTextBox1 = new CustomTextBoxTest.CustomAutoCompleteTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customAutoCompleteTextBox1
            // 
            this.customAutoCompleteTextBox1.ForeColor = System.Drawing.Color.Red;
            this.customAutoCompleteTextBox1.FuzzyAutoCompleteSource = ((System.Collections.Generic.List<string>)(resources.GetObject("customAutoCompleteTextBox1.FuzzyAutoCompleteSource")));
            this.customAutoCompleteTextBox1.Location = new System.Drawing.Point(9, 9);
            this.customAutoCompleteTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.customAutoCompleteTextBox1.Name = "customAutoCompleteTextBox1";
            this.customAutoCompleteTextBox1.Size = new System.Drawing.Size(430, 20);
            this.customAutoCompleteTextBox1.TabIndex = 2;
            this.customAutoCompleteTextBox1.UsedAutoCompleteMode = CustomTextBoxTest.CustomAutoCompleteTextBox.AutoCompleteMode.Index;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customAutoCompleteTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomAutoCompleteTextBox customAutoCompleteTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

