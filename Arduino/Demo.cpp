#include "stdafx.h"
#include "Arduino.h"
//Delete previous lines for Arduino Compiler

//Libs
#include "lightuino5.h"

#define BP 0
#define BP_LED 13
#define PWM_LED 11
#define L_PWM_LED 0

#define NBR_LED 10
#define STEP_DELAY 100

int _brightness = 50;

LightuinoSink sinks;
FlickerBrightness pwm(sinks);
ChangeBrightness smthPwm(pwm);

bool _changeProgress = false;

unsigned long int a = 0, b = 0;
unsigned char c = 0;

int _currentAnimStep = 0;
int _increment = 1;
int _timeToWay = 100;
long _lastTime = 0;


#pragma region "To Reset datas, for emulator only"
void _Reset()
{
	// Add your variables here to reset there value
	_currentAnimStep = 0;
	_increment = 1;
	_timeToWay = 100;
	_lastTime = 0;
}
#pragma endregion

void AllOff()
{
	a = 0; b = 0; c = 0;
	sinks.set(a, b, c);
}
void AllOn()
{
	a = 0xffffffff; b = 0xffffffff; c = B00111111;
	sinks.set(a, b, c);
}
void SetOut(int id, boolean state)
{
	if (state)
		setbit(id, &a, &b, &c);
	else
		clearbit(id, &a, &b, &c);
	sinks.set(a, b, c);
}
 
void Animation()
{
	long m = millis();
	boolean onState = _currentAnimStep < NBR_LED;
	//Initialization
	if (_currentAnimStep == 0)
	{
		AllOff();

		//SetOut(_currentAnimStep, onState);
		pwm.brightness[_currentAnimStep] = onState ? _brightness : 0;

		_currentAnimStep += _increment;
		_lastTime = m;
	}
	//Power on, wait, and power off
	if ((m - _lastTime) > _timeToWay)
	{
		int outpin = _currentAnimStep;
		if (!onState) outpin = _currentAnimStep - NBR_LED;

		//SetOut(outpin, onState);
		pwm.brightness[outpin] = onState ? _brightness : 0;

		_currentAnimStep += _increment;
		_lastTime = m;
		if (_currentAnimStep == NBR_LED)
			_timeToWay = STEP_DELAY * 10;
		if (_currentAnimStep == NBR_LED + 1)
			_timeToWay = STEP_DELAY;
	}

	//End of anim
	if (_currentAnimStep == NBR_LED * 2)
		_currentAnimStep = 0;

	pwm.loop();
}
void PWM()
{
	pwm.brightness[35] = Lightuino_MAX_BRIGHTNESS-1;

	int brightnes = 0;
	for (int i=0;i<70;i++)
	{
		pwm.brightness[i] = brightnes;
		brightnes += 3;
		delay(20);
	}

	//for (int j=0;j<600;j++)
	//{
	//	for (int i=0;i<70;i++)
	//		pwm.brightness[i] = (((i*3)+j)*100)%Lightuino_MAX_BRIGHTNESS;
	//	delay(10);
	//}

	// Turn off all leds
	for (int i=0;i<70;i++)
		pwm.brightness[i] = 0;

	//pwm.StopAutoLoop();
	//pwm.loop();
}

 
void setup()
{
	pinMode(BP, INPUT);

	pinMode(BP_LED, OUTPUT);
	pinMode(A2, OUTPUT);
	pinMode(PWM_LED, OUTPUT);

	sinks.EMULATOR_CTOR();
	sinks.setBrightness(_brightness);

	pwm.StartAutoLoop(4000);
}

void loop()
{
	int state = LOW;
	_brightness = analogRead(A0);
	int index = analogRead(A1);

	pwm.brightness[index] = _brightness;

	if (_brightness == 42 || digitalRead(BP))
		state = HIGH;

	if (state == HIGH && !_changeProgress) 
	{
		smthPwm.set(L_PWM_LED, 254, 100);
		_changeProgress = true;
	}
	if(pwm.brightness[L_PWM_LED] == 254 && _changeProgress)
	{
		_changeProgress = false;
		smthPwm.set(L_PWM_LED, 0, 100);
	}

	digitalWrite(BP_LED, _changeProgress);
	digitalWrite(A2, state);
	analogWrite(PWM_LED, analogRead(A3));

	smthPwm.loop();

	//Animation();
	//PWM();

}
