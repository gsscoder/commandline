using System.Collections;
using System.Linq;
using CommandLine.StringToCommandLine;
using Xunit;

namespace CommandLine.Tests.Unit.StringToCommandLine
{
   public class CSharpStyleCommandLineParserTests
   {
      [Fact]
      public void TestMethod1() { RunTest("test", new[] {"test"}); }

      [Fact]
      public void TestMethod2() { RunTest("test test", new[] {"test", "test"}); }

      [Fact]
      public void TestMethod3() { RunTest("test \"test\"", new[] {"test", "test"}); }

      [Fact]
      public void TestMethod4() { RunTest("test \"te\\\"s\\\"t\"", new[] {"test", "te\"s\"t"}); }

      [Fact]
      public void TestMethod4B() { RunTest("test \"te\\\"\\\"\\\"\\\"s\\\"t\"", new[] {"test", "te\"\"\"\"s\"t"}); }

      [Fact]
      public void TestMethod5() { Assert.Throws<StringToCommandLineParserBase.UnterminatedStringException>(() => RunTest("\"abc d e", new[] {""})); }

      [Fact]
      public void TestMethod6() { Assert.Throws<StringToCommandLineParserBase.UnterminatedEscapeException>(() => RunTest("asd\\", new[] {""})); }

      [Fact]
      public void TestMethod7() { RunTest("\\\\\\a\\b\\'\\\"\\0\\f\\t\\v", new[] {"\\\a\b\'\"\0\f\t\v"}); }

      [Fact]
      public void TestMethod8() { RunTest("Hello\\x1\\x12\\x123\\x1234", new[] {"Hello\x1\x12\x123\x1234"}); }

      private static void RunTest(string commandLine, ICollection expected)
      {
         var parser = new CSharpStyleCommandLineParser();
         var enumerable = parser.Parse(commandLine);
         Assert.Equal(expected, enumerable.ToArray());
      }
   }
}
