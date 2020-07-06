
using System;

namespace ds.test.impl
{
    internal abstract class PluginConfig
    {
        public string PluginName { get; }
        public string Version { get; }
        public string Description { get; }

        protected PluginConfig(string pluginName, string version, string description)
        {
            PluginName = pluginName;
            Version = version;
            Description = description;
        }

        protected static int Addition(int a, int b) => a + b;
        protected static int Subtraction(int a, int b) => a - b;
        protected static int Multiplication(int a, int b) => a * b;
        protected static int Division(int a, int b) => a / b;
        protected static int Pow(int a, int b) => (int)Math.Pow(a, b);
    }
}
