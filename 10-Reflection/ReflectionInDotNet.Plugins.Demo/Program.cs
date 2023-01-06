using ReflectionInDotNet.Plugins.Demo.Plugins;
using System;

namespace ReflectionInDotNet.Plugins.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pluginLoader = new PluginLoader();

            var plugins = pluginLoader.LoadPlugins(@"C:\Test Plugins");
            foreach (var plugin in plugins)
            {
                Console.WriteLine(plugin.Name);
                Console.WriteLine(plugin.Description);
                plugin.Introduce();
                Console.WriteLine();
            }
        }
    }
}