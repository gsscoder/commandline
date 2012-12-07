#region License
//
// Command Line Library: ComplexOptions.cs
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

using System.ComponentModel;

namespace CommandLine.Tests.Mocks
{
    public class ComplexOptions : CommandLineOptionsBase
    {
        public ComplexOptions()
        {
            StartOffset = 0;
            Bytes = 0;
        }

        [Option("i", "input", Required = true, HelpText = "Specify input file to be processed.")]
        public string InputFileName { get; set; }

        [Option("o", "output", Required = true, HelpText = "Specify output file to be created.")]
        public string OutputFileName { get; set; }

        [Option("j", "offset", HelpText = "Processing begins from specified offset.")]
        public long StartOffset { get; set; }

        [Option("b", "bytes", HelpText = "Maximum number of bytes to process.")]
        public long Bytes { get; set; }

        public override string ToString()
        {
            return DebugStringUtil.ConvertOptionsToString(this);
        }
    }
}