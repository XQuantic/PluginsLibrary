
namespace ds.test.impl
{
    internal interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginsNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
