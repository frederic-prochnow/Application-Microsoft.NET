using System;

namespace MaSolution.Crud
{
    partial class PersonneDetailForm
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
            this.NomBox = new System.Windows.Forms.TextBox();
            this.PrenomBox = new System.Windows.Forms.TextBox();
            this.DateNaissanceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ValiderButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.NomLabel = new System.Windows.Forms.Label();
            this.PrenomLabel = new System.Windows.Forms.Label();
            this.DateNaissanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomBox
            // 
            this.NomBox.Location = new System.Drawing.Point(159, 22);
            this.NomBox.Name = "NomBox";
            this.NomBox.Size = new System.Drawing.Size(185, 20);
            this.NomBox.TabIndex = 0;
            this.PrenomBox.TextChanged += new System.EventHandler(this.NomBox_TextChanged);
            // 
            // PrenomBox
            // 
            this.PrenomBox.Location = new System.Drawing.Point(159, 48);
            this.PrenomBox.Name = "PrenomBox";
            this.PrenomBox.Size = new System.Drawing.Size(185, 20);
            this.PrenomBox.TabIndex = 1;
            this.PrenomBox.TextChanged += new System.EventHandler(this.PrenomBox_TextChanged);
            // 
            // DateNaissanceTimePicker
            // 
            this.DateNaissanceTimePicker.Location = new System.Drawing.Point(159, 74);
            this.DateNaissanceTimePicker.Name = "DateNaissanceTimePicker";
            this.DateNaissanceTimePicker.Size = new System.Drawing.Size(185, 20);
            this.DateNaissanceTimePicker.TabIndex = 2;

            // 
            // ValiderButton
            // 
            this.ValiderButton.Location = new System.Drawing.Point(269, 112);
            this.ValiderButton.Name = "ValiderButton";
            this.ValiderButton.Size = new System.Drawing.Size(75, 23);
            this.ValiderButton.TabIndex = 3;
            this.ValiderButton.Text = "Valider";
            this.ValiderButton.UseVisualStyleBackColor = true;
            this.ValiderButton.Click += new System.EventHandler(this.ValiderButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Location = new System.Drawing.Point(353, 112);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(75, 23);
            this.AnnulerButton.TabIndex = 4;
            this.AnnulerButton.TabStop = false;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(111, 29);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(32, 13);
            this.NomLabel.TabIndex = 5;
            this.NomLabel.Text = "Nom:";
            this.NomLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.AutoSize = true;
            this.PrenomLabel.Location = new System.Drawing.Point(97, 55);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(46, 13);
            this.PrenomLabel.TabIndex = 6;
            this.PrenomLabel.Text = "Prénom:";
            // 
            // DateNaissanceLabel
            // 
            this.DateNaissanceLabel.AutoSize = true;
            this.DateNaissanceLabel.Location = new System.Drawing.Point(39, 81);
            this.DateNaissanceLabel.Name = "DateNaissanceLabel";
            this.DateNaissanceLabel.Size = new System.Drawing.Size(104, 13);
            this.DateNaissanceLabel.TabIndex = 7;
            this.DateNaissanceLabel.Text = "Date de Naissance :";
            // 
            // PersonneDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 147);
            this.Controls.Add(this.DateNaissanceLabel);
            this.Controls.Add(this.PrenomLabel);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.ValiderButton);
            this.Controls.Add(this.DateNaissanceTimePicker);
            this.Controls.Add(this.PrenomBox);
            this.Controls.Add(this.NomBox);
            this.Name = "PersonneDetailForm";
            this.Text = "Detail d\'une personne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox NomBox;
        private System.Windows.Forms.TextBox PrenomBox;
        private System.Windows.Forms.DateTimePicker DateNaissanceTimePicker;
        private System.Windows.Forms.Button ValiderButton;
        private System.Windows.Forms.Button AnnulerButton;
        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.Label PrenomLabel;
        private System.Windows.Forms.Label DateNaissanceLabel;
    }
}