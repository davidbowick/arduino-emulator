namespace ArduinoEmulator
{
    partial class ArduinoEmulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArduinoEmulator));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btn_start = new System.Windows.Forms.ToolStripButton();
            this.btn_reset = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pin0 = new System.Windows.Forms.CheckBox();
            this.pin1 = new System.Windows.Forms.CheckBox();
            this.pin2 = new System.Windows.Forms.CheckBox();
            this.pin3 = new System.Windows.Forms.CheckBox();
            this.pin4 = new System.Windows.Forms.CheckBox();
            this.pin5 = new System.Windows.Forms.CheckBox();
            this.pin6 = new System.Windows.Forms.CheckBox();
            this.pin7 = new System.Windows.Forms.CheckBox();
            this.pin8 = new System.Windows.Forms.CheckBox();
            this.pin9 = new System.Windows.Forms.CheckBox();
            this.pin10 = new System.Windows.Forms.CheckBox();
            this.pin11 = new System.Windows.Forms.CheckBox();
            this.pin12 = new System.Windows.Forms.CheckBox();
            this.pin13 = new System.Windows.Forms.CheckBox();
            this.toolStrip.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_start,
            this.btn_reset});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(301, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
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
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.pin0);
            this.flowLayoutPanel.Controls.Add(this.pin1);
            this.flowLayoutPanel.Controls.Add(this.pin2);
            this.flowLayoutPanel.Controls.Add(this.pin3);
            this.flowLayoutPanel.Controls.Add(this.pin4);
            this.flowLayoutPanel.Controls.Add(this.pin5);
            this.flowLayoutPanel.Controls.Add(this.pin6);
            this.flowLayoutPanel.Controls.Add(this.pin7);
            this.flowLayoutPanel.Controls.Add(this.pin8);
            this.flowLayoutPanel.Controls.Add(this.pin9);
            this.flowLayoutPanel.Controls.Add(this.pin10);
            this.flowLayoutPanel.Controls.Add(this.pin11);
            this.flowLayoutPanel.Controls.Add(this.pin12);
            this.flowLayoutPanel.Controls.Add(this.pin13);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(301, 58);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // pin0
            // 
            this.pin0.AutoCheck = false;
            this.pin0.AutoSize = true;
            this.pin0.Checked = true;
            this.pin0.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin0.Enabled = false;
            this.pin0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin0.Location = new System.Drawing.Point(3, 3);
            this.pin0.Name = "pin0";
            this.pin0.Size = new System.Drawing.Size(36, 17);
            this.pin0.TabIndex = 0;
            this.pin0.Text = "00";
            this.pin0.UseVisualStyleBackColor = true;
            this.pin0.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin1
            // 
            this.pin1.AutoCheck = false;
            this.pin1.AutoSize = true;
            this.pin1.Checked = true;
            this.pin1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin1.Enabled = false;
            this.pin1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin1.Location = new System.Drawing.Point(45, 3);
            this.pin1.Name = "pin1";
            this.pin1.Size = new System.Drawing.Size(36, 17);
            this.pin1.TabIndex = 1;
            this.pin1.Text = "01";
            this.pin1.UseVisualStyleBackColor = true;
            this.pin1.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin2
            // 
            this.pin2.AutoCheck = false;
            this.pin2.AutoSize = true;
            this.pin2.Checked = true;
            this.pin2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin2.Enabled = false;
            this.pin2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin2.Location = new System.Drawing.Point(87, 3);
            this.pin2.Name = "pin2";
            this.pin2.Size = new System.Drawing.Size(36, 17);
            this.pin2.TabIndex = 2;
            this.pin2.Text = "02";
            this.pin2.UseVisualStyleBackColor = true;
            this.pin2.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin3
            // 
            this.pin3.AutoCheck = false;
            this.pin3.AutoSize = true;
            this.pin3.Checked = true;
            this.pin3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin3.Enabled = false;
            this.pin3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin3.Location = new System.Drawing.Point(129, 3);
            this.pin3.Name = "pin3";
            this.pin3.Size = new System.Drawing.Size(36, 17);
            this.pin3.TabIndex = 3;
            this.pin3.Text = "03";
            this.pin3.UseVisualStyleBackColor = true;
            this.pin3.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin4
            // 
            this.pin4.AutoCheck = false;
            this.pin4.AutoSize = true;
            this.pin4.Checked = true;
            this.pin4.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin4.Enabled = false;
            this.pin4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin4.Location = new System.Drawing.Point(171, 3);
            this.pin4.Name = "pin4";
            this.pin4.Size = new System.Drawing.Size(36, 17);
            this.pin4.TabIndex = 4;
            this.pin4.Text = "04";
            this.pin4.UseVisualStyleBackColor = true;
            this.pin4.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin5
            // 
            this.pin5.AutoCheck = false;
            this.pin5.AutoSize = true;
            this.pin5.Checked = true;
            this.pin5.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin5.Enabled = false;
            this.pin5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin5.Location = new System.Drawing.Point(213, 3);
            this.pin5.Name = "pin5";
            this.pin5.Size = new System.Drawing.Size(36, 17);
            this.pin5.TabIndex = 5;
            this.pin5.Text = "05";
            this.pin5.UseVisualStyleBackColor = true;
            this.pin5.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin6
            // 
            this.pin6.AutoCheck = false;
            this.pin6.AutoSize = true;
            this.pin6.Checked = true;
            this.pin6.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin6.Enabled = false;
            this.pin6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin6.Location = new System.Drawing.Point(255, 3);
            this.pin6.Name = "pin6";
            this.pin6.Size = new System.Drawing.Size(36, 17);
            this.pin6.TabIndex = 6;
            this.pin6.Text = "06";
            this.pin6.UseVisualStyleBackColor = true;
            this.pin6.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin7
            // 
            this.pin7.AutoCheck = false;
            this.pin7.AutoSize = true;
            this.pin7.Checked = true;
            this.pin7.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin7.Enabled = false;
            this.pin7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin7.Location = new System.Drawing.Point(3, 26);
            this.pin7.Name = "pin7";
            this.pin7.Size = new System.Drawing.Size(36, 17);
            this.pin7.TabIndex = 7;
            this.pin7.Text = "07";
            this.pin7.UseVisualStyleBackColor = true;
            this.pin7.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin8
            // 
            this.pin8.AutoCheck = false;
            this.pin8.AutoSize = true;
            this.pin8.Checked = true;
            this.pin8.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin8.Enabled = false;
            this.pin8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin8.Location = new System.Drawing.Point(45, 26);
            this.pin8.Name = "pin8";
            this.pin8.Size = new System.Drawing.Size(36, 17);
            this.pin8.TabIndex = 8;
            this.pin8.Text = "08";
            this.pin8.UseVisualStyleBackColor = true;
            this.pin8.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin9
            // 
            this.pin9.AutoCheck = false;
            this.pin9.AutoSize = true;
            this.pin9.Checked = true;
            this.pin9.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin9.Enabled = false;
            this.pin9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin9.Location = new System.Drawing.Point(87, 26);
            this.pin9.Name = "pin9";
            this.pin9.Size = new System.Drawing.Size(36, 17);
            this.pin9.TabIndex = 9;
            this.pin9.Text = "09";
            this.pin9.UseVisualStyleBackColor = true;
            this.pin9.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin10
            // 
            this.pin10.AutoCheck = false;
            this.pin10.AutoSize = true;
            this.pin10.Checked = true;
            this.pin10.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin10.Enabled = false;
            this.pin10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin10.Location = new System.Drawing.Point(129, 26);
            this.pin10.Name = "pin10";
            this.pin10.Size = new System.Drawing.Size(36, 17);
            this.pin10.TabIndex = 10;
            this.pin10.Text = "10";
            this.pin10.UseVisualStyleBackColor = true;
            this.pin10.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin11
            // 
            this.pin11.AutoCheck = false;
            this.pin11.AutoSize = true;
            this.pin11.Checked = true;
            this.pin11.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin11.Enabled = false;
            this.pin11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin11.Location = new System.Drawing.Point(171, 26);
            this.pin11.Name = "pin11";
            this.pin11.Size = new System.Drawing.Size(36, 17);
            this.pin11.TabIndex = 11;
            this.pin11.Text = "11";
            this.pin11.UseVisualStyleBackColor = true;
            this.pin11.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin12
            // 
            this.pin12.AutoCheck = false;
            this.pin12.AutoSize = true;
            this.pin12.Checked = true;
            this.pin12.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin12.Enabled = false;
            this.pin12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin12.Location = new System.Drawing.Point(213, 26);
            this.pin12.Name = "pin12";
            this.pin12.Size = new System.Drawing.Size(36, 17);
            this.pin12.TabIndex = 12;
            this.pin12.Text = "12";
            this.pin12.UseVisualStyleBackColor = true;
            this.pin12.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // pin13
            // 
            this.pin13.AutoCheck = false;
            this.pin13.AutoSize = true;
            this.pin13.Checked = true;
            this.pin13.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.pin13.Enabled = false;
            this.pin13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin13.Location = new System.Drawing.Point(255, 26);
            this.pin13.Name = "pin13";
            this.pin13.Size = new System.Drawing.Size(36, 17);
            this.pin13.TabIndex = 13;
            this.pin13.Text = "13";
            this.pin13.UseVisualStyleBackColor = true;
            this.pin13.MouseLeave += new System.EventHandler(this.pinX_MouseLeave);
            this.pin13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseDown);
            this.pin13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pinX_MouseUp);
            // 
            // ArduinoEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 83);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.toolStrip);
            this.Name = "ArduinoEmulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino : Stop";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btn_start;
        private System.Windows.Forms.ToolStripButton btn_reset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.CheckBox pin0;
        private System.Windows.Forms.CheckBox pin1;
        private System.Windows.Forms.CheckBox pin2;
        private System.Windows.Forms.CheckBox pin3;
        private System.Windows.Forms.CheckBox pin4;
        private System.Windows.Forms.CheckBox pin5;
        private System.Windows.Forms.CheckBox pin6;
        private System.Windows.Forms.CheckBox pin7;
        private System.Windows.Forms.CheckBox pin8;
        private System.Windows.Forms.CheckBox pin9;
        private System.Windows.Forms.CheckBox pin10;
        private System.Windows.Forms.CheckBox pin11;
        private System.Windows.Forms.CheckBox pin12;
        private System.Windows.Forms.CheckBox pin13;
    }
}

