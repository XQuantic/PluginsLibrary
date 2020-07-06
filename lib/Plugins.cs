using System.Collections.Generic;

namespace ds.test.impl
{
    /// <summary>
    /// Plugins API
    /// </summary>
    public static class Plugins
    {
        /// <summary>
        /// Represents all plugins
        /// </summary>
        public static List<IPlugin> PluginItems { get; set; } = new List<IPlugin>();
        
        private static readonly IPluginFactory PluginFactory = new PluginFactory();

        /// <summary>
        /// Gets total number of plugins
        /// </summary>
        /// <returns>Plugins count</returns>
        public static int GetPluginsCount()
        {
            return PluginFactory.PluginsCount;
        }

        /// <summary>
        /// Gets plugins names
        /// </summary>
        /// <returns>Array of plugins names</returns>
        public static string[] GetPluginsNames()
        {
            return PluginFactory.GetPluginsNames;
        }

        /// <summary>
        /// Gets plugin by name
        /// </summary>
        /// <param name="pluginName">Plugin name</param>
        /// <returns>Instance of plugin</returns>
        /// <exception cref="System.InvalidOperationException">Thrown when plugin is missing</exception>
        public static IPlugin GetPlugin(string pluginName)
        {
            return PluginFactory.GetPlugin(pluginName);
        }
    }
}
