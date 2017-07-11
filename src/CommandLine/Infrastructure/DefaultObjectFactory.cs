using System;

namespace CommandLine.Infrastructure
{
    /// <summary>
    /// Default object factory to use with parser, defaults to Activator.CreateInstance() 
    /// </summary>
    public class DefaultObjectFactory : IObjectFactory
    {
        /// <inheritdoc />
        public T Resolve<T>()
        {
            return Activator.CreateInstance<T>();
        }

        /// <inheritdoc />
        public object Resolve(Type type)
        {
            return Activator.CreateInstance(type);
        }
    }
}