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
        //Dictionary<int, RadioButton> _outputs = new Dictionary<int, RadioButton>();
        Dictionary<int, UC_PwmLed> _outputs = new Dictionary<int, UC_PwmLed>();

        public LightuinoForm()
        {
            InitializeComponent();

            for (int i = 0; i < 70; i++)
            {
                UC_PwmLed led = new UC_PwmLed();
                led.ID = i;
                led.Color = Color.Red;
                led.Value = 0;
                _outputs.Add(i, led);
                _panel.Controls.Add(led);
            }
            Arduino.Lightuino.CurrentInstance.OnPinStateChanged += new EventHandler<OutputChangedEventArgs>(CurrentLightuino_OnPinStateChanged);
        }
        private void LightuinoForm_FormClosing(object sender, FormClosingEventArgs e)
        { e.Cancel = true; }

        private void CurrentLightuino_OnPinStateChanged(object sender, OutputChangedEventArgs e)
        {
            _outputs[e.ID].Value = e.Value;
        }
    }
}
