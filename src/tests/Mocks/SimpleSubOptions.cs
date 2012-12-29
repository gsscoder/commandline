
namespace CommandLine.Tests.Mocks
{
    class SimpleSubOptions : OptionsBase
    {
        [Option("i", "int")]
        public int IntegerValue { get; set; }
    }
}
