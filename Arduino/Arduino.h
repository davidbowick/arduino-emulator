// Arduino.h
#pragma once
#ifndef ARDUINO_H
#define ARDUINO_H

#pragma region Const
#define OUTPUT 0x0
#define INPUT 0x1

#define LOW  0x0
#define HIGH 0x1


int A0 = -1;
int A1 = -1;
int A2 = -1;
int A3 = -1;
int A4 = -1;
int A5 = -1;
int A6 = -1;
int A7 = -1;
int A8 = -1;
int A9 = -1;
int A10 = -1;
int A11 = -1;
int A12 = -1;
int A13 = -1;
int A14 = -1;
int A15 = -1;

//#define A0 14
//#define A1 15
//#define A2 16
//#define A3 17
//#define A4 18
//#define A5 19
//#define A6 20
//#define A7 21

//#define A0 54
//#define A1 55
//#define A2 56
//#define A3 57
//#define A4 58
//#define A5 59
//#define A6 60
//#define A7 61
//#define A8 62
//#define A9 63
//#define A10 64
//#define A11 65
//#define A12 66
//#define A13 67
//#define A14 68
//#define A15 69
#pragma endregion

#pragma region Binary
#define B0 0
#define B00 0
#define B000 0
#define B0000 0
#define B00000 0
#define B000000 0
#define B0000000 0
#define B00000000 0
#define B1 1
#define B01 1
#define B001 1
#define B0001 1
#define B00001 1
#define B000001 1
#define B0000001 1
#define B00000001 1
#define B10 2
#define B010 2
#define B0010 2
#define B00010 2
#define B000010 2
#define B0000010 2
#define B00000010 2
#define B11 3
#define B011 3
#define B0011 3
#define B00011 3
#define B000011 3
#define B0000011 3
#define B00000011 3
#define B100 4
#define B0100 4
#define B00100 4
#define B000100 4
#define B0000100 4
#define B00000100 4
#define B101 5
#define B0101 5
#define B00101 5
#define B000101 5
#define B0000101 5
#define B00000101 5
#define B110 6
#define B0110 6
#define B00110 6
#define B000110 6
#define B0000110 6
#define B00000110 6
#define B111 7
#define B0111 7
#define B00111 7
#define B000111 7
#define B0000111 7
#define B00000111 7
#define B1000 8
#define B01000 8
#define B001000 8
#define B0001000 8
#define B00001000 8
#define B1001 9
#define B01001 9
#define B001001 9
#define B0001001 9
#define B00001001 9
#define B1010 10
#define B01010 10
#define B001010 10
#define B0001010 10
#define B00001010 10
#define B1011 11
#define B01011 11
#define B001011 11
#define B0001011 11
#define B00001011 11
#define B1100 12
#define B01100 12
#define B001100 12
#define B0001100 12
#define B00001100 12
#define B1101 13
#define B01101 13
#define B001101 13
#define B0001101 13
#define B00001101 13
#define B1110 14
#define B01110 14
#define B001110 14
#define B0001110 14
#define B00001110 14
#define B1111 15
#define B01111 15
#define B001111 15
#define B0001111 15
#define B00001111 15
#define B10000 16
#define B010000 16
#define B0010000 16
#define B00010000 16
#define B10001 17
#define B010001 17
#define B0010001 17
#define B00010001 17
#define B10010 18
#define B010010 18
#define B0010010 18
#define B00010010 18
#define B10011 19
#define B010011 19
#define B0010011 19
#define B00010011 19
#define B10100 20
#define B010100 20
#define B0010100 20
#define B00010100 20
#define B10101 21
#define B010101 21
#define B0010101 21
#define B00010101 21
#define B10110 22
#define B010110 22
#define B0010110 22
#define B00010110 22
#define B10111 23
#define B010111 23
#define B0010111 23
#define B00010111 23
#define B11000 24
#define B011000 24
#define B0011000 24
#define B00011000 24
#define B11001 25
#define B011001 25
#define B0011001 25
#define B00011001 25
#define B11010 26
#define B011010 26
#define B0011010 26
#define B00011010 26
#define B11011 27
#define B011011 27
#define B0011011 27
#define B00011011 27
#define B11100 28
#define B011100 28
#define B0011100 28
#define B00011100 28
#define B11101 29
#define B011101 29
#define B0011101 29
#define B00011101 29
#define B11110 30
#define B011110 30
#define B0011110 30
#define B00011110 30
#define B11111 31
#define B011111 31
#define B0011111 31
#define B00011111 31
#define B100000 32
#define B0100000 32
#define B00100000 32
#define B100001 33
#define B0100001 33
#define B00100001 33
#define B100010 34
#define B0100010 34
#define B00100010 34
#define B100011 35
#define B0100011 35
#define B00100011 35
#define B100100 36
#define B0100100 36
#define B00100100 36
#define B100101 37
#define B0100101 37
#define B00100101 37
#define B100110 38
#define B0100110 38
#define B00100110 38
#define B100111 39
#define B0100111 39
#define B00100111 39
#define B101000 40
#define B0101000 40
#define B00101000 40
#define B101001 41
#define B0101001 41
#define B00101001 41
#define B101010 42
#define B0101010 42
#define B00101010 42
#define B101011 43
#define B0101011 43
#define B00101011 43
#define B101100 44
#define B0101100 44
#define B00101100 44
#define B101101 45
#define B0101101 45
#define B00101101 45
#define B101110 46
#define B0101110 46
#define B00101110 46
#define B101111 47
#define B0101111 47
#define B00101111 47
#define B110000 48
#define B0110000 48
#define B00110000 48
#define B110001 49
#define B0110001 49
#define B00110001 49
#define B110010 50
#define B0110010 50
#define B00110010 50
#define B110011 51
#define B0110011 51
#define B00110011 51
#define B110100 52
#define B0110100 52
#define B00110100 52
#define B110101 53
#define B0110101 53
#define B00110101 53
#define B110110 54
#define B0110110 54
#define B00110110 54
#define B110111 55
#define B0110111 55
#define B00110111 55
#define B111000 56
#define B0111000 56
#define B00111000 56
#define B111001 57
#define B0111001 57
#define B00111001 57
#define B111010 58
#define B0111010 58
#define B00111010 58
#define B111011 59
#define B0111011 59
#define B00111011 59
#define B111100 60
#define B0111100 60
#define B00111100 60
#define B111101 61
#define B0111101 61
#define B00111101 61
#define B111110 62
#define B0111110 62
#define B00111110 62
#define B111111 63
#define B0111111 63
#define B00111111 63
#define B1000000 64
#define B01000000 64
#define B1000001 65
#define B01000001 65
#define B1000010 66
#define B01000010 66
#define B1000011 67
#define B01000011 67
#define B1000100 68
#define B01000100 68
#define B1000101 69
#define B01000101 69
#define B1000110 70
#define B01000110 70
#define B1000111 71
#define B01000111 71
#define B1001000 72
#define B01001000 72
#define B1001001 73
#define B01001001 73
#define B1001010 74
#define B01001010 74
#define B1001011 75
#define B01001011 75
#define B1001100 76
#define B01001100 76
#define B1001101 77
#define B01001101 77
#define B1001110 78
#define B01001110 78
#define B1001111 79
#define B01001111 79
#define B1010000 80
#define B01010000 80
#define B1010001 81
#define B01010001 81
#define B1010010 82
#define B01010010 82
#define B1010011 83
#define B01010011 83
#define B1010100 84
#define B01010100 84
#define B1010101 85
#define B01010101 85
#define B1010110 86
#define B01010110 86
#define B1010111 87
#define B01010111 87
#define B1011000 88
#define B01011000 88
#define B1011001 89
#define B01011001 89
#define B1011010 90
#define B01011010 90
#define B1011011 91
#define B01011011 91
#define B1011100 92
#define B01011100 92
#define B1011101 93
#define B01011101 93
#define B1011110 94
#define B01011110 94
#define B1011111 95
#define B01011111 95
#define B1100000 96
#define B01100000 96
#define B1100001 97
#define B01100001 97
#define B1100010 98
#define B01100010 98
#define B1100011 99
#define B01100011 99
#define B1100100 100
#define B01100100 100
#define B1100101 101
#define B01100101 101
#define B1100110 102
#define B01100110 102
#define B1100111 103
#define B01100111 103
#define B1101000 104
#define B01101000 104
#define B1101001 105
#define B01101001 105
#define B1101010 106
#define B01101010 106
#define B1101011 107
#define B01101011 107
#define B1101100 108
#define B01101100 108
#define B1101101 109
#define B01101101 109
#define B1101110 110
#define B01101110 110
#define B1101111 111
#define B01101111 111
#define B1110000 112
#define B01110000 112
#define B1110001 113
#define B01110001 113
#define B1110010 114
#define B01110010 114
#define B1110011 115
#define B01110011 115
#define B1110100 116
#define B01110100 116
#define B1110101 117
#define B01110101 117
#define B1110110 118
#define B01110110 118
#define B1110111 119
#define B01110111 119
#define B1111000 120
#define B01111000 120
#define B1111001 121
#define B01111001 121
#define B1111010 122
#define B01111010 122
#define B1111011 123
#define B01111011 123
#define B1111100 124
#define B01111100 124
#define B1111101 125
#define B01111101 125
#define B1111110 126
#define B01111110 126
#define B1111111 127
#define B01111111 127
#define B10000000 128
#define B10000001 129
#define B10000010 130
#define B10000011 131
#define B10000100 132
#define B10000101 133
#define B10000110 134
#define B10000111 135
#define B10001000 136
#define B10001001 137
#define B10001010 138
#define B10001011 139
#define B10001100 140
#define B10001101 141
#define B10001110 142
#define B10001111 143
#define B10010000 144
#define B10010001 145
#define B10010010 146
#define B10010011 147
#define B10010100 148
#define B10010101 149
#define B10010110 150
#define B10010111 151
#define B10011000 152
#define B10011001 153
#define B10011010 154
#define B10011011 155
#define B10011100 156
#define B10011101 157
#define B10011110 158
#define B10011111 159
#define B10100000 160
#define B10100001 161
#define B10100010 162
#define B10100011 163
#define B10100100 164
#define B10100101 165
#define B10100110 166
#define B10100111 167
#define B10101000 168
#define B10101001 169
#define B10101010 170
#define B10101011 171
#define B10101100 172
#define B10101101 173
#define B10101110 174
#define B10101111 175
#define B10110000 176
#define B10110001 177
#define B10110010 178
#define B10110011 179
#define B10110100 180
#define B10110101 181
#define B10110110 182
#define B10110111 183
#define B10111000 184
#define B10111001 185
#define B10111010 186
#define B10111011 187
#define B10111100 188
#define B10111101 189
#define B10111110 190
#define B10111111 191
#define B11000000 192
#define B11000001 193
#define B11000010 194
#define B11000011 195
#define B11000100 196
#define B11000101 197
#define B11000110 198
#define B11000111 199
#define B11001000 200
#define B11001001 201
#define B11001010 202
#define B11001011 203
#define B11001100 204
#define B11001101 205
#define B11001110 206
#define B11001111 207
#define B11010000 208
#define B11010001 209
#define B11010010 210
#define B11010011 211
#define B11010100 212
#define B11010101 213
#define B11010110 214
#define B11010111 215
#define B11011000 216
#define B11011001 217
#define B11011010 218
#define B11011011 219
#define B11011100 220
#define B11011101 221
#define B11011110 222
#define B11011111 223
#define B11100000 224
#define B11100001 225
#define B11100010 226
#define B11100011 227
#define B11100100 228
#define B11100101 229
#define B11100110 230
#define B11100111 231
#define B11101000 232
#define B11101001 233
#define B11101010 234
#define B11101011 235
#define B11101100 236
#define B11101101 237
#define B11101110 238
#define B11101111 239
#define B11110000 240
#define B11110001 241
#define B11110010 242
#define B11110011 243
#define B11110100 244
#define B11110101 245
#define B11110110 246
#define B11110111 247
#define B11111000 248
#define B11111001 249
#define B11111010 250
#define B11111011 251
#define B11111100 252
#define B11111101 253
#define B11111110 254
#define B11111111 255
#pragma endregion

#pragma region Types
#define uint8_t unsigned int
typedef uint8_t boolean;
typedef uint8_t byte;
#define uint16_t unsigned short int
#pragma endregion

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Threading;
using namespace System::Diagnostics;

#define ThreadLoopTime 1

void _Reset();
void setup();
void loop();

namespace Arduino {

	public enum class PinMode
	{
		NotInitialized = -1,
		Output = OUTPUT,
		Input = INPUT,
		PWM = 255
	};
	 
	public ref class Pin
	{
	private:
		PinMode _mode;
		int _pinNumber, _value, _previousValue;
		bool _isDigital, _isPwm, _initialized;
	public:
		property int PinNumber
		{
			int get() { return _pinNumber;}
		}

		property int Value
		{
			int get() { return _value;}
			void set(int value)
			{
				_previousValue = _value;
				_value = value;
			}
		}

		property int PreviousValue
		{
			int get() { return _previousValue;}
		}

		property PinMode Mode
		{
			PinMode get() { return _mode;}
			void set(PinMode value) {_mode = value;}
		}

		property bool IsDigital
		{
			bool get() { return _isDigital;}
		}
		
		property bool IsPwm
		{
			bool get() { return _isPwm;}
		}


	public:
		Pin(int pinNumber, int value, bool isDigital)
		{
			_pinNumber = pinNumber;
			_value = value;
			_mode = PinMode::NotInitialized;
			_isDigital = isDigital;
			_initialized = false;
			_isPwm = false;
		}
		virtual String ^ ToString() override
		{
			return String::Format("{0}{1} as {2} : {3}",
				(_isDigital) ? "D" : "A",
				_pinNumber,
				_mode,
				_isDigital ? (_value == HIGH ? "HIGH" : "LOW") : _value.ToString());
		}
	};
	 
