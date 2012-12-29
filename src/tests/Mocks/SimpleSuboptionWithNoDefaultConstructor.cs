
namespace CommandLine.Tests.Mocks
{
    class SimpleSuboptionWithNoDefaultConstructor : OptionsBase
    {
        [Option("i", null)]
        public int SomethingElse { get; set; }

        public int Value { get; private set; }

        public SimpleSuboptionWithNoDefaultConstructor(int val)
        {
            Value = val;
        }
    }
}
