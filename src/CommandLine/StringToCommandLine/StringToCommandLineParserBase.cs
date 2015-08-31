using System;
using System.Collections.Generic;

namespace CommandLine.StringToCommandLine
{
   public abstract class StringToCommandLineParserBase
   {
      public abstract IEnumerable<string> Parse(string commandLine);

      public class UnterminatedStringException : ArgumentException {}

      public class UnrecognizedEscapeSequenceException : ArgumentException {}

      public class UnquotedQuoteException : ArgumentException {}

      public class UnterminatedEscapeException : ArgumentException {}
   }
}
