using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoEmulator.Lightuino
{
    public partial class UC_PwmLed : UserControl
    {
        #region Properties
        [Category("Lightuino")]
        public string ID
        {
            get { return _label.Text; }
            set { _label.Text = value; }
        }

        [Category("Lightuino")]
        [DefaultValue(typeof(Color), "Red")]
        public Color Color
        {
            get { return _led.FlatAppearance.CheckedBackColor; }
            set { _led.FlatAppearance.CheckedBackColor = value; }
        }

        [Category("Lightuino")]
        public byte Value
        {
            get
            { return _led.FlatAppearance.CheckedBackColor.A; }
            set
            {
                _led.FlatAppearance.CheckedBackColor = Color.FromArgb(value, _led.FlatAppearance.CheckedBackColor);
                _led.FlatAppearance.BorderSize = (value != 0) ? 2 : 1;
                //_toolTip.SetToolTip(this, value.ToString());
                //_toolTip.SetToolTip(_label, value.ToString());
                _toolTip.SetToolTip(_led, (value != 0) ? value.ToString() : "");
            }
        }
        #endregion

        public UC_PwmLed()
        {
            InitializeComponent();
        }
    }
}
