#pragma once

#define WIN32_LEAN_AND_MEAN

#define DLL_EXPORT _declspec(dllexport)
#include "Windows.h"
#include <string>

extern "C" DLL_EXPORT void GetInfo(char* buffer)
{
	const char* str = "SwapR&B";

	memcpy(buffer, str, 8);
	buffer[8] = '0';
};

extern "C" DLL_EXPORT void Method(BYTE* r, BYTE* g, BYTE* b, int len)
{
	for (int i = 0; i < len; i++)
	{
		BYTE tmp_R = r[i];
		r[i] = b[i];
		b[i] = tmp_R;
	}
}

//extern "C" DLL_EXPORT void Method(int* mas, int len)
//{
//	for (int i = 0; i < len / 2; i++)
//	{
//		int iCol = mas[i];
//		int col = iCol;
//		unsigned char R = (unsigned char)(col >> 16);
//		col = 0 << 16 & col;
//		unsigned char G = (unsigned char)(col >> 8);
//		col = 0 << 8 & col;
//		unsigned char B = (unsigned char)col;
//
//		mas[i] = (R << 16) | (G << 8) | (B);
//	}
//}


#undef WIN32_LEAN_AND_MEAN
