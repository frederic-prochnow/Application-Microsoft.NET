namespace MaSolution4.Crud
{
    partial class MainForm
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
            this.AjouterPersonneButton = new System.Windows.Forms.Button();
            this.ModifierButton = new System.Windows.Forms.Button();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.PersonneListBox = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AjouterPersonneButton
            // 
            this.AjouterPersonneButton.Location = new System.Drawing.Point(267, 23);
            this.AjouterPersonneButton.Name = "AjouterPersonneButton";
            this.AjouterPersonneButton.Size = new System.Drawing.Size(75, 23);
            this.AjouterPersonneButton.TabIndex = 0;
            this.AjouterPersonneButton.Text = "Ajouter";
            this.AjouterPersonneButton.UseVisualStyleBackColor = true;
            this.AjouterPersonneButton.Click += new System.EventHandler(this.AjouterPersonneButton_Click);
            // 
            // ModifierButton
            // 
            this.ModifierButton.Location = new System.Drawing.Point(267, 53);
            this.ModifierButton.Name = "ModifierButton";
            this.ModifierButton.Size = new System.Drawing.Size(75, 23);
            this.ModifierButton.TabIndex = 1;
            this.ModifierButton.Text = "Modifier";
            this.ModifierButton.UseVisualStyleBackColor = true;
            this.ModifierButton.Click += new System.EventHandler(this.ModifierButton_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.Location = new System.Drawing.Point(267, 83);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(75, 23);
            this.SupprimerButton.TabIndex = 2;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = true;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // PersonneListBox
            // 
            this.PersonneListBox.FormattingEnabled = true;
            this.PersonneListBox.Location = new System.Drawing.Point(21, 53);
            this.PersonneListBox.Name = "PersonneListBox";
            this.PersonneListBox.Size = new System.Drawing.Size(230, 355);
            this.PersonneListBox.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(21, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(139, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Personnes (Nom et Prénom)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 428);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PersonneListBox);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.ModifierButton);
            this.Controls.Add(this.AjouterPersonneButton);
            this.Name = "MainForm";
            this.Text = "Liste des personnes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AjouterPersonneButton;
        private System.Windows.Forms.Button ModifierButton;
        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.ListBox PersonneListBox;
        private System.Windows.Forms.Label label;
    }
}