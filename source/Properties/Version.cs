﻿//158
// 
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// 

using System.Reflection;

[assembly: AssemblyFileVersion("1.2.99.158")]
[assembly: AssemblyVersion("1.2.99.0")]
[assembly: KSPAssembly("MoarKerbals", 1,2,99)]

namespace MoarKerbals
{
	public static class Version
	{
		public const int major = 1;
		public const int minor = 2;
		public const int patch = 99;
		public const int build = 0;
		public const string Number = "1.2.99.0";
#if DEBUG
        public const string Text = Number + "-zed'K DEBUG";
#else
        public const string Text = Number + "-prerelease zed'K ";
#endif
	}
}