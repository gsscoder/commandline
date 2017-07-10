using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLine.Infrastructure
{
    /// <summary>
    /// 
    /// </summary>
    public interface IObjectFactory
    {
        /// <summary>
        /// Creates and return a new instance of <see cref="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        T CreateInstance<T>();
    }

    /// <summary>
    /// Default object factory to use with parser, defaults to Activator.CreateInstance() 
    /// </summary>
    public class DefaultObjectFactory : IObjectFactory
    {
        /// <summary>
        /// Creates a new instance to be used by parser model creation/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T CreateInstance<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
