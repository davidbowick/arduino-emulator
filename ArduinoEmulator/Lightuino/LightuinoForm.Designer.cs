﻿namespace ArduinoEmulator.Lightuino
{
    partial class LightuinoForm
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
            this._panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._panel.Location = new System.Drawing.Point(12, 81);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(728, 140);
            this._panel.TabIndex = 0;
            // 
            // LightuinoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 233);
            this.Controls.Add(this._panel);
            this.Name = "LightuinoForm";
            this.Text = "Lightuino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LightuinoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _panel;

    }
}