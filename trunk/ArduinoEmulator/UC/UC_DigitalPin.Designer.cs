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
            this._label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _checkBox
            // 
            this._checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this._checkBox.AutoCheck = false;
            this._checkBox.Enabled = false;
            this._checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._checkBox.Location = new System.Drawing.Point(3, 3);
            this._checkBox.Name = "_checkBox";
            this._checkBox.Size = new System.Drawing.Size(13, 13);
            this._checkBox.TabIndex = 1;
            this._checkBox.UseVisualStyleBackColor = true;
            this._checkBox.MouseLeave += new System.EventHandler(this._checkBox_MouseLeave);
            this._checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._checkBox_MouseDown);
            this._checkBox.CheckedChanged += new System.EventHandler(this._checkBox_CheckedChanged);
            this._checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this._checkBox_MouseUp);
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(22, 3);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(19, 13);
            this._label.TabIndex = 2;
            this._label.Text = "00";
            // 
            // UC_DigitalPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._label);
            this.Controls.Add(this._checkBox);
            this.Name = "UC_DigitalPin";
            this.Size = new System.Drawing.Size(46, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _checkBox;
        private System.Windows.Forms.Label _label;
    }
}
