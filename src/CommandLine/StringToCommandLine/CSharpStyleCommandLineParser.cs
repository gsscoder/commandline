namespace CommandLine.StringToCommandLine
{
   /// <summary>
   /// Parse commandlines like C# would parse a string, splitting at each unquoted space:
   /// * "" ->
   /// * "abc" -> abc
   /// * abc abc -> abc, abc
   /// * "\"" -> "
   /// * asd"asd -> error
   /// * "asd -> error unterminated string
   /// * \ -> error unterminated escape
   /// * \['"\0abfnrtUuvx] -> https://msdn.microsoft.com/en-us/library/ms228362.aspx?f=255&MSPPError=-2147217396
   /// * \other -> error
   /// </summary>
   public class CSharpStyleCommandLineParser : StringToCommandLineParserBase
   {
      public override IEnumerable<string> Parse(string commandLine)
      {
         if (string.IsNullOrWhiteSpace(commandLine))
            yield break;
         var currentArg = new StringBuilder();
         var quoting = false;

         var pos = 0;
         while (pos < commandLine.Length)
         {
            var c = commandLine[pos];
            if (c == '\\')
            {
               // --- Handle escape sequences
               pos++;
               if (pos >= commandLine.Length) throw new UnterminatedEscapeException();
               switch (commandLine[pos])
               {
               case '\'':
                  c = '\'';
                  break;
               case '\"':
                  c = '\"';
                  break;
               case '\\':
                  c = '\\';
                  break;
               case '0':
                  c = '\0';
                  break;
               case 'a':
                  c = '\a';
                  break;
               case 'b':
                  c = '\b';
                  break;
               case 'f':
                  c = '\f';
                  break;
               case 'n':
                  c = ' ';
                  break;
               case 'r':
                  c = ' ';
                  break;
               case 't':
                  c = '\t';
                  break;
               case 'v':
                  c = '\v';
                  break;
               case 'x':
                  // --- Hexa escape (1-4 digits)
                  var hexa = new StringBuilder(10);
                  pos++;
                  if (pos >= commandLine.Length)
                     throw new UnterminatedEscapeException();
                  c = commandLine[pos];
                  if (char.IsDigit(c) || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'))
                  {
                     hexa.Append(c);
                     pos++;
                     if (pos < commandLine.Length)
                     {
                        c = commandLine[pos];
                        if (char.IsDigit(c) || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'))
                        {
                           hexa.Append(c);
                           pos++;
                           if (pos < commandLine.Length)
                           {
                              c = commandLine[pos];
                              if (char.IsDigit(c) || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'))
                              {
                                 hexa.Append(c);
                                 pos++;
                                 if (pos < commandLine.Length)
                                 {
                                    c = commandLine[pos];
                                    if (char.IsDigit(c) || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'))
                                    {
                                       hexa.Append(c);
                                       pos++;
                                    }
                                 }
                              }
                           }
                        }
                     }
                  }
                  c = (char) int.Parse(hexa.ToString(), NumberStyles.HexNumber);
                  pos--;
                  break;
               case 'u':
                  // Unicode hexa escape (exactly 4 digits)
                  pos++;
                  if (pos + 3 >= commandLine.Length)
                     throw new UnterminatedEscapeException();
                  try
                  {
                     var charValue = uint.Parse(commandLine.Substring(pos, 4), NumberStyles.HexNumber);
                     c = (char) charValue;
                     pos += 3;
                  }
                  catch (SystemException)
                  {
                     throw new UnrecognizedEscapeSequenceException();
                  }
                  break;
               case 'U':
                  // Unicode hexa escape (exactly 8 digits, first four must be 0000)
                  pos++;
                  if (pos + 7 >= commandLine.Length)
                     throw new UnterminatedEscapeException();
                  try
                  {
                     var charValue = uint.Parse(commandLine.Substring(pos, 8), NumberStyles.HexNumber);
                     if (charValue > 0xffff)
                        throw new UnrecognizedEscapeSequenceException();
                     c = (char) charValue;
                     pos += 7;
                  }
                  catch (SystemException)
                  {
                     throw new UnrecognizedEscapeSequenceException();
                  }
                  break;
               default:
                  throw new UnrecognizedEscapeSequenceException();
               }
               pos++;
               currentArg.Append(c);
               continue;
            }
            if (c == '"')
            {
               if (quoting)
               {
                  pos++; //skip space
                  //check that it actually IS a space or EOF
                  if (pos < commandLine.Length && !char.IsWhiteSpace(commandLine[pos]))
                     throw new UnquotedQuoteException();
                  yield return currentArg.ToString();
                  currentArg.Clear();
                  quoting = false;
               }
               else
               {
                  if (currentArg.Length > 0)
                     throw new UnquotedQuoteException();
                  quoting = true;
               }
               pos++;
               continue;
            }
            if (char.IsWhiteSpace(c) && !quoting)
            {
               if (currentArg.Length > 0)
                  yield return currentArg.ToString();
               currentArg.Clear();
               pos++;
               continue;
            }
            pos++;
            currentArg.Append(c);
         }
         if (quoting && currentArg.Length > 0)
            throw new UnterminatedStringException();
         if (currentArg.Length > 0)
            yield return currentArg.ToString();
      }
   }
}
