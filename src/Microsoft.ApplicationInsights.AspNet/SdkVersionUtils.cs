﻿namespace Microsoft.ApplicationInsights.AspNet
{ 
    using System.Linq;
    using System.Reflection;

    internal class SdkVersionUtils
    {
        internal const string VersionPrefix = "aspnet5: ";

        internal static string GetAssemblyVersion()
        {
            return typeof(SdkVersionUtils).GetTypeInfo().Assembly.GetCustomAttributes<AssemblyFileVersionAttribute>()
                    .First()
                    .Version;
        }
    }
}
