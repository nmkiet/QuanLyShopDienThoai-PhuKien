﻿namespace DAL_BLL
{
    partial class OnlyKyTuSo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKyTuSo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtKyTuSo
            // 
            this.txtKyTuSo.Location = new System.Drawing.Point(15, 3);
            this.txtKyTuSo.Name = "txtKyTuSo";
            this.txtKyTuSo.Size = new System.Drawing.Size(137, 20);
            this.txtKyTuSo.TabIndex = 0;
            // 
            // OnlyKyTuSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtKyTuSo);
            this.Name = "OnlyKyTuSo";
            this.Size = new System.Drawing.Size(176, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKyTuSo;
    }
}