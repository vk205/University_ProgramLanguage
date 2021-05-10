#pragma once

#define WIN32_LEAN_AND_MEAN

#define DLL_EXPORT _declspec(dllexport)
#include "Windows.h"
#include <string>

extern "C" DLL_EXPORT void GetInfo(char* buffer)
{
	const char* str = "Discoloration";

	memcpy(buffer, str, 14);
	buffer[14] = '0';
};

extern "C" DLL_EXPORT void Method(BYTE* r, BYTE* g, BYTE* b, int len)
{
	for (int i = 0; i < len; i++)
	{
		int tmp = (r[i] + b[i] + g[i]) / 3;
		r[i] = (BYTE)tmp;
		g[i] = (BYTE)tmp;
		b[i] = (BYTE)tmp;
	}
}