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

#define Lightuino_MAX_BRIGHTNESS (4096*2)
#define Lightuino_MIN_INTENSITY 17

#define LightuinoPwm FlickerBrightness

using namespace System;


namespace Arduino
{
	public ref class OutputChangedEventArgs : public System::EventArgs
	{
	private:
		int _id;
		int _value;

	public:
		OutputChangedEventArgs(int id, int value)
		{
			_id = id;
			_value = value;
		}

		property int ID
		{
			int get()
			{
				return _id;
			}
		}
		property int Value
		{
			int get()
			{
				return _value;
			}
		}
	};

	public ref class Lightuino
	{
	private:
		array<int> ^ _brightness;
		array<int> ^ _previousBrightness;


#pragma region Singleton
	private:
		static Lightuino ^ _instance;
		SynchronizationContext ^ _currentContext;
		Lightuino()
		{
			_currentContext = SynchronizationContext::Current;
			_brightness = gcnew array<int>(Lightuino_NUMOUTS);
			_previousBrightness = gcnew array<int>(Lightuino_NUMOUTS);
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
	public: event EventHandler<OutputChangedEventArgs ^> ^ OnPinStateChanged;
	public:
		void RefreshChangedPinState()
		{
			for (int i=0;i<Lightuino_NUMOUTS;i++)
			{
				if (_previousBrightness[i] != _brightness[i])
				{
					OutputChangedEventArgs ^ args = gcnew OutputChangedEventArgs(i, _brightness[i]);
					_currentContext->Send(gcnew SendOrPostCallback(this, &Lightuino::OnPinStateChangedEvent), args );
				}
			}
		}

		void SetPinState(int pin, int value)
		{
			_previousBrightness[pin] = _brightness[pin];
			_brightness[pin] = value;
		}
	private:
		void OnPinStateChangedEvent(Object ^ oPin)
		{
			OnPinStateChanged(nullptr, (OutputChangedEventArgs ^)oPin);
		}
#pragma endregion

#pragma region PWM Timer
	private:
		Timers::Timer ^ _pwmTimer;
		//int (*_brightnessTimer)[Lightuino_NUMOUTS];
		IntPtr ^ _flcBri;

	public:
		//void StartPWMAutoLoop(int (*brightness)[Lightuino_NUMOUTS])
		void StartPWMAutoLoop(int * brightness)
		{
			//_brightnessTimer = brightness;
			_flcBri = gcnew IntPtr(brightness);

			//int * bri = (int*)_flcBri->ToPointer();
			//int (*_brightnessTimer)[Lightuino_NUMOUTS] = &bri;

			_pwmTimer = gcnew Timers::Timer(10);
			_pwmTimer->Elapsed += gcnew Timers::ElapsedEventHandler(this, &Arduino::Lightuino::PWMTimer_Elapsed);
			_pwmTimer->Enabled = true;
		}
		void StopPWMAutoLoop()
		{
			_pwmTimer->Enabled = false;
			_pwmTimer = nullptr;
			//_brightnessTimer = 0;
		}

	private:
		void PWMTimer_Elapsed(Object^ source, Timers::ElapsedEventArgs^ e )
		{
			_pwmTimer->Enabled = false;
			try
			{
				int * pBrightness = (int*)_flcBri->ToPointer();
				for (int i=0;i<Lightuino_NUMOUTS;i++)
				{
					//SetPinState(i, _brightnessTimer[0][i]);
					SetPinState(i, pBrightness[i]);
				}

				RefreshChangedPinState();
			}
			catch (Exception ^ ex)
			{

			}
			_pwmTimer->Enabled = true;
		}

#pragma endregion

	};
}

public class LightuinoSink
{
private:
	uint8_t clockPin;
	uint8_t brightPin;
	uint8_t serDataPin[2];
	uint8_t _brightness;
	uint8_t _previousBrightness;

public:
	LightuinoSink(uint8_t clkPin=Lightuino_CLOCK_PIN, uint8_t dataPin1=Lightuino_SER_DATA_LEFT_PIN, uint8_t dataPin2=Lightuino_SER_DATA_RIGHT_PIN, uint8_t brightnessPin=Lightuino_BRIGHTNESS_PIN)
	{
		clockPin = clkPin;
		serDataPin[0] = dataPin1;
		serDataPin[1] = dataPin2;
		brightPin = brightnessPin;

		//Initialized value at Setup
		//EMULATOR_CTOR();
	}
	void EMULATOR_CTOR()
	{
		pinMode(clockPin, OUTPUT);			// sets the digital pin as output
		pinMode(serDataPin[0], OUTPUT);     // sets the digital pin as output
		pinMode(serDataPin[1], OUTPUT);     // sets the digital pin as output
		pinMode(brightPin,OUTPUT);

		set(0, 0, 0);						// Clear out any random settings caused by power up
		analogWrite(brightPin,255);			// Turn brightness fully on by default -- helps initial adopters
	}

