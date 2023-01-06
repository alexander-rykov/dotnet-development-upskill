using System;

namespace ReflectionInDotNet.Plugins.Demo.Plugins
{
    internal class Plugin : IPlugin
    {
        public string Name => "Plugin";

        public string Description => "This is the plugin";

        public void Introduce()
        {
            Console.WriteLine($"{Name} is dynamically loaded from the separate dll.");
        }
    }
}
