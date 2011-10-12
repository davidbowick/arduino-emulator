namespace ArduinoEmulator.UC
{
    partial class UC_AnalogPin
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
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            this._checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _numericUpDown
            // 
            this._numericUpDown.Location = new System.Drawing.Point(47, 0);
            this._numericUpDown.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this._numericUpDown.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(47, 20);
            this._numericUpDown.TabIndex = 0;
            this._numericUpDown.ValueChanged += new System.EventHandler(this._numericUpDown_ValueChanged);
            // 
            // _checkBox
            // 
            this._checkBox.AutoCheck = false;
            this._checkBox.AutoSize = true;
            this._checkBox.Checked = true;
            this._checkBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this._checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._checkBox.Location = new System.Drawing.Point(0, 0);
            this._checkBox.Name = "_checkBox";
            this._checkBox.Size = new System.Drawing.Size(43, 17);
            this._checkBox.TabIndex = 2;
            this._checkBox.Text = "A00";
            this._checkBox.UseVisualStyleBackColor = true;
            this._checkBox.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this._checkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseDown);
            this._checkBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseUp);
            // 
            // UC_AnalogPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._checkBox);
            this.Controls.Add(this._numericUpDown);
            this.Name = "UC_AnalogPin";
            this.Size = new System.Drawing.Size(94, 20);
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _numericUpDown;
        internal System.Windows.Forms.CheckBox _checkBox;
    }
}
