#region License
//
// Command Line Library: ValueListAttributeFixture.cs
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
using System.Collections.Generic;
using System.ComponentModel;
using NUnit.Framework;
#endregion

namespace CommandLine.Tests
{
    [TestFixture]
    public class ValueListAttributeFixture : BaseFixture
    {
        #region Mock Objects
        private class MockSpecializedList : List<string>
        {
        }

        private class MockOptions
        {
            [ValueList(typeof(List<string>))]
            public IList<string> Values { get; set; }
        }
        #endregion

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WillThrowExceptionIfConcreteTypeIsNull()
        {
            new ValueListAttribute(null);
        }

        [Test]
        [ExpectedException(typeof(CommandLineParserException))]
        public void WillThrowExceptionIfConcreteTypeIsIncompatible()
        {
            new ValueListAttribute(new List<object>().GetType());
        }

        [Test]
        public void ConcreteTypeIsGenericListOfString()
        {
            new ValueListAttribute(new List<string>().GetType());
        }

        [Test]
        public void ConcreteTypeIsGenericListOfStringSubType()
        {
            new ValueListAttribute(new MockSpecializedList().GetType());
        }

        [Test]
        public void GetGenericListOfStringInterfaceReference()
        {
            var options = new MockOptions();

            IList<string> values = ValueListAttribute.GetReference(options);
            Assert.IsNotNull(values);
            Assert.AreEqual(typeof(List<string>), values.GetType());
        }

        [Test]
        public void UseGenericListOfStringInterfaceReference()
        {
            var options = new MockOptions();

            var values = ValueListAttribute.GetReference(options);
            values.Add("value0");
            values.Add("value1");
            values.Add("value2");

            //Assert.AreEqual("value0", options.Values[0]);
            //Assert.AreEqual("value1", options.Values[1]);
            //Assert.AreEqual("value2", options.Values[2]);
            base.AssertArrayItemEqual(new string[] { "value0", "value1", "value2" }, options.Values);
        }
    }
}