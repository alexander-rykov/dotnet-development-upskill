using ReflectionInDotNet.Plugins.Demo.Plugins;
using System;

namespace ReflectionInDotNet.Plugins
{
    public class AnotherPlugin : IPlugin
    {
        public string Name => "AnotherPlugin";

        public string Description => "This is the another plugin.";

        public void Introduce()
        {
            Console.WriteLine($"{Name} is dynamically loaded from the separate dll.");
        }
    }
}