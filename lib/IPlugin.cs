
namespace ds.test.impl
{
    /// <summary>
    /// Plugin API
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Gets plugin name
        /// </summary>
        string PluginName { get; }

        /// <summary>
        /// Gets version dll
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Gets plugin image
        /// </summary>
        System.Drawing.Image Image { get; }

        /// <summary>
        /// Gets plugin description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Plugin operation
        /// </summary>
        /// <param name="input1">First parameter</param>
        /// <param name="input2">Second parameter</param>
        /// <returns>Result of operation</returns>
        int Run(int input1, int input2);
    }
}
