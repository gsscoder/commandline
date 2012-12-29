
namespace CommandLine.Tests.Mocks
{
    class SimpleOptionsWithSuboptionWithMultipleAliases : OptionsBase
    {
        [SubOption("co")]
        [SubOption("checkout")]
        public SimpleSubOptions SubOpt { get; set; }
    }
}