	public ref class AtMegaModel
	{
	private:
		String ^ _modelName;
		cli::array<byte> ^ _digitalPinNumber;
		cli::array<byte> ^ _analogPinNumber;
		cli::array<bool> ^ _digitalPWMPins;
		cli::array<bool> ^ _digitalInterruptPins;

	public:

#pragma region Properties
		property String ^ ModelName
		{
			String ^ get() { return _modelName;}
		}
		property cli::array<byte> ^ DigitalPinNumber
		{
			cli::array<byte> ^ get() { return _digitalPinNumber;}
		}
		property cli::array<byte> ^ AnalogPinNumber
		{
			cli::array<byte> ^ get() { return _analogPinNumber;}
		}
		property cli::array<bool> ^ DigitalPWMPins
		{
			cli::array<bool> ^ get() { return _digitalPWMPins;}
		}
		property cli::array<bool> ^ DigitalInterruptPins
		{
			cli::array<bool> ^ get() { return _digitalInterruptPins;}
		}
#pragma endregion

		AtMegaModel(
			String ^ modelName,
			cli::array<byte> ^ digitalPinNumber,
			cli::array<byte> ^ analogPinNumber,
			cli::array<byte> ^ digitalPWMPinNumber,
			cli::array<byte> ^ digitalInterruptPinNumber)
		{
			_modelName = modelName;
			_digitalPinNumber = digitalPinNumber;
			_analogPinNumber = analogPinNumber;

			int totalDigitalPin = _digitalPinNumber->Length;
			_digitalPWMPins = GeneratePinModeArray(totalDigitalPin, digitalPWMPinNumber);
			_digitalInterruptPins = GeneratePinModeArray(totalDigitalPin, digitalInterruptPinNumber);
		}
		virtual String ^ ToString() override
		{ return _modelName; }

	private:
		cli::array<bool> ^ GeneratePinModeArray(int length, cli::array<byte> ^ pins)
		{
			cli::array<bool> ^ res = gcnew cli::array<bool>(length);
			for	(int i = 0; i < pins->Length; i++)
			{
				int index = (int)pins[i];
				if (index < length)
					res[index] = true;
			}
			return res;
		}

	};
	 
