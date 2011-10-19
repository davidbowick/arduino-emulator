using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arduino;

namespace ArduinoEmulator.UC
{
    public partial class UC_AnalogPin : UserControl, IUC_Pin
    {
        private bool _writingValue = false;
        public event EventHandler<PinChangedEventArg> ValueChanged;

        #region Properties
        private int _id;
        [Category("Arduino")]
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                this.Name = string.Format("A{0:00}", _id);
                this._label.Text = this.Name;
            }
        }

        [Category("Arduino")]
        public int PinNumber { get; set; }

        private PinMode _pinMode = PinMode.NotInitialized;
        [Category("Arduino")]
        public PinMode PinMode
        {
            get { return _pinMode; }
            set
            {
                _pinMode = value;
                switch (_pinMode)
                {
                    case PinMode.NotInitialized:
                        _checkBox.Enabled = false;
                        _checkBox.FlatStyle = FlatStyle.Flat;
                        _checkBox.Appearance = Appearance.Button;
                        _checkBox.FlatAppearance.BorderSize = 1;
                        _numericUpDown.ReadOnly = false;
                        break;
                    case PinMode.Output:
                    case PinMode.PWM:
                        _checkBox.Enabled = true;
                        _checkBox.FlatStyle = FlatStyle.Flat;
                        _checkBox.Appearance = Appearance.Button;
                        _checkBox.FlatAppearance.BorderSize = 2;
                        _numericUpDown.ReadOnly = true;
                        break;
                    case PinMode.Input:
                        _checkBox.Enabled = true;
                        _checkBox.FlatStyle = FlatStyle.System;
                        _checkBox.Appearance = Appearance.Normal;
                        _numericUpDown.ReadOnly = true;
                        break;
                }
            }
        }

        [Category("Arduino")]
        public int Value
        {
            get
            {
                switch (_pinMode)
                {
                    case PinMode.Output:
                        return _checkBox.FlatAppearance.CheckedBackColor.A;
                    case PinMode.PWM:
                        return (_checkBox.FlatAppearance.CheckedBackColor.A == 255) ? ArduinoEmulatorForm.HIGH : ArduinoEmulatorForm.LOW;
                    case PinMode.Input:
                        return (_checkBox.CheckState == CheckState.Checked) ? ArduinoEmulatorForm.HIGH : ArduinoEmulatorForm.LOW;
                    default:
                        return (int)_numericUpDown.Value;
                }
            }
            set
            {
                _writingValue = true;
                _numericUpDown.Value = value;
                _writingValue = false;

                switch (_pinMode)
                {
                    case PinMode.NotInitialized:
                        _checkBox.Checked = false;
                        _checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(0, _checkBox.FlatAppearance.CheckedBackColor);
                        _numericUpDown.ReadOnly = false;
                        break;
                    case PinMode.Output:
                        _checkBox.Checked = true;
                        int outValue = 0;
                        if (value == ArduinoEmulatorForm.LOW)
                            outValue = ArduinoEmulatorForm.LOW;
                        else if (value == ArduinoEmulatorForm.HIGH)
                            outValue = 255;
                        else
                            outValue = value;
                        _checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(outValue, _checkBox.FlatAppearance.CheckedBackColor);
                        _numericUpDown.ReadOnly = true;
                        break;
                    case PinMode.Input:
                        if (value == ArduinoEmulatorForm.LOW)
                            _checkBox.CheckState = CheckState.Unchecked;
                        else if (value == ArduinoEmulatorForm.HIGH)
                            _checkBox.CheckState = CheckState.Checked;
                        else
                            _checkBox.CheckState = CheckState.Indeterminate;
                        _checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(0, _checkBox.FlatAppearance.CheckedBackColor);
                        _numericUpDown.ReadOnly = true;
                        break;
                    case PinMode.PWM:
                        _checkBox.Checked = true;
                        _checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(value, _checkBox.FlatAppearance.CheckedBackColor);
                        _numericUpDown.ReadOnly = true;
                        break;
                }
            }
        }

        [Category("Arduino")]
        [DefaultValue(typeof(Color), "Red")]
        public Color Color
        {
            get { return _checkBox.FlatAppearance.CheckedBackColor; }
            set { _checkBox.FlatAppearance.CheckedBackColor = value; }
        }
        #endregion

        public UC_AnalogPin()
        {
            InitializeComponent();
        }

        private void _checkBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (_pinMode != PinMode.Input)
                return;

            _checkBox.Tag = null;
            _checkBox.CheckState = CheckState.Checked;
            if (e.Button == MouseButtons.Right)
                _checkBox.Tag = "Fixed";
        }
        private void _checkBox_MouseLeave(object sender, EventArgs e)
        { _checkBox_MouseUp(sender, null); }
        private void _checkBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (_pinMode != PinMode.Input)
                return;

            if (_checkBox.Tag == null)
                _checkBox.CheckState = CheckState.Unchecked;
        }

        private void _checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null && _pinMode == PinMode.Input)
                ValueChanged(this, new PinChangedEventArg(PinNumber, Value));
        }
        private void _numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null && !_writingValue)
                ValueChanged(this, new PinChangedEventArg(PinNumber, Value));
        }

    }
}
