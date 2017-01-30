﻿using System;

namespace DLogger.Extensions.Logging
{
	internal class NullDisposable : IDisposable
	{
		public static readonly NullDisposable Instance = new NullDisposable();

		private NullDisposable() { }

		public void Dispose() { }
	}
}
