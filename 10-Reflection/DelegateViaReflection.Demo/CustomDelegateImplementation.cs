using System.Reflection;

namespace DelegateViaReflection.Demo
{
    internal class CustomDelegateImplementation
    {
        public object? Instance { get; set; }

        required public MethodInfo Method { get; set; }

        public object Invoke(params object[] arguments)
        {
            return Method.Invoke(Instance, arguments);
        }
    }
}
