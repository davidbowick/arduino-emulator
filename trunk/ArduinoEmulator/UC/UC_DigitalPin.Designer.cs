namespace ArduinoEmulator.UC
{
    partial class UC_DigitalPin
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
            this._checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _checkBox
            // 
            this._checkBox.AutoCheck = false;
            this._checkBox.AutoSize = true;
            this._checkBox.Enabled = false;
            this._checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._checkBox.Location = new System.Drawing.Point(0, 0);
            this._checkBox.Name = "_checkBox";
            this._checkBox.Size = new System.Drawing.Size(35, 17);
            this._checkBox.TabIndex = 1;
            this._checkBox.Text = "00";
            this._checkBox.UseVisualStyleBackColor = true;
            this._checkBox.MouseLeave += new System.EventHandler(this._checkBox_MouseLeave);
            this._checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._checkBox_MouseDown);
            this._checkBox.CheckedChanged += new System.EventHandler(this._checkBox_CheckedChanged);
            this._checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this._checkBox_MouseUp);
            // 
            // UC_DigitalPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._checkBox);
            this.Name = "UC_DigitalPin";
            this.Size = new System.Drawing.Size(38, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _checkBox;
    }
}
