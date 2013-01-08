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
        private int _id;
        [Category("Lightuino")]
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                this.Name = string.Format("{0:00}", _id);
                this._label.Text = this.Name;
            }
        }

        [Category("Lightuino")]
        public int Value
        {
            get
            { return _led.FlatAppearance.CheckedBackColor.A; }
            set
            {
                //if (value >= 0 && value <= 255)
                {
                    _led.FlatAppearance.CheckedBackColor = Color.FromArgb(value, _led.FlatAppearance.CheckedBackColor);
                    _led.FlatAppearance.BorderSize = (value != 0) ? 2 : 1;
                    //_toolTip.SetToolTip(this, value.ToString());
                    //_toolTip.SetToolTip(_label, value.ToString());
                    _toolTip.SetToolTip(_led, (value != 0) ? value.ToString() : "");
                }
                //else
                //{
                //    _led.FlatAppearance.BorderSize = 5;
                //    _toolTip.SetToolTip(_led, "Error : " + value.ToString());
                //}
            }
        }

        [Category("Lightuino")]
        [DefaultValue(typeof(Color), "Red")]
        public Color Color
        {
            get { return _led.FlatAppearance.CheckedBackColor; }
            set { _led.FlatAppearance.CheckedBackColor = value; }
        }

        #endregion

        public UC_PwmLed()
        {
            InitializeComponent();
        }
    }
}
