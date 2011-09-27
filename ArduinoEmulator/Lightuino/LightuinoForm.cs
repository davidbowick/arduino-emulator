using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Arduino;

namespace ArduinoEmulator.Lightuino
{
    public partial class LightuinoForm : Form
    {
        Dictionary<int, RadioButton> _outputs = new Dictionary<int, RadioButton>();

        public LightuinoForm()
        {
            InitializeComponent();

            for (int i = 0; i < 70; i++)
            {
                RadioButton rbtn = new RadioButton();
                string name = (i + 1).ToString("00");
                rbtn.Name = name;
                rbtn.Text = name;
                rbtn.AutoCheck = false;
                rbtn.AutoSize = true;
                _outputs.Add(i, rbtn);
                _panel.Controls.Add(rbtn);
            }
            Arduino.Lightuino.CurrentInstance.OnPinStateChanged += new EventHandler(CurrentLightuino_OnPinStateChanged);
        }
        private void LightuinoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void CurrentLightuino_OnPinStateChanged(object sender, EventArgs e)
        {
            Output output = sender as Output;
            if (output == null)
                return;

            _outputs[output.ID].Checked = output.State;
        }
    }
}