	void setBrightness(uint8_t b)
	{
		if (brightPin<0xff)
		{
			analogWrite(brightPin,b);
			_previousBrightness = _brightness;
			_brightness = b;
		}
	}

	void set(unsigned long int a, unsigned long int b, unsigned long int c)
	{
		unsigned long int data[3];
		data[0] = a;
		data[1] = b;
		data[2] = c;

		safeSet(data);
	}

public:
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

			Arduino::Lightuino::CurrentInstance->SetPinState(i, (serDataVal[0] != 0) ? _brightness : 0);
			Arduino::Lightuino::CurrentInstance->SetPinState(i + 35, (serDataVal[1] != 0) ? _brightness : 0);
		}

		Arduino::Lightuino::CurrentInstance->RefreshChangedPinState();
	}

};

public class FlickerBrightness
{
public:
	int brightness[Lightuino_NUMOUTS];
	//int minBrightness;

private:
	//int offset;
	//unsigned int frame;
	//LightuinoSink& brd;
	//FlickerBrightness* next;
	// In global normaly
	//FlickerBrightness* gleds; //= 0;

public:
	FlickerBrightness(LightuinoSink& mybrd)//:brd(mybrd)
	{
		for (int i=0;i<Lightuino_NUMOUTS;i++)
		{
			brightness[i] = 0;
		}

		//offset = Lightuino_NUMOUTS-1;
		//minBrightness = 11;
		//next = 0;
		//gleds = 0;
	}

	//void shift(int amt=1)
	//{ 
	//	offset+=amt; 
	//	if (offset>=M5451_NUMOUTS) offset -=Lightuino_NUMOUTS; 
	//	else if (offset<0) offset +=Lightuino_NUMOUTS; 
	//}

	void loop(void)
	{
		for (int i=0;i<Lightuino_NUMOUTS;i++)
		{
			Arduino::Lightuino::CurrentInstance->SetPinState(i, brightness[i]);
		}

		Arduino::Lightuino::CurrentInstance->RefreshChangedPinState();
	}

	void StartAutoLoop(int rate=4096)
	{
		//brightness[1] = 42;
		//brightness[5] = 69;
		Arduino::Lightuino::CurrentInstance->StartPWMAutoLoop(brightness);
	}

	void StopAutoLoop(void)
	{
		Arduino::Lightuino::CurrentInstance->StopPWMAutoLoop();
	}

private:
	unsigned long reverseframe(unsigned int x)
	{
		unsigned int h = 0;
		unsigned char i = 0;

		for(h = i = 0; i < 13; i++) {
			h = (h << 1) + (x & 1); 
			x >>= 1; 
		}

		return h;
	}
};

public class ChangeBrightness
{
private:
	//FlickerBrightness& brd;
	//FlickerBrightness &brd;
	FlickerBrightness* brd;
	int change[Lightuino_NUMOUTS];
	int count[Lightuino_NUMOUTS];
	int destination[Lightuino_NUMOUTS];  
	int bresenham[Lightuino_NUMOUTS];
	void (*doneCall)(ChangeBrightness& me, int led);

public:
	// Pass the constructor a FlickerBrightness object and also a callback (optional).  When this class finished moving a LED
	// to the desired brightness, it will call the callback so you can program a new intensity target in.
	ChangeBrightness(FlickerBrightness& thebrd, void (*doneCallback)(ChangeBrightness& me, int led)=0)//:brd(thebrd)
	{
		brd = &thebrd;
		doneCall = doneCallback;
		for (int i=0;i<Lightuino_NUMOUTS;i++)
		{
			change[i] = 0;
			count[i]  = 0;
			destination[i] = 0;
			bresenham[i] = 0;
		}
	}

	// Transition the light at index 'led' to intensity over count iterations
	void set(uint8_t led, uint16_t intensity, int transitionDuration) // transitionDuration == count
	{
		if (led<Lightuino_NUMOUTS)
		{
			if (transitionDuration<1) transitionDuration=1;  // Fix up impossible values
			count[led] = transitionDuration;
			destination[led] = intensity;
			change[led] = ((long int) intensity) - ((long int) brd->brightness[led]);
		}
	}

	// Call loop periodically and rapidly to change the brightness.  This function calls FlickerBrightness.loop(), so
	// it is unnecessary for you to do so.
	void loop(void)
	{
		unsigned char j;
		for (j=0;j<Lightuino_NUMOUTS;j++)
		{
			if (destination[j] != brd->brightness[j]) // This led is changing
			{
				bresenham[j] += change[j];
				/* Note that if change could be > count then this should be a while loop */
				while ((bresenham[j]<0)&& (brd->brightness[j] != destination[j]))
				{ bresenham[j]+=count[j]; brd->brightness[j]--;}
				while ((bresenham[j]>=count[j])&& (brd->brightness[j] != destination[j]))
				{ bresenham[j]-=count[j]; brd->brightness[j]++;}

				if (brd->brightness[j] == destination[j])
				{
					bresenham[j]=0;
					if (doneCall)
						(*doneCall)(*this,j);
				}
			}
		}

		brd->loop();
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