	public ref class ArduinoBase
	{
#pragma region Singleton
	private:
		static ArduinoBase ^ _instance;
		SynchronizationContext ^ _currentContext;
		ArduinoBase()
		{
			_millisCounter = gcnew Stopwatch();
		}
	public:
		static property ArduinoBase ^ CurrentInstance
		{
			ArduinoBase ^ get()
			{
				if (_instance == nullptr)
					_instance = gcnew ArduinoBase();
				return _instance;
			}
		}
#pragma endregion

#pragma region Thread Loop
	private:
		Thread ^ _loopThread;
		void ThreadLoop()
		{
			while (_loopThread->IsAlive)
			{
				loop();
				Thread::Sleep(ThreadLoopTime);
			}
		}
#pragma endregion

#pragma region OnPinStateChanged
	public: event EventHandler ^ OnPinStateChanged;
	internal:
		void UpdatePinState(Pin ^ pin)
		{
			if (_currentContext != nullptr)
				_currentContext->Send(gcnew SendOrPostCallback(this, &ArduinoBase::OnPinStateChangedEvent), pin);
		}
	private:
		void OnPinStateChangedEvent(Object ^ oPin)
		{ OnPinStateChanged(oPin, nullptr); }
#pragma endregion

#pragma region OnPinModeChanged
	public: event EventHandler ^ OnPinModeChanged;
	internal:
		void UpdatePinMode(Pin ^ pin)
		{
			if (_currentContext != nullptr)
				_currentContext->Send(gcnew SendOrPostCallback(this, &ArduinoBase::OnPinModeChangedEvent), pin);
		}
	private:
		void OnPinModeChangedEvent(Object ^ oPin)
		{ OnPinModeChanged(oPin, nullptr); }
#pragma endregion

	internal:
		Stopwatch ^ _millisCounter;
		Dictionary<int, Pin ^> ^ _pins;
		AtMegaModel ^ _currentModel;

	public: 
		void Start(AtMegaModel ^ currentModel)
		{
			_currentModel = currentModel;
			_pins = gcnew Dictionary<int, Pin ^>();

			// Create digital pins
			if (_currentModel->DigitalPinNumber == nullptr)
				throw gcnew ArgumentNullException("Model.DigitalPinNumber");
			for	(int i = 0; i < _currentModel->DigitalPinNumber->Length; i++)
			{
				byte pinNumber = _currentModel->DigitalPinNumber[i];
				_pins->Add(pinNumber, gcnew Pin(pinNumber, LOW, true));
			}

			// Create analog pins
			if (_currentModel->AnalogPinNumber == nullptr)
				throw gcnew ArgumentNullException("Model.AnalogPinNumber");
			for	(int i = 0; i < _currentModel->AnalogPinNumber->Length; i++)
			{
				byte pinNumber = _currentModel->AnalogPinNumber[i];
				_pins->Add(pinNumber, gcnew Pin(pinNumber, LOW, false));
			}

			InitConstAnalogPins(&A0, 0);
			InitConstAnalogPins(&A1, 1);
			InitConstAnalogPins(&A2, 2);
			InitConstAnalogPins(&A3, 3);
			InitConstAnalogPins(&A4, 4);
			InitConstAnalogPins(&A5, 5);
			InitConstAnalogPins(&A6, 6);
			InitConstAnalogPins(&A7, 7);
			InitConstAnalogPins(&A8, 8);
			InitConstAnalogPins(&A9, 9);
			InitConstAnalogPins(&A10, 10);
			InitConstAnalogPins(&A11, 11);
			InitConstAnalogPins(&A12, 12);
			InitConstAnalogPins(&A13, 13);
			InitConstAnalogPins(&A14, 14);
			InitConstAnalogPins(&A15, 15);

			_millisCounter->Start();

			//Call implemented Setup
			setup();

			//Create thread
			_loopThread = gcnew Thread(gcnew ThreadStart(this, &Arduino::ArduinoBase::ThreadLoop));
			_loopThread->Name = "LoopThread";
			_loopThread->IsBackground = true;
			//Thread call loop()
			_loopThread->Start();
		}
		void Reset()
		{
			_Reset();
			if (_millisCounter != nullptr)
			{
				_millisCounter->Stop();
				_millisCounter->Reset();
			}

			if(_loopThread != nullptr)
				_loopThread->Abort();

			A0 = -1;
			A1 = -1;
			A2 = -1;
			A3 = -1;
			A4 = -1;
			A5 = -1;
			A6 = -1;
			A7 = -1;
			A8 = -1;
			A9 = -1;
			A10 = -1;
			A11 = -1;
			A12 = -1;
			A13 = -1;
			A14 = -1;
			A15 = -1;
		}

		void SetInputValue(int pin, int value)
		{
			Pin ^ cPin = GetPin(pin);
			if (cPin->IsDigital && cPin->Mode != PinMode::Input)
				throw gcnew Exception("Pin is not an INPUT");
			cPin->Value = value;
			UpdatePinState(cPin);
		}

		void RefreshForm()
		{
			_currentContext = SynchronizationContext::Current;
			if (_currentContext != nullptr)
			{
				// Refresh digital / analog pins
				for each (Pin ^ pin in _pins->Values)
				{
					if (pin->Mode != PinMode::NotInitialized)
					{
						UpdatePinMode(pin);
						UpdatePinState(pin);
					}
				}
			}
		}

		virtual String ^ ToString() override
		{ return this->GetType()->Name;}

		property AtMegaModel ^ CurrentModel
		{
			AtMegaModel ^ get() { return _currentModel;}
			void set(AtMegaModel ^ value) { _currentModel = value; }
		}

	internal:
		Pin ^ GetPin(int pinNumber)
		{
			Pin ^ cPin = nullptr;
			if (_pins->ContainsKey(pinNumber))
				cPin = _pins[pinNumber];

			if (cPin == nullptr)
				throw gcnew Exception(String::Format("Unable to find pin {0}.", pinNumber));
			return cPin;
		}

		void InitConstAnalogPins(int * pAX, int index)
		{
			if (_currentModel->AnalogPinNumber->Length > index)
			{
				*pAX = _currentModel->AnalogPinNumber[index];
			}
		}

	};
}

#pragma region Digital I/O
void pinMode(uint8_t pin, uint8_t mode)
{
	Arduino::Pin ^ cPin = Arduino::ArduinoBase::CurrentInstance->GetPin(pin);
	cPin->Mode = (Arduino::PinMode)mode;
	Arduino::ArduinoBase::CurrentInstance->UpdatePinMode(cPin);
}
void digitalWrite(uint8_t pin, uint8_t value)
{
	Arduino::Pin ^  cPin = Arduino::ArduinoBase::CurrentInstance->GetPin(pin);
	if (cPin->Mode == Arduino::PinMode::PWM)
	{
		cPin->Mode = Arduino::PinMode::Output;
		Arduino::ArduinoBase::CurrentInstance->UpdatePinMode(cPin);
	}
	if (cPin->Mode != Arduino::PinMode::Output)
		throw gcnew Exception("Pin is not in OUTPUT mode");
	cPin->Value = value;
	Arduino::ArduinoBase::CurrentInstance->UpdatePinState(cPin);
}
int digitalRead(uint8_t pin)
{
	Arduino::Pin ^  cPin = Arduino::ArduinoBase::CurrentInstance->GetPin(pin);
	if (cPin->Mode != Arduino::PinMode::Input)
		throw gcnew Exception("Pin is not an INPUT");
	return cPin->Value;
}
#pragma endregion

#pragma region Analog I/O
int analogRead(uint8_t pin)
{
	//pin = 0 to 5
	//pin = 0 to 7 on Mini & Nano
	//pin = 0 to 15 on Mega

	//#if defined(__AVR_ATmega1280__) || defined(__AVR_ATmega2560__)
	//	if (pin >= 54) pin -= 54; // allow for channel or pin numbers
	//#else
	//	if (pin >= 14) pin -= 14; // allow for channel or pin numbers
	//#endif

	Arduino::Pin ^ cPin = Arduino::ArduinoBase::CurrentInstance->GetPin(pin);
	if (cPin->IsDigital)
		throw gcnew Exception(String::Format("Pin {0} is not a analog input", pin));
	if (cPin->Value < 0)
		throw gcnew Exception("Analog value must be greater than 0");
	if (cPin->Value > 1024)
		throw gcnew Exception("Analog value must be less than 1024");

	return cPin->Value;
}
void analogWrite(uint8_t pin, int val) //PWM
{
	Arduino::Pin ^ cPin = Arduino::ArduinoBase::CurrentInstance->GetPin(pin);
	if (!cPin->IsDigital)
		throw gcnew Exception(String::Format("Pin {0} is not a digital pin", pin));
	if (val	> 255)
		throw gcnew Exception("PWM pin accept 255 max value");

	//pinMode(pin, OUTPUT);
	if (val == 0)
		digitalWrite(pin, LOW);
	else if (val == 255)
		digitalWrite(pin, HIGH);
	else
	{
		//If the pin is PWM
		if (Arduino::ArduinoBase::CurrentInstance->CurrentModel->DigitalPWMPins[pin])
		{
			if (cPin->Mode == Arduino::PinMode::Output)
			{
				cPin->Mode = Arduino::PinMode::PWM;
				Arduino::ArduinoBase::CurrentInstance->UpdatePinMode(cPin);
			}
			if (cPin->Mode != Arduino::PinMode::PWM)
				throw gcnew Exception("Pin is not in PWM mode");
			cPin->Value = val;
			Arduino::ArduinoBase::CurrentInstance->UpdatePinState(cPin);
		}
		else
		{
			if (val < 128)
				digitalWrite(pin, LOW);
			else
				digitalWrite(pin, HIGH);
		}
	}

}
#pragma endregion

