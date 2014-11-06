using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

/**
The MIT License (MIT)
	
	Copyright (c) 2014 Mario Retana
		
		Permission is hereby granted, free of charge, to any person obtaining a copy
		of this software and associated documentation files (the "Software"), to deal
		in the Software without restriction, including without limitation the rights
		to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
		copies of the Software, and to permit persons to whom the Software is
		furnished to do so, subject to the following conditions:
		
		The above copyright notice and this permission notice shall be included in all
		copies or substantial portions of the Software.
		
		THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
		IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
		FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
		AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
		LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
		OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
		SOFTWARE.
**/

// This class shows a popup using the device's native library.
public class NativePopup{

	#if UNITY_IOS
	[DllImport("__Internal")]
	extern static private void _showNativeAlert(string title, string message);

	// Shows a UIAlertView on iOS with title and message strings and a "OK" button.
	public static void showNativeAlert(string title, string message)
	{
		_showNativeAlert (title, message);
	}
	#endif
}