﻿namespace MathsTutor
{
    partial class frmSquare
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
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(232, 55);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(73, 20);
            this.txtLength.TabIndex = 0;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(64, 58);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(151, 13);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length of Side of Square (cm):";
            this.lblLength.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(64, 236);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 13);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area =";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(64, 178);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(146, 106);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(98, 49);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // frmSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 325);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Name = "frmSquare";
            this.Text = "SquareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnArea;
    }
}