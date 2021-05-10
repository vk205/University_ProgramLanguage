#pragma once

#define WIN32_LEAN_AND_MEAN

#define DLL_EXPORT _declspec(dllexport)
#include "Windows.h"
#include <string>

extern "C" DLL_EXPORT void GetInfo(char* buffer)
{
	const char* str = "Inverse";

	memcpy(buffer, str, 8);
	buffer[8] = '0';
};

extern "C" DLL_EXPORT void Method(BYTE* r, BYTE* g, BYTE* b, int len)
{
	for (int i = 0; i < len; i++)
	{
		r[i] = (BYTE)255-r[i];
		g[i] = (BYTE)255 - g[i];
		b[i] = (BYTE)255 - b[i];
	}
}
