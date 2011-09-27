using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arduino;
using ArduinoEmulator.Lightuino;

namespace ArduinoEmulator
{
    public partial class ArduinoEmulator : Form
    {
        #region Define
        // Pin Modes
        public const int OUTPUT = 0;
        public const int INPUT = 1;
        // Pin Levels
        public const int LOW = 0;
        public const int HIGH = 1;
        #endregion

        CheckBox[] _checkedBoxes = null;
        LightuinoForm _lightuinoForm;

        public ArduinoEmulator()
        {
            InitializeComponent();

            _checkedBoxes = new CheckBox[14];
            _checkedBoxes[0] = pin0;
            _checkedBoxes[1] = pin1;
            _checkedBoxes[2] = pin2;
            _checkedBoxes[3] = pin3;
            _checkedBoxes[4] = pin4;
            _checkedBoxes[5] = pin5;
            _checkedBoxes[6] = pin6;
            _checkedBoxes[7] = pin7;
            _checkedBoxes[8] = pin8;
            _checkedBoxes[9] = pin9;
            _checkedBoxes[10] = pin10;
            _checkedBoxes[11] = pin11;
            _checkedBoxes[12] = pin12;
            _checkedBoxes[13] = pin13;

            _lightuinoForm = new LightuinoForm();
            _lightuinoForm.Show();


            ArduinoBase.CurrentInstance.OnPinModeChanged += new EventHandler(CurrentArduino_OnPinModeChanged);
            ArduinoBase.CurrentInstance.OnPinStateChanged += new EventHandler(CurrentArduino_OnPinStateChanged);

            btn_start_Click(null, null);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            ArduinoBase.CurrentInstance.Reset();
            ArduinoBase.CurrentInstance.Start();
            this.Text = "Arduino : Start";
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            ArduinoBase.CurrentInstance.Reset();
            this.Text = "Arduino : Stop";

            foreach (CheckBox chk in _checkedBoxes)
            {
                chk.CheckState = CheckState.Indeterminate;
                chk.Enabled = false;
                chk.FlatStyle = FlatStyle.Popup;
            }
        }

        private void CurrentArduino_OnPinModeChanged(object sender, EventArgs e)
        {
            Pin pin = sender as Pin;
            CheckBox chk = _checkedBoxes[pin.Index];

            chk.Enabled = true;
            if (pin.Mode == INPUT)
                chk.FlatStyle = FlatStyle.Standard;
            CurrentArduino_OnPinStateChanged(pin, null);
        }
        private void CurrentArduino_OnPinStateChanged(object sender, EventArgs e)
        {
            Pin pin = sender as Pin;
            CheckBox chk = _checkedBoxes[pin.Index];

            bool state = pin.State == HIGH;
            if (pin.Mode == INPUT)
                _checkedBoxes[pin.Index].CheckState = state ? CheckState.Checked : CheckState.Unchecked;
            else
                _checkedBoxes[pin.Index].CheckState = state ? CheckState.Indeterminate : CheckState.Unchecked;
        }


        private void pinX_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk == null || chk.CheckState == CheckState.Indeterminate || chk.FlatStyle != FlatStyle.Standard)
                return;
            chk.Tag = null;
            int pinIndex = chk.TabIndex;
            ArduinoBase.CurrentInstance.SetInputState(pinIndex, HIGH);
            if (e.Button == MouseButtons.Right)
                chk.Tag = "Fixed";
        }
        private void pinX_MouseLeave(object sender, EventArgs e)
        { pinX_MouseUp(sender, null); }
        private void pinX_MouseUp(object sender, MouseEventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk == null || chk.CheckState == CheckState.Indeterminate || chk.FlatStyle != FlatStyle.Standard)
                return;

            if (chk.Tag == null)
            {
                int pinIndex = chk.TabIndex;
                ArduinoBase.CurrentInstance.SetInputState(pinIndex, LOW);
            }
        }

    }
}
