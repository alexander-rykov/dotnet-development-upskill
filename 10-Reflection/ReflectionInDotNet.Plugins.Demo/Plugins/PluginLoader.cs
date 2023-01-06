using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ReflectionInDotNet.Plugins.Demo.Plugins
{
    public class PluginLoader
    {
        public IEnumerable<IPlugin> LoadPlugins(string folderPath)
        {
            // Load assemblies from the specified path
            var assembliesPaths = Directory.GetFiles(folderPath, "*.dll");
            foreach (var assemplyPath in assembliesPaths)
            {
                var assembly = Assembly.LoadFrom(assemplyPath);

                // Find all types that implement the IPlugin interface
                var pluginTypes = assembly.GetTypes().Where(t => typeof(IPlugin).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

                foreach (var plugin in pluginTypes.Select(t => (IPlugin)Activator.CreateInstance(t)))
                {
                    yield return plugin;
                }
            }
        }
    }
}
