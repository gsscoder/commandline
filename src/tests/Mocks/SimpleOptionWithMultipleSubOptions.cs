
namespace CommandLine.Tests.Mocks
{
    class SimpleOptionWithMultipleSubOptions : OptionsBase
    {
        [SubOption("first")]
        public SimpleSubOptions Sub1 { get; set; }

        [SubOption("second")]
        public SimpleSubOptions Sub2 { get; set; }
    }
}
