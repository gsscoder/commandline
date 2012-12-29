
namespace CommandLine.Tests.Mocks
{
    class SimpleOptionsWithSubOption : OptionsBase
    {
        [Option("s", "string")]
        public string StringValue { get; set; }

        [SubOption("suboption")]
        public SimpleSubOptions SubOptions { get; set; }
    }
}
