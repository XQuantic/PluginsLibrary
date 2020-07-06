using System;
using System.Drawing;

namespace ds.test.impl
{
    internal class Plugin : PluginConfig, IPlugin
    {
        public Image Image { get; }
        public Plugin(string pluginName, string version, string description, Image image) : base(pluginName, version, description)
        {
            Image = image;
        }

        public int Run(int input1, int input2)
        {
            switch (PluginName)
            {
                case "Addition":
                    return Addition(input1, input2);
                case "Subtraction":
                    return Subtraction(input1, input2);
                case "Multiplication":
                    return Multiplication(input1, input2);
                case "Division":
                    return Division(input1, input2);
                case "Pow":
                    return Pow(input1, input2);
                default:
                    return -1;
            }
        }
    }
}
