#region License
//
// Command Line Library: OptionAttribute.cs
//
// Author:
//   Giacomo Stelluti Scala (gsscoder@gmail.com)
//
// Copyright (C) 2005 - 2012 Giacomo Stelluti Scala
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion
#region Using Directives
using System;
#endregion

namespace CommandLine
{
    /// <summary>
    /// Models an option specification.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property , AllowMultiple=false, Inherited=true)]
    public class OptionAttribute : BaseOptionAttribute
    {
        private readonly string _uniqueName;
        private string _mutuallyExclusiveSet;

        internal const string DefaultMutuallyExclusiveSet = "Default";

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandLine.OptionAttribute"/> class.
        /// </summary>
        /// <param name="shortName">The short name of the option or null if not used.</param>
        /// <param name="longName">The long name of the option or null if not used.</param>
        public OptionAttribute(string shortName, string longName)
        {
            if (!string.IsNullOrEmpty(shortName))
                _uniqueName = shortName;
            else if (!string.IsNullOrEmpty(longName))
                _uniqueName = longName;

            if (_uniqueName == null)
                throw new InvalidOperationException();

            base.ShortName = shortName;
            base.LongName = longName;
        }

#if UNIT_TESTS
        internal OptionInfo CreateOptionInfo()
        {
            return new OptionInfo(base.ShortName, base.LongName);
        }
#endif

        internal string UniqueName
        {
            get { return _uniqueName; }
        }

        /// <summary>
        /// Gets or sets the option's mutually exclusive set.
        /// </summary>
        public string MutuallyExclusiveSet
        {
            get { return _mutuallyExclusiveSet; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _mutuallyExclusiveSet = OptionAttribute.DefaultMutuallyExclusiveSet;
                else
                    _mutuallyExclusiveSet = value;
            }
        }
    }
}