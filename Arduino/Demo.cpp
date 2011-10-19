#include "stdafx.h"
#include "Arduino.h"
//Delete previous lines for Arduino Compiler

//Libs
#include "lightuino5.h"

#define BP 0
#define BP_LED 13
#define PWM_LED 11


#pragma region "To Reset datas, for emulator only"
void _Reset()
{
	// Add your variables here to reset there value
}
#pragma endregion

void setup()
{
	pinMode(BP, INPUT);
	//pinMode(A0, INPUT);

	pinMode(BP_LED, OUTPUT);
	pinMode(A2, OUTPUT);
	pinMode(PWM_LED, OUTPUT);
}

void loop()
{
	int state = LOW;
	int analogValue = analogRead(A0);
	if (analogValue == 42 || digitalRead(BP))
		state = HIGH;

	digitalWrite(BP_LED, state);
	digitalWrite(A2, state);
	analogWrite(PWM_LED, analogValue);
}
