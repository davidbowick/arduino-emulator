#include "stdafx.h"
#include "Arduino.h"
//Delete previous lines for Arduino Compiler

//Libs
#include "lightuino5.h"
#include "FWB.h"

#define NBR_STAIR_STEP 14

#define BP_UP 0
#define BP_DOWN 1
#define BP_LED 13

#define STEP_DELAY 100

#define ANI_UP 0
#define ANI_DOWN 1
#define ANI_MAX 3

int _brightness = 30;

FWB bpUP;
FWB bpDOWN;

LightuinoSink sinks;
unsigned long int a = 0, b = 0;
unsigned char c = 0;

int _currentAnimId = 0;
int _currentAnimStep = 0;
int _increment = 1;
boolean _animated = false;
int _timeToWay = 100;
long _lastTime = 0;

#pragma region "To Reset datas, for emulator only"
void _Reset()
{
	_brightness = 30;
	a = 0, b = 0;c = 0;
	_currentAnimId = 0;
	_currentAnimStep = 0;
	_increment = 1;
	_animated = false;
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

//Animations
void AnimUP()
{
	//LED = ON => UP
	//Wait
	//LED => OFF => UP
	//End anim

	long m = millis();
	boolean onState = _currentAnimStep < NBR_STAIR_STEP;
	//Initialization
	if (_currentAnimStep == 0)
	{
		AllOff();
		SetOut(_currentAnimStep, onState);
		_currentAnimStep += _increment;
		_lastTime = m;
	}
	//Power on, wait, and power off
	if ((m - _lastTime) > _timeToWay)
	{
		int outpin = _currentAnimStep;
		if (!onState) outpin = _currentAnimStep - NBR_STAIR_STEP;

		SetOut(outpin, onState);
		_currentAnimStep += _increment;
		_lastTime = m;
		if (_currentAnimStep == NBR_STAIR_STEP)
			_timeToWay = STEP_DELAY * 10;
		if (_currentAnimStep == NBR_STAIR_STEP + 1)
			_timeToWay = STEP_DELAY;
	}

	//End of anim
	if (_currentAnimStep == NBR_STAIR_STEP * 2)
		_animated = false;
}
void AnimDOWN()
{
	//LED = ON => DOWN
	//Wait
	//LED => OFF => DOWN
	//End anim

	long m = millis();
	boolean onState = _currentAnimStep > -1;
	//Initialization
	if (_currentAnimStep == NBR_STAIR_STEP - 1)
	{
		AllOff();
		SetOut(_currentAnimStep, onState);
		_currentAnimStep += _increment;
		_lastTime = m;
	}
	//Power on, wait, and power off
	if ((m - _lastTime) > _timeToWay)
	{
		int outpin = _currentAnimStep;
		if (!onState) outpin = _currentAnimStep + NBR_STAIR_STEP;

		SetOut(outpin, onState);
		_currentAnimStep += _increment;
		_lastTime = m;
		if (_currentAnimStep == -1)
			_timeToWay = STEP_DELAY * 10;
		if (_currentAnimStep == -2)
			_timeToWay = STEP_DELAY;
	}

	//End of anim
	if (_currentAnimStep == -(NBR_STAIR_STEP + 1))
		_animated = false;

}

void Anim1()
{
	//Chenillard (aller-retour de 3 LED allumées)
	long m = millis();
	boolean onState = _currentAnimStep < NBR_STAIR_STEP;
	//Initialization
	if (_currentAnimStep == 0)
	{
		AllOff();
		SetOut(_currentAnimStep, onState);
		_currentAnimStep += _increment;
		_lastTime = m;
	}



}


void (*_animations[ANI_MAX])(void) = {AnimUP, AnimDOWN, Anim1};
// Btn events
void OnClick(int pin)
{
	//if (_animated) //Animation already in progress
	//{ }
	//else //Launch animation
	{
		if (pin == BP_UP)
		{
			_currentAnimId = 0;
			_currentAnimStep = 0;
			_timeToWay = STEP_DELAY;
			_increment = 1;
		}
		else
		{
			_currentAnimId = 1;
			_currentAnimStep = NBR_STAIR_STEP - 1;
			_timeToWay = STEP_DELAY;
			_increment = -1;
		}
		_animated = true;
	}
}
void OnDblClick(int pin) { }
void OnLongPress(int pin) { }
void OnVLongPress(int pin) { }


void setup()
{
	bpUP.Configure(BP_UP);
	bpUP.OnClick = OnClick;
	bpUP.OnDblClick = OnDblClick;
	bpUP.OnLongPress = OnLongPress;
	bpUP.OnVLongPress = OnVLongPress;

	bpDOWN.Configure(BP_DOWN);
	bpDOWN.OnClick = OnClick;
	bpDOWN.OnDblClick = OnDblClick;
	bpDOWN.OnLongPress = OnLongPress;
	bpDOWN.OnVLongPress = OnVLongPress;

	sinks.setBrightness(_brightness);

	pinMode(BP_LED, OUTPUT);

}
void loop()
{
	if (digitalRead(BP_UP) == HIGH)
		digitalWrite(BP_LED, HIGH);
	else if (digitalRead(BP_DOWN) == HIGH)
		digitalWrite(BP_LED, HIGH);
	else
		digitalWrite(BP_LED, LOW);

	// Test button state
	bpUP.CheckBP();
	bpDOWN.CheckBP();

	// Call next step
	if (_animated && _animations[_currentAnimId])
		_animations[_currentAnimId]();
}
