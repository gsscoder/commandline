using CommandLine.Text;

namespace CommandLine.Tests.Mocks
{
    public class VerbWithNullOptions
    {
        public class FooOptions
        {
            [Option("bar", HelpText = "help for bar")]
            public string Bar { get; set; }
        }

        [VerbOption("foo", HelpText = "help for foo")]
        public FooOptions Foo { get; set; }

        [HelpVerbOption]
        public string GetUsage(string verb)
        {
            bool found;
            object instance = CommandLineParser.GetVerbOptionsInstanceByName(
                verb, this, out found);
            bool verbsIndex = verb == null || !found;
            object target = verbsIndex ? this : instance;
            return HelpText.AutoBuild(
                target,
                current => HelpText.DefaultParsingErrorsHandler(target, current),
                verbsIndex);
        }
    }
}
