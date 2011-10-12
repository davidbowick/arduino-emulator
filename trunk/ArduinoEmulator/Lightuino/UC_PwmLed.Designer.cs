namespace ArduinoEmulator.Lightuino
{
    partial class UC_PwmLed
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._led = new System.Windows.Forms.RadioButton();
            this._label = new System.Windows.Forms.Label();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // _led
            // 
            this._led.Appearance = System.Windows.Forms.Appearance.Button;
            this._led.AutoCheck = false;
            this._led.Checked = true;
            this._led.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this._led.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._led.Location = new System.Drawing.Point(3, 3);
            this._led.Name = "_led";
            this._led.Size = new System.Drawing.Size(13, 13);
            this._led.TabIndex = 2;
            this._led.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._led.UseVisualStyleBackColor = true;
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label.Location = new System.Drawing.Point(22, 3);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(19, 13);
            this._label.TabIndex = 3;
            this._label.Text = "00";
            // 
            // _toolTip
            // 
            this._toolTip.AutoPopDelay = 5000;
            this._toolTip.InitialDelay = 50;
            this._toolTip.ReshowDelay = 0;
            this._toolTip.ShowAlways = true;
            this._toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._toolTip.ToolTipTitle = "Value :";
            this._toolTip.UseAnimation = false;
            this._toolTip.UseFading = false;
            // 
            // UC_PwmLed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._label);
            this.Controls.Add(this._led);
            this.Name = "UC_PwmLed";
            this.Size = new System.Drawing.Size(44, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton _led;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.ToolTip _toolTip;
    }
}
