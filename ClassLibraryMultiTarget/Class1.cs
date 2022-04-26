using System;
using ClassLibraryTransitiveSingleTarget;

namespace ClassLibraryMultiTarget
{
    public static class Class1
    {
        public static string MyProperty => Class2.MyProperty;

#if NETSTANDARD2_0_OR_GREATER
        public static string TargetFramework { get; } = "netstandard2.0";
#elif NETCOREAPP3_1_OR_GREATER
        public static string TargetFramework { get; } = "netcoreapp3.1";
#endif
    }
}
