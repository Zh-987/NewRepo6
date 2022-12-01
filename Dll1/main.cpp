#include "pch.h"

#include "C:\Users\assai\source\repos\NewRepo6\qwerty\Header.h"

#include "C:\Users\assai\source\repos\NewRepo6\qwerty\ItStepBody.cpp"

extern "C" _declspec (dllexport) double sumTwo(double var_x, double var_y) {
	myClass MC(var_x, var_y);

	return MC.sumX_Y();
}