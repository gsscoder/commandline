namespace CommandLine.StringToCommandLine
{
   /// <summary>
   /// Parse commandlines like CommandLineToArgvW:
   /// * 2n backslashes followed by a quotation mark produce n backslashes followed by a quotation mark.
   /// * (2n) + 1 backslashes followed by a quotation mark again produce n backslashes followed by a quotation mark.
   /// * n backslashes not followed by a quotation mark simply produce n backslashes.
   /// * Unterminated quoted strings at the end of the line ignores the missing quote.
   /// </summary>
   public class DefaultWindowsCommandLineParser : StringToCommandLineParserBase
   {
      public override IEnumerable<string> Parse(string commandLine)
      {
         if (string.IsNullOrWhiteSpace(commandLine))
            yield break;
         var currentArg = new StringBuilder();
         var quoting = false;
         var emptyIsAnArgument = false;
         var lastC = '\0';
         // Iterate all characters from the input string
         foreach (var c in commandLine)
         {
            if (c == '"')
            {
               var nrbackslash = 0;
               for (var i = currentArg.Length - 1; i >= 0; i--)
               {
                  if (currentArg[i] != '\\') break;
                  nrbackslash++;
               }
               //* 2n backslashes followed by a quotation mark produce n backslashes followed by a quotation mark.
               //also cover nrbackslack == 0
               if (nrbackslash%2 == 0)
               {
                  if (nrbackslash > 0)
                     currentArg.Length = currentArg.Length - nrbackslash/2;
                  // Toggle quoted range
                  quoting = !quoting;
                  emptyIsAnArgument = true;
                  if (quoting && lastC == '"')
                  {
                     // Doubled quote within a quoted range is like escaping
                     currentArg.Append(c);
                     lastC = '\0'; //prevent double quoting
                     continue;
                  }
               }
               else
               {
                  // * (2n) + 1 backslashes followed by a quotation mark again produce n backslashes followed by a quotation mark.
                  currentArg.Length = currentArg.Length - nrbackslash/2 - 1;
                  currentArg.Append(c);
               }
            }
            else if (!quoting && char.IsWhiteSpace(c))
            {
               // Accept empty arguments only if they are quoted
               if (currentArg.Length > 0 || emptyIsAnArgument)
                  yield return currentArg.ToString();
               // Reset for next argument
               currentArg.Clear();
               emptyIsAnArgument = false;
            }
            else
            {
               // Copy character from input, no special meaning
               currentArg.Append(c);
            }
            lastC = c;
         }
         // Save last argument
         if (currentArg.Length > 0 || emptyIsAnArgument)
            yield return currentArg.ToString();
      }
   }
}
