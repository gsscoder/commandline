
namespace CommandLine.Tests.Mocks
{
    class SimpleOptionWithInvalidSuboption : OptionsBase
    {
        public SimpleOptionWithInvalidSuboption()
        {
            
        }

        public SimpleOptionWithInvalidSuboption(int i)
        {
            Opt = new SimpleSuboptionWithNoDefaultConstructor(i);
        }

        [SubOption("opt")]
        public SimpleSuboptionWithNoDefaultConstructor Opt { get; set; }
    }
}
