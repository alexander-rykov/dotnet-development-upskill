namespace ReflectionInDotNet.Plugins.Demo.Plugins
{
    public interface IPlugin
    {
        string Name { get; }

        string Description { get; }

        void Introduce();
    }
}
