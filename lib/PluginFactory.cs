using System;
using System.Drawing;
using System.IO;

namespace ds.test.impl
{
    internal class PluginFactory : IPluginFactory
    {
        public int PluginsCount { get; }
        public string[] GetPluginsNames { get; }

        private readonly IPlugin[] _plugins;

        public PluginFactory()
        {
            try
            {
                _plugins = CreatePlugins();
                PluginsCount = _plugins.Length;
                GetPluginsNames = new string[PluginsCount];
                for (int i = 0; i < PluginsCount; i++)
                {
                    GetPluginsNames[i] = _plugins[i]?.PluginName;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public IPlugin GetPlugin(string pluginName)
        {
            try
            {
                IPlugin plugin = this[pluginName];
                return plugin;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }

        /// <summary>
        /// Indexer to search by name
        /// </summary>
        /// <param name="name">Plugin name</param>
        /// <returns>Instance of plugin</returns>
        /// <exception cref="System.InvalidOperationException">Thrown when plugin is missing</exception>
        private IPlugin this[string name]
        {
            get
            {
                foreach (var plugin in _plugins)
                {
                    if (plugin?.PluginName == name)
                    {
                        return plugin;
                    }
                }

                throw new InvalidOperationException("Plugin not found");
            }
        }
        /// <summary>
        /// Creates plugins
        /// </summary>
        /// <returns>Array of plugins</returns>
        /// <exception cref="System.InvalidOperationException">Thrown when resource is missing</exception>
        private static IPlugin[] CreatePlugins()
        {
            byte[] data = (byte[]) Resource.ResourceManager.GetObject("Addition");
            MemoryStream ms = new MemoryStream(data ?? throw new InvalidOperationException("Addition resource not found"));
            Image image = Image.FromStream(ms);
            Plugins.PluginItems.Add(new Plugin("Addition", "1.0", "Addition of two numbers", new Bitmap(image)));

            data = (byte[]) Resource.ResourceManager.GetObject("Subtraction");
            ms = new MemoryStream(data ?? throw new InvalidOperationException("Subtraction resource not found"));
            image = Image.FromStream(ms);
            Plugins.PluginItems.Add(new Plugin("Subtraction", "1.0", "Subtraction of two numbers", new Bitmap(image)));

            data = (byte[]) Resource.ResourceManager.GetObject("Multiplication");
            ms = new MemoryStream(data ?? throw new InvalidOperationException("Multiplication resource not found"));
            image = Image.FromStream(ms);
            Plugins.PluginItems.Add(new Plugin("Multiplication", "1.0", "Multiplication of two numbers", new Bitmap(image)));

            data = (byte[]) Resource.ResourceManager.GetObject("Division");
            ms = new MemoryStream(data ?? throw new InvalidOperationException("Division resource not found"));
            image = Image.FromStream(ms);
            Plugins.PluginItems.Add(new Plugin("Division", "1.0", "Division of two numbers", new Bitmap(image)));

            data = (byte[]) Resource.ResourceManager.GetObject("Pow");
            ms = new MemoryStream(data ?? throw new InvalidOperationException("Pow resource not found"));
            image = Image.FromStream(ms);
            Plugins.PluginItems.Add(new Plugin("Pow", "1.0", "Exponentiation", new Bitmap(image)));

            return Plugins.PluginItems.ToArray();
        }
    }
}
