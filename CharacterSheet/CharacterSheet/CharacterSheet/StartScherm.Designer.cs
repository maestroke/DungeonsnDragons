﻿namespace CharacterSheet {
    partial class StartScherm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScherm));
            this.newCharacterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCharacterButton
            // 
            this.newCharacterButton.Location = new System.Drawing.Point(112, 71);
            this.newCharacterButton.Name = "newCharacterButton";
            this.newCharacterButton.Size = new System.Drawing.Size(100, 23);
            this.newCharacterButton.TabIndex = 0;
            this.newCharacterButton.Text = "New Character";
            this.newCharacterButton.UseVisualStyleBackColor = true;
            this.newCharacterButton.Click += new System.EventHandler(this.newCharacterButton_Click);
            // 
            // StartScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.newCharacterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartScherm";
            this.Text = "Dungeons & Dragons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newCharacterButton;
    }
}

