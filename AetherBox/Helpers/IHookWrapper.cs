// AetherBox, Version=69.2.0.8, Culture=neutral, PublicKeyToken=null
// AetherBox.Helpers.IHookWrapper
using System;

namespace AetherBox.Helpers;

public interface IHookWrapper : IDisposable
{
	bool IsEnabled { get; }

	bool IsDisposed { get; }

	void Enable();

	void Disable();
}
