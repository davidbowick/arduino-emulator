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
    public partial class UC_DigitalPin : UserControl, IUC_Pin
    {
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
                this.Name = string.Format("{0:00}", _id);
                this._checkBox.Text = this.Name;
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
                        break;
                    case PinMode.OUTPUT:
                        _checkBox.Enabled = true;
                        _checkBox.FlatStyle = FlatStyle.Flat;
                        break;
                    case PinMode.INPUT:
                        _checkBox.Enabled = true;
                        _checkBox.FlatStyle = FlatStyle.Standard;
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
                    case PinMode.OUTPUT:
                        return _checkBox.FlatAppearance.CheckedBackColor.A;
                    case PinMode.INPUT:
                        return (_checkBox.CheckState == CheckState.Checked) ? ArduinoEmulatorForm.HIGH : ArduinoEmulatorForm.LOW;
                    default:
                        return 0;
                }
            }
            set
            {
                switch (_pinMode)
                {
                    case PinMode.NotInitialized:
                        _checkBox.Checked = false;
                        _checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(0, _checkBox.FlatAppearance.CheckedBackColor);
                        _checkBox.FlatAppearance.BorderSize = 1;
                        break;
                    case PinMode.OUTPUT:
                        _checkBox.Checked = false;

                        _checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(value, _checkBox.FlatAppearance.CheckedBackColor);
                        _checkBox.FlatAppearance.BorderSize = (value != 0) ? 2 : 1;
                        break;
                    case PinMode.INPUT:
                        if (value == ArduinoEmulatorForm.LOW)
                            _checkBox.CheckState = CheckState.Unchecked;
                        else if (value == ArduinoEmulatorForm.HIGH)
                            _checkBox.CheckState = CheckState.Checked;
                        else
                            _checkBox.CheckState = CheckState.Indeterminate;
                        _checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(0, _checkBox.FlatAppearance.CheckedBackColor);
                        _checkBox.FlatAppearance.BorderSize = 1;
                        break;
                    default:
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

        public UC_DigitalPin()
        {
            InitializeComponent();
        }

        private void _checkBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (_pinMode != PinMode.INPUT)
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
            if (_pinMode != PinMode.INPUT)
                return;

            if (_checkBox.Tag == null)
                _checkBox.CheckState = CheckState.Unchecked;
        }

        private void _checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, new PinChangedEventArg(PinNumber, Value));
        }
    }
}
