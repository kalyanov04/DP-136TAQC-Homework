#pragma once
#include"stdafx.h"
class Fract
{
	int chisl;
	int znam;
	int cel;
public:
	Fract();
	void Vvod();
	void Print();
	void Prav();
	void NePrav();
	int Nod(int, int);
	void Sokr();
	Fract operator+ (const Fract &);
	Fract operator- (const Fract &);
	Fract operator* (const Fract &);
	Fract operator/ (const Fract &);
	~Fract();
};