#pragma region Advanced I/O
void tone(uint8_t pin, unsigned int frequency, unsigned long duration = 0)
{ throw gcnew NotImplementedException(); }
void noTone(uint8_t pin)
{ throw gcnew NotImplementedException(); }
//shiftOut(dataPin, clockPin, bitOrder, value) : Pour la com entre microProc

/// <summary>
/// <para>Retourne la durée d'une impulsion entre l'état de value et le retour à</para>
/// <para>Si value = HIGH, pulseIn attent que le pin passe à HIGH et compte jusqu'a ce que pin repasse à LOW.</para>
/// </summary>
/// <returns>Durée de l'impulsion en µs, 0 si le timeout est écoulé</returns>
//protected ulong pulseIn(int pin, int value)
//{
//    int defautTimeout = 1 * 1000000; //1 second = 1 000 000 µs
//    return pulseIn(pin, value, defautTimeout);
//}
/// <summary>
/// 
/// </summary>
/// <param name="timeout">In microseconds (from 10µs to 3min</param>
/// <returns></returns>
//protected ulong pulseIn(int pin, int value, int timeout)
//{
//    return 0;
//}
#pragma endregion

#pragma region Time
/// <summary>
/// Number of milliseconds since the program started
/// </summary>
unsigned long millis()
{
	return Arduino::ArduinoBase::CurrentInstance->_millisCounter->ElapsedMilliseconds;
}
/// <summary>
/// Number of microseconds since the program started
/// After approximately 70 minutes, return to 0
/// </summary>
unsigned long micros()
{ throw gcnew NotImplementedException(); }
/// <summary>
/// Pauses the program for the amount of time (in miliseconds) specified as parameter
/// </summary>
void delay(unsigned long ms)
{
	Thread::Sleep(ms);
}
/// <summary>
/// Pauses the program for the amount of time (in microseconds) specified as parameter.
/// </summary>
void delayMicroseconds(unsigned int us)
{ throw gcnew NotImplementedException(); }
#pragma endregion

#pragma region Math
#define PI 3.1415926535897932384626433832795
#define HALF_PI 1.5707963267948966192313216916398
#define TWO_PI 6.283185307179586476925286766559
#define DEG_TO_RAD 0.017453292519943295769236907684886
#define RAD_TO_DEG 57.295779513082320876798154814105

#define min(a,b) ((a)<(b)?(a):(b))
#define max(a,b) ((a)>(b)?(a):(b))
#define abs(x) ((x)>0?(x):-(x))
#define constrain(amt,low,high) ((amt)<(low)?(low):((amt)>(high)?(high):(amt)))
#define round(x)     ((x)>=0?(long)((x)+0.5):(long)((x)-0.5))
#define radians(deg) ((deg)*DEG_TO_RAD)
#define degrees(rad) ((rad)*RAD_TO_DEG)
#define sq(x) ((x)*(x))
//pow(), sqrt()
long map(long x, long in_min, long in_max, long out_min, long out_max)
{
  return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
}
//sin(), cos(), tan()
#pragma endregion

