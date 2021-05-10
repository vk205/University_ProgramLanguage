#pragma once

#define WIN32_LEAN_AND_MEAN

#define DLL_EXPORT _declspec(dllexport)
#include "Windows.h"
#include <string>

extern "C" DLL_EXPORT void GetInfo(char* buffer)
{
	const char* str = "Rotate180";

	memcpy(buffer, str, 10);
	buffer[10] = '0';
};

extern "C" DLL_EXPORT void Method(BYTE * r, BYTE*g, BYTE *b, int len)
{
	for (int i = 0; i < len / 2; i++)
	{
		BYTE tmp_R = r[i];
		BYTE tmp_G = g[i];
		BYTE tmp_B = b[i];

		r[i] = r[len - i - 1];
		g[i] = g[len - i - 1];
		b[i] = b[len - i - 1];

		r[len - i - 1] = tmp_R;
		g[len - i - 1] = tmp_G;
		b[len - i - 1] = tmp_B;
	}
}

//extern "C" DLL_EXPORT void Method(int* mas, int len)
//{
//	for (int i = 0; i < len / 2; i++)
//	{
//		int tmp = mas[i];
//		mas[i] = mas[len - i - 1];
//		mas[len - i - 1] = tmp;
//	}
//}

#undef WIN32_LEAN_AND_MEAN
