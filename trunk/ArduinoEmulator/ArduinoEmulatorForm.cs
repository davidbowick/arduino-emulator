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
using ArduinoEmulator.UC;

namespace ArduinoEmulator
{
    public partial class ArduinoEmulatorForm : Form
    {
        #region Define
        // Pin Modes
        public const int OUTPUT = 0x0;
        public const int INPUT = 0x1;
        // Pin Levels
        public const int LOW = 0x0;
        public const int HIGH = 0x1;
        #endregion

        AtMegaModel[] _models = null;
        AtMegaModel _currentModel = null;
        Dictionary<int, UC_DigitalPin> _digitalPins = new Dictionary<int, UC_DigitalPin>();
        Dictionary<int, UC_AnalogPin> _analogPins = new Dictionary<int, UC_AnalogPin>();
        //UC_DigitalPin[] _digitalPins = null;
        //UC_AnalogPin[] _analogPins = null;
        LightuinoForm _lightuinoForm;

        public ArduinoEmulatorForm()
        {
            InitializeComponent();
            InitializeModels();
            _currentModel = _models[1];

            LoadModelPins();

            _lightuinoForm = new LightuinoForm();
            //_lightuinoForm.Show();

            ArduinoBase.CurrentInstance.OnPinModeChanged += new EventHandler(CurrentArduino_OnPinModeChanged);
            ArduinoBase.CurrentInstance.OnPinStateChanged += new EventHandler(CurrentArduino_OnPinStateChanged);

            btn_start_Click(null, null);
        }
        public void InitializeModels()
        {
            uint[] digi_14 = GeneratePinArray(14, 0);
            uint[] digi_54 = GeneratePinArray(54, 0);

            uint[] ana_6 = GeneratePinArray(6, 14);
            uint[] ana_8 = GeneratePinArray(8, 14);
            uint[] ana_16 = GeneratePinArray(16, 14);

            uint[] pwm_6 = new uint[] { 3, 5, 6, 9, 10, 11 };
            uint[] pwm_14 = GeneratePinArray(14, 0);

            uint[] inter_2 = new uint[] { 2, 3 };
            uint[] inter_6 = new uint[] { 2, 3, 21, 20, 19, 18 };

            AtMegaModel atmega328p_6Analog = new AtMegaModel("atmega328p_6Analog", digi_14, ana_6, pwm_6, inter_2);
            AtMegaModel atmega328p_8Analog = new AtMegaModel("atmega328p_8Analog", digi_14, ana_8, pwm_6, inter_2);
            AtMegaModel atmega2560 = new AtMegaModel("atmega2560", digi_54, ana_16, pwm_14, inter_6);

            _models = new AtMegaModel[3];
            _models[0] = atmega328p_6Analog;
            _models[1] = atmega328p_8Analog;
            _models[2] = atmega2560;

            //Fill models combo
            //_modelsCombo.Items.Add(

        }
        private uint[] GeneratePinArray(int length, uint start)
        {
            uint[] res = new uint[length];
            uint id = start;
            for (int i = 0; i < length; i++)
            {
                res[i] = id;
                id++;
            }
            return res;
        }
        //private bool[] GeneratePinModeArray(uint[] pins, int lenght)
        //{
        //    bool[] res = new bool[lenght];
        //    for (int i = 0; i < pins.Length; i++)
        //    {
        //        int index = (int)pins[i];
        //        if (index < res.Length)
        //            res[index] = true;
        //    }
        //    return res;
        //}
        public void LoadModelPins()
        {
            int digitalPinNumber = _currentModel.DigitalPinNumber.Length;
            int analogPinNumber = _currentModel.AnalogPinNumber.Length;

            #region Create digital pin checkboxes
            _digitalPins.Clear();
            for (int i = 0; i < digitalPinNumber; i++)
            {
                UC_DigitalPin digitPin = new UC_DigitalPin();
                int pinNumber = (int)_currentModel.DigitalPinNumber[i];
                digitPin.ID = i;
                digitPin.PinNumber = pinNumber;
                digitPin.Color = Color.Red;
                digitPin.Value = 0;
                digitPin.ValueChanged += new EventHandler<PinChangedEventArg>(Pin_ValueChanged);
                _digitalPins.Add(pinNumber, digitPin);
            }
            _digitalPinsPanel.Controls.Clear();
            _digitalPinsPanel.Controls.AddRange(_digitalPins.Values.ToArray());
            #endregion

            #region Create analog pin UCs
            _analogPins.Clear();
            for (int i = 0; i < analogPinNumber; i++)
            {
                UC_AnalogPin anaPin = new UC_AnalogPin();
                int pinNumber = (int)_currentModel.AnalogPinNumber[i];
                anaPin.ID = i;
                anaPin.PinNumber = pinNumber;
                anaPin.Color = Color.Red;
                anaPin.Value = 0;
                anaPin.ValueChanged += new EventHandler<PinChangedEventArg>(Pin_ValueChanged);
                _analogPins.Add(pinNumber, anaPin);
            }
            _analogPinsPanel.Controls.Clear();
            _analogPinsPanel.Controls.AddRange(_analogPins.Values.ToArray());
            #endregion

        }

        private IUC_Pin GetPinUC(int pinNumber)
        {
            if (_digitalPins.ContainsKey(pinNumber))
                return _digitalPins[pinNumber];
            else if (_analogPins.ContainsKey(pinNumber))
                return _analogPins[pinNumber];
            else
                throw new Exception(string.Format("Unable to find pin {0}.", pinNumber));
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            ArduinoBase.CurrentInstance.Reset();
            ArduinoBase.CurrentInstance.Start(_currentModel);
            ArduinoBase.CurrentInstance.RefreshForm();
            this.Text = "Arduino : Start";
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            ArduinoBase.CurrentInstance.Reset();
            this.Text = "Arduino : Stop";

            foreach (UC_DigitalPin digitPin in _digitalPins.Values)
            {
                digitPin.PinMode = PinMode.NotInitialized;
                digitPin.Value = 0;
            }

            foreach (UC_AnalogPin anaPin in _analogPins.Values)
            {
                anaPin.PinMode = PinMode.NotInitialized;
                anaPin.Value = 0;
            }
        }

        private void CurrentArduino_OnPinModeChanged(object sender, EventArgs e)
        {
            Pin pin = sender as Pin;
            IUC_Pin ucPin = GetPinUC(pin.PinNumber);
            ucPin.PinMode = pin.Mode;

            // Refresh value
            CurrentArduino_OnPinStateChanged(pin, null);
        }
        private void CurrentArduino_OnPinStateChanged(object sender, EventArgs e)
        {
            Pin pin = sender as Pin;
            IUC_Pin ucPin = GetPinUC(pin.PinNumber);

            ucPin.Value = pin.Value;
        }

        private void Pin_ValueChanged(object sender, PinChangedEventArg e)
        {
            IUC_Pin ucPin = sender as IUC_Pin;
            ArduinoBase.CurrentInstance.SetInputValue(ucPin.PinNumber, ucPin.Value);
        }

        //private void anaPin_ValueChanged(object sender, EventArgs e)
        //{
        //    NumericUpDown numUD = sender as NumericUpDown;
        //    ArduinoBase.CurrentInstance.SetInputValue(numUD.TabIndex, (int)numUD.Value);
        //}

    }
}