#pragma region Random Numbers
//void randomSeed(unsigned int seed)
//{
//	if (seed != 0) {
//	  srandom(seed);
//	}
//}
//long random(long howbig)
//{
//	if (howbig == 0) {
//		return 0;
//	}
//	return random() % howbig;
//}
//long random(long howsmall, long howbig)
//{
//	if (howsmall >= howbig) {
//		return howsmall;
//	}
//	long diff = howbig - howsmall;
//	return random(diff) + howsmall;
//}
#pragma endregion

#pragma region Bits and Bytes
#define lowByte(w) ((uint8_t) ((w) & 0xff))
#define highByte(w) ((uint8_t) ((w) >> 8))

#define bitRead(value, bit) (((value) >> (bit)) & 0x01)
#define bitSet(value, bit) ((value) |= (1UL << (bit)))
#define bitClear(value, bit) ((value) &= ~(1UL << (bit)))
#define bitWrite(value, bit, bitvalue) (bitvalue ? bitSet(value, bit) : bitClear(value, bit))
#define bit(b) (1UL << (b))
#pragma endregion

#pragma region External Interrupts
#define CHANGE 1
#define FALLING 2
#define RISING 3

/// <summary>
/// <para>Initialise une interruption</para>
/// <para>delay() won't work</para>
/// <para>millis() will not increment</para>
/// <para>Serial data lost</para>
/// <para>Déclare variables as volatile</para>
/// </summary>
/// <param name="interrupt">
/// <para>0 : pin 2</para>
/// <para>1 : pin 3</para>
/// <para>On Mega</para>
/// <para>2 : pin 21</para>
/// <para>3 : pin 20</para>
/// <para>4 : pin 19</para>
/// <para>5 : pin 18</para>
/// </param>
/// <param name="function">Function name</param>
/// <param name="mode">
/// <para>LOW : to trigger the interrupt whenever the pin is low</para>
/// <para>CHANGE : to trigger the interrupt whenever the pin changes value</para>
/// <para>RISING : to trigger when the pin goes from low to high</para>
/// <para>FALLING : for when the pin goes from high to low</para>
/// </param>
/// </summary>
//void attachInterrupt(uint8_t interruptNum, void (*userFunc)(void), int mode)
//void attachInterrupt(uint8_t interrupt, Action userFunc, int mode)
//{
//	_interrupts[interrupt] = userFunc;
//	_interruptsMode[interrupt] = mode;
//
//	if (_interruptsThread == null)
//	{
//		_interruptsThread = new Thread(InterruptsThread);
//		_interruptsThread.Name = "InterruptsThread";
//		_interruptsThread.IsBackground = true;
//		_interruptsEnabled = true;
//		_interruptsThread.Start();
//	}
//
//	//int pin = 13;
//	//volatile int state = LOW;
//
//	//void setup()
//	//{
//	//  pinMode(pin, OUTPUT);
//	//  attachInterrupt(0, blink, CHANGE);
//	//}
//	//
//	//void loop()
//	//{
//	//  digitalWrite(pin, state);
//	//}
//	//
//	//void blink()
//	//{
//	//  state = !state;
//	//}
//}
/// <summary>
/// </summary>
//void detachInterrupt(uint8_t interruptNum)
//{
//	if (_interruptsThread != null)
//	{
//		_interruptsEnabled = false;
//		_interruptsThread.Abort();
//		_interruptsThread = null;
//	}
//	_interrupts[interruptNum] = null;
//	_interruptsMode[interruptNum] = 0;
//}
#pragma endregion

#pragma region Interrupts
/// <summary>
///Disables interrupts
/// </summary>
void noInterrupts()
{ throw gcnew NotImplementedException(); }
/// <summary>
///Re-enables interrupts 
/// </summary>
void interrupts()
{ throw gcnew NotImplementedException(); }

//void loop()
//{
//    noInterrupts();
//    // critical, time-sensitive code here
//    interrupts();
//    // other code here
//}
#pragma endregion

#endif
