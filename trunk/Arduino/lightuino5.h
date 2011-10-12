// lightuino5.h
#pragma once

#define M5451_NUMOUTS 35
#define Lightuino_NUMOUTS 70
#define Lightuino_NUM_SINKS 70

// Default selection pin
#define Lightuino_CLOCK_PIN 7
#define Lightuino_SER_DATA_LEFT_PIN 6
#define Lightuino_SER_DATA_RIGHT_PIN 4
#define Lightuino_BRIGHTNESS_PIN 5

#define Lightuino_SRC_CLOCK_PIN 8
#define Lightuino_SRC_DATA_PIN 4
#define Lightuino_SRC_STROBE_PIN 6


using namespace System;

namespace Arduino {

	public ref class Output
	{
	private:
		int _id;
		bool _state;

	public:
		Output(int id, int value)
		{
			_id = id;
			_state = (value != 0);
		}

		property int ID
		{
			int get()
			{
				return _id;
			}
		}
		property bool State
		{
			bool get()
			{
				return _state;
			}
		}
	};

	public ref class Lightuino
	{
#pragma region Singleton
	private:
		static Lightuino ^ _instance;
		SynchronizationContext ^ _currentContext;
		Lightuino()
		{
			_currentContext = SynchronizationContext::Current;
		}
	public:
		static property Lightuino ^ CurrentInstance
		{
			Lightuino ^ get()
			{
				if (_instance == nullptr)
					_instance = gcnew Lightuino();
				return _instance;
			}
		}
#pragma endregion

#pragma region OnPinChanged
	public: event EventHandler ^ OnPinStateChanged;
	public:
		void UpdatePinState(Output ^ pin)
		{ _currentContext->Send(gcnew SendOrPostCallback(this, &Lightuino::OnPinStateChangedEvent), pin); }
	private:
		void OnPinStateChangedEvent(Object ^ oPin)
		{ OnPinStateChanged(oPin, nullptr); }
#pragma endregion
	};
}
public class LightuinoSink
{
public:
	uint8_t clockPin;
	uint8_t brightPin;
	uint8_t serDataPin[2];

	LightuinoSink(uint8_t clkPin=Lightuino_CLOCK_PIN, uint8_t dataPin1=Lightuino_SER_DATA_LEFT_PIN, uint8_t dataPin2=Lightuino_SER_DATA_RIGHT_PIN, uint8_t brightnessPin=Lightuino_BRIGHTNESS_PIN)
	{
		clockPin = clkPin;
		serDataPin[0] = dataPin1;
		serDataPin[1] = dataPin2;
		brightPin = brightnessPin;

		pinMode(clkPin, OUTPUT);      // sets the digital pin as output
		pinMode(serDataPin[0], OUTPUT);      // sets the digital pin as output
		pinMode(serDataPin[1], OUTPUT);      // sets the digital pin as output
		pinMode(brightPin,OUTPUT);

	}

	void setBrightness(uint8_t b)
	{
		if (brightPin<0xff)
			analogWrite(brightPin,b);
	}

	void set(unsigned long int a, unsigned long int b, unsigned long int c)
	{
		unsigned long int data[3];
		data[0] = a;
		data[1] = b;
		data[2] = c;

		safeSet(data);
	}

private:
	void safeSet(unsigned long int a[3])
	{
		unsigned long int d2[2];
		d2[0] = a[1]>>3 | (a[2] << 29);
		d2[1] = a[2]>>3;

		for (int i=0;i<M5451_NUMOUTS;i++)
		{
			int serDataVal[2];
			if (i<32) { serDataVal[0] = (a[0]&1); a[0]>>=1;}
			else { serDataVal[0] = (a[1]&1); a[1]>>=1;}
			if (i<32) { serDataVal[1] = (d2[0]&1); d2[0]>>=1;}
			else { serDataVal[1] = (d2[1]&1); d2[1]>>=1;}

			Arduino::Output ^ lOut = gcnew Arduino::Output(i, serDataVal[0]);
			Arduino::Output ^ rOut = gcnew Arduino::Output(i + 35, serDataVal[1]);

			Arduino::Lightuino::CurrentInstance->UpdatePinState(lOut);
			Arduino::Lightuino::CurrentInstance->UpdatePinState(rOut);
		}
	}

};




void setbit(unsigned char offset,unsigned long int* a, unsigned long int* b, unsigned char* c)
{
	if (offset < 32) *a |= 1UL<<offset;
	else if (offset < 64) *b |= 1UL<<(offset-32);
	else if (offset < Lightuino_NUMOUTS) *c |= 1UL<<(offset-64);
}
void clearbit(unsigned char offset,unsigned long int* a, unsigned long int* b, unsigned char* c)
{
	if (offset < 32) *a &= ~(1UL<<offset);
	else if (offset < 64) *b &= ~(1UL<<(offset-32));
	else if (offset < Lightuino_NUMOUTS) *c &= ~(1UL<<(offset-64));
}
unsigned int reverse16bits(unsigned int x) {
	unsigned int h = 0;
	unsigned char i = 0;

	for(h = i = 0; i < 16; i++) {
		h = (h << 1) + (x & 1); 
		x >>= 1; 
	}

	return h;
}
