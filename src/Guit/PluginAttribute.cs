﻿using System;

namespace Guit
{
    /// <summary>
    /// Used in codegen from targets to inject the known built-in plugins.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    class PluginAttribute : Attribute
    {
        public PluginAttribute(string assemblyFileName) => AssemblyFileName = assemblyFileName;

        public string AssemblyFileName { get; }
    }
}
