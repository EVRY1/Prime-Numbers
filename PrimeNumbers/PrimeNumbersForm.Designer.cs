﻿namespace PrimeNumbers
{
    partial class PrimeNumbersApp
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
            this.components = new System.ComponentModel.Container();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.NumberText = new System.Windows.Forms.TextBox();
            this.BackgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.VerifyText = new System.Windows.Forms.Label();
            this.VerifyTextTick = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // VerifyButton
            // 
            this.VerifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VerifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyButton.Location = new System.Drawing.Point(12, 371);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(776, 67);
            this.VerifyButton.TabIndex = 0;
            this.VerifyButton.Text = "Verify";
            this.VerifyButton.UseVisualStyleBackColor = true;
            // 
            // NumberText
            // 
            this.NumberText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberText.Location = new System.Drawing.Point(12, 12);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(776, 67);
            this.NumberText.TabIndex = 1;
            this.NumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackgroundTimer
            // 
            this.BackgroundTimer.Interval = 1500;
            this.BackgroundTimer.Tick += new System.EventHandler(this.BackgroundTimer_Tick);
            // 
            // VerifyText
            // 
            this.VerifyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VerifyText.BackColor = System.Drawing.Color.Transparent;
            this.VerifyText.Font = new System.Drawing.Font("Segoe Print", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyText.Location = new System.Drawing.Point(12, 130);
            this.VerifyText.Name = "VerifyText";
            this.VerifyText.Size = new System.Drawing.Size(776, 67);
            this.VerifyText.TabIndex = 3;
            this.VerifyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerifyTextTick
            // 
            this.VerifyTextTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VerifyTextTick.Appearance = System.Windows.Forms.Appearance.Button;
            this.VerifyTextTick.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VerifyTextTick.Location = new System.Drawing.Point(756, 333);
            this.VerifyTextTick.Name = "VerifyTextTick";
            this.VerifyTextTick.Size = new System.Drawing.Size(32, 32);
            this.VerifyTextTick.TabIndex = 4;
            this.VerifyTextTick.UseVisualStyleBackColor = true;
            this.VerifyTextTick.CheckedChanged += new System.EventHandler(this.VerifyTextTick_CheckedChanged);
            // 
            // PrimeNumbersApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerifyTextTick);
            this.Controls.Add(this.VerifyText);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.VerifyButton);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "PrimeNumbersApp";
            this.Text = "Verificare Numere Prime";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimeNumbersApp_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.TextBox NumberText;
        private System.Windows.Forms.Timer BackgroundTimer;
        private System.Windows.Forms.Label VerifyText;
        private System.Windows.Forms.CheckBox VerifyTextTick;
    }
}

