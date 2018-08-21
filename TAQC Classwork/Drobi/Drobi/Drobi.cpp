// Drobi.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(LC_ALL, "rus");

	Fract a;
	Fract b;
	Fract c;
	a.Vvod();
	b.Vvod();
	a.NePrav();
	b.NePrav();
	cout << "Summa\n";
	c = a + b;
	c.Print();
	cout << "\nRaznost\n";
	c = a - b;
	c.Print();
	cout << "\nProizv\n";
	c = a*b;
	c.Print();
	cout << "\nDelenie\n";
	c = a / b;
	c.Print();
	cout << endl;
	return 0;
}

