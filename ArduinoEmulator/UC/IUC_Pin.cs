using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using Arduino;

namespace ArduinoEmulator.UC
{
    public interface IUC_Pin
    {
        event EventHandler<PinChangedEventArg> ValueChanged;

        int ID { get; set; }
        int PinNumber { get; set; }
        PinMode PinMode { get; set; }
        int Value { get; set; }
        Color Color { get; set; }
    }

    public class PinChangedEventArg : EventArgs
    {
        public int PinNumber { get; private set; }
        public int Value { get; private set; }

        public PinChangedEventArg(int pin, int value)
        {
            PinNumber = pin;
            Value = value;
        }
    }
}
