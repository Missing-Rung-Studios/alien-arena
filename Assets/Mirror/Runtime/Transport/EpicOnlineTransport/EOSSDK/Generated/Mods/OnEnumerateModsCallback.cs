// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Mods
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="ModsInterface.EnumerateMods" />
	/// </summary>
	/// <param name="data">A <see cref="EnumerateModsCallbackInfo" /> containing the output information and result</param>
	public delegate void OnEnumerateModsCallback(EnumerateModsCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnEnumerateModsCallbackInternal(System.IntPtr data);
}