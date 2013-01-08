namespace ArduinoEmulator
{
    partial class ArduinoEmulatorForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArduinoEmulatorForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.labelBoards = new System.Windows.Forms.ToolStripLabel();
            this._boardsCombo = new System.Windows.Forms.ToolStripComboBox();
            this._separator = new System.Windows.Forms.ToolStripSeparator();
            this.btn_start = new System.Windows.Forms.ToolStripButton();
            this.btn_reset = new System.Windows.Forms.ToolStripButton();
            this._digitalPinsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uC_DigitalPin1 = new ArduinoEmulator.UC.UC_DigitalPin();
            this._analogPinsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uC_AnalogPin1 = new ArduinoEmulator.UC.UC_AnalogPin();
            this.uC_AnalogPin2 = new ArduinoEmulator.UC.UC_AnalogPin();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip.SuspendLayout();
            this._digitalPinsPanel.SuspendLayout();
            this._analogPinsPanel.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelBoards,
            this._boardsCombo,
            this._separator,
            this.btn_start,
            this.btn_reset});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(554, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // labelBoards
            // 
            this.labelBoards.Name = "labelBoards";
            this.labelBoards.Size = new System.Drawing.Size(49, 22);
            this.labelBoards.Text = "Boards :";
            // 
            // _boardsCombo
            // 
            this._boardsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._boardsCombo.Name = "_boardsCombo";
            this._boardsCombo.Size = new System.Drawing.Size(121, 25);
            // 
            // _separator
            // 
            this._separator.Name = "_separator";
            this._separator.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_start
            // 
            this.btn_start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(35, 22);
            this.btn_start.Text = "Start";
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(39, 22);
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // _digitalPinsPanel
            // 
            this._digitalPinsPanel.BackColor = System.Drawing.Color.White;
            this._digitalPinsPanel.Controls.Add(this.uC_DigitalPin1);
            this._digitalPinsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._digitalPinsPanel.Location = new System.Drawing.Point(0, 0);
            this._digitalPinsPanel.Name = "_digitalPinsPanel";
            this._digitalPinsPanel.Size = new System.Drawing.Size(324, 130);
            this._digitalPinsPanel.TabIndex = 2;
            // 
            // uC_DigitalPin1
            // 
            this.uC_DigitalPin1.AutoSize = true;
            this.uC_DigitalPin1.BackColor = System.Drawing.Color.Transparent;
            this.uC_DigitalPin1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uC_DigitalPin1.ID = 0;
            this.uC_DigitalPin1.Location = new System.Drawing.Point(3, 3);
            this.uC_DigitalPin1.Name = "uC_DigitalPin1";
            this.uC_DigitalPin1.PinMode = Arduino.PinMode.NotInitialized;
            this.uC_DigitalPin1.PinNumber = 0;
            this.uC_DigitalPin1.Size = new System.Drawing.Size(44, 19);
            this.uC_DigitalPin1.TabIndex = 0;
            this.uC_DigitalPin1.Value = 0;
            // 
            // _analogPinsPanel
            // 
            this._analogPinsPanel.BackColor = System.Drawing.Color.White;
            this._analogPinsPanel.Controls.Add(this.uC_AnalogPin1);
            this._analogPinsPanel.Controls.Add(this.uC_AnalogPin2);
            this._analogPinsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._analogPinsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._analogPinsPanel.Location = new System.Drawing.Point(0, 0);
            this._analogPinsPanel.Name = "_analogPinsPanel";
            this._analogPinsPanel.Size = new System.Drawing.Size(222, 130);
            this._analogPinsPanel.TabIndex = 3;
            // 
            // uC_AnalogPin1
            // 
            this.uC_AnalogPin1.AutoSize = true;
            this.uC_AnalogPin1.BackColor = System.Drawing.Color.Transparent;
            this.uC_AnalogPin1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uC_AnalogPin1.ID = 0;
            this.uC_AnalogPin1.Location = new System.Drawing.Point(3, 3);
            this.uC_AnalogPin1.Name = "uC_AnalogPin1";
            this.uC_AnalogPin1.PinMode = Arduino.PinMode.Output;
            this.uC_AnalogPin1.PinNumber = 0;
            this.uC_AnalogPin1.Size = new System.Drawing.Size(99, 23);
            this.uC_AnalogPin1.TabIndex = 0;
            this.uC_AnalogPin1.Value = 0;
            // 
            // uC_AnalogPin2
            // 
            this.uC_AnalogPin2.AutoSize = true;
            this.uC_AnalogPin2.BackColor = System.Drawing.Color.Transparent;
            this.uC_AnalogPin2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uC_AnalogPin2.ID = 0;
            this.uC_AnalogPin2.Location = new System.Drawing.Point(3, 32);
            this.uC_AnalogPin2.Name = "uC_AnalogPin2";
            this.uC_AnalogPin2.PinMode = Arduino.PinMode.Output;
            this.uC_AnalogPin2.PinNumber = 0;
            this.uC_AnalogPin2.Size = new System.Drawing.Size(99, 23);
            this.uC_AnalogPin2.TabIndex = 1;
            this.uC_AnalogPin2.Value = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._digitalPinsPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._analogPinsPanel);
            this.splitContainer1.Size = new System.Drawing.Size(554, 132);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 4;
            // 
            // ArduinoEmulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 162);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ArduinoEmulatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino : Stop";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this._digitalPinsPanel.ResumeLayout(false);
            this._digitalPinsPanel.PerformLayout();
            this._analogPinsPanel.ResumeLayout(false);
            this._analogPinsPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btn_start;
        private System.Windows.Forms.ToolStripButton btn_reset;
        private System.Windows.Forms.FlowLayoutPanel _digitalPinsPanel;
        private System.Windows.Forms.FlowLayoutPanel _analogPinsPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripLabel labelBoards;
        private System.Windows.Forms.ToolStripComboBox _boardsCombo;
        private System.Windows.Forms.ToolStripSeparator _separator;
        private global::ArduinoEmulator.UC.UC_AnalogPin uC_AnalogPin1;
        private ArduinoEmulator.UC.UC_DigitalPin uC_DigitalPin1;
        private ArduinoEmulator.UC.UC_AnalogPin uC_AnalogPin2;
    }
}

