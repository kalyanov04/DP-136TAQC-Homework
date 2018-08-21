#include "stdafx.h"
#include "Fract.h"


Fract::Fract()
{
	cel = 0;
	chisl = 0;
	znam = 0;
}

void Fract::Vvod()
{
	cout << "¬ведите целую часть: ";
	cin >> cel;
	cout << "¬ведите числитель: ";
	cin >> chisl;
	cout << "¬ведите знаменатель: ";
	cin >> znam;
}

void Fract::Print()

{
	cout << "(" << cel << " " << chisl << "/" << znam << ")";
}

void Fract::Prav()

{
	cel += chisl / znam;
	chisl = abs(chisl) % znam;
}

void Fract::NePrav()

{
	chisl = chisl + cel*znam;
}

int Fract::Nod(int a, int b)
{
	while (a != b)
	{
		if (a > b)
			a = a - b;
		else
			b = b - a;
	}
	return a;
}

void Fract::Sokr()

{
	int c = Nod(abs(chisl), abs(znam));
	chisl = chisl / c;
	znam = znam / c;
}

Fract Fract::operator+ (const Fract &b)

{
	Fract tmp;
	tmp.cel = 0;
	tmp.chisl = chisl*b.znam + b.chisl*znam;
	tmp.znam = znam*b.znam;
	tmp.Sokr();
	tmp.Prav();
	return tmp;
}

Fract Fract::operator- (const Fract &b)
{
	Fract tmp;
	tmp.cel = 0;
	if (chisl==b.chisl&&znam==b.znam&&cel==b.cel)
	{
		tmp.cel = tmp.chisl = tmp.znam = 0;
		return tmp;
	}
	else
	{
		tmp.cel = 0;
		tmp.chisl = chisl*b.znam - b.chisl*znam;
		tmp.znam = znam*b.znam;
		tmp.Sokr();
		tmp.Prav();
		return tmp;
	}
}

Fract Fract::operator* (const Fract &b)
{
	Fract tmp;
	tmp.cel = 0;
	tmp.chisl = chisl*b.chisl;
	tmp.znam = znam*b.znam;
	tmp.Sokr();
	tmp.Prav();
	return tmp;
}

Fract Fract::operator/ (const Fract &b)
{
	Fract tmp;
	if (chisl == b.chisl&&znam == b.znam&&cel == b.cel)
	{
		tmp.cel = tmp.chisl = tmp.znam = 1;
		return tmp;
	}
	else
	{
		tmp.cel = 0;
		tmp.chisl = chisl*b.znam;
		tmp.znam = znam*b.chisl;
		tmp.Sokr();
		tmp.Prav();
		return tmp;
	}
}

Fract::~Fract()
{
}
