using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoEmulator.UC
{
    public partial class UC_AnalogPin : UserControl, IUC_Pin
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
                _checkBox.Text = string.Format("A{0:00}", _id);
            }
        }

        [Category("Arduino")]
        public int PinNumber { get; set; }
        [Category("Arduino")]
        public PinMode PinMode { get; set; }

        [Category("Arduino")]
        public int Value
        {
            get
            { return (int)_numericUpDown.Value; }
            set
            {
                _numericUpDown.Value = value;
                switch (value)
                {
                    case ArduinoEmulatorForm.HIGH:
                        _checkBox.CheckState = CheckState.Checked;
                        break;
                    case ArduinoEmulatorForm.LOW:
                        _checkBox.CheckState = CheckState.Unchecked;
                        break;
                    default:
                        _checkBox.CheckState = CheckState.Indeterminate;
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

        private void _numericUpDown_ValueChanged(object sender, EventArgs e)
        { if (ValueChanged != null) ValueChanged(this, new PinChangedEventArg(PinNumber, Value)); }

        private void CheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            //if (MouseDown != null) MouseDown(sender, e);
        }

        private void CheckBox_MouseLeave(object sender, EventArgs e)
        {
            //if (MouseLeave != null) MouseLeave(sender, e);
        }

        private void CheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            //if (MouseUp != null) MouseUp(sender, e);
        }

    }
}
