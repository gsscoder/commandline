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
        /// Creates an instance of specified type "/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        T Resolve<T>();
        /// <summary>
        /// Creates an instance of specified type "/>
        /// </summary>
        /// /// <param name="type"></param>
        /// <returns></returns>
        object Resolve(Type type);
    }
}
