using System.Collections;
using System.Linq;
using CommandLine.StringToCommandLine;
using Xunit;

namespace CommandLine.Tests.Unit.StringToCommandLine
{
   public class DefaultWindowsCommandLineParserTests
   {
      [Fact]
      public void TestMethod1() { RunTest("test", new[] {"test"}); }

      [Fact]
      public void TestMethod2() { RunTest("test test", new[] {"test", "test"}); }

      [Fact]
      public void TestMethod3() { RunTest("test \"test\"", new[] {"test", "test"}); }

      [Fact]
      public void TestMethod4() { RunTest("test \"te\"s\"t\"", new[] {"test", "test"}); }

      [Fact]
      public void TestMethod4B() { RunTest("test \"te\"\"\"\"s\"t\"", new[] {"test", "te\"\"st"}); }

      [Fact]
      public void TestMethod5() { RunTest("\"abc\" d e", new[] {"abc", "d", "e"}); }

      [Fact]
      public void TestMethod6() { RunTest("a\\\\b d\"e f\"g h", new[] {"a\\\\b", "de fg", "h"}); }

      [Fact]
      public void TestMethod7() { RunTest("a\\\\\\\"b c d", new[] {"a\\\"b", "c", "d"}); }

      [Fact]
      public void TestMethod8() { RunTest("a\\\\\\\\\"b c\" d e", new[] {"a\\\\b c", "d", "e"}); }

      private static void RunTest(string commandLine, ICollection expected)
      {
         var parser = new DefaultWindowsCommandLineParser();
         var enumerable = parser.Parse(commandLine);
         Assert.Equal(expected, enumerable.ToArray());
      }
   }
}
