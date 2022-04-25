using System;

namespace ClassLibraryMultiTarget
{
    public static class Class1
    {
#if NETSTANDARD2_0_OR_GREATER
        public static string TargetFramework { get; } = "netstandard2.0";
#elif NETCOREAPP3_1_OR_GREATER
        public static string TargetFramework { get; } = "netcoreapp3.1";
#endif
    }
}
