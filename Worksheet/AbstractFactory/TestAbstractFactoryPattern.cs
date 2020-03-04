using System;
using System.Text;

namespace QuestionOne
{
    public static class TestAbstractFactoryPattern
    {
        private const string Divider = "*******************************";

        public static void Main(string[] args)
        {
            IAbstractParserFactory parserFactory = ParserFactoryProducer.GetFactory("NYCFactory");
            IXMLParser parser = parserFactory.GetParserInstance("NYCOrder");//ask, why two factories? 
            Console.WriteLine(parser.Parse());

            Console.WriteLine(Divider);

            parserFactory = ParserFactoryProducer.GetFactory("SFFactory");
            parser = parserFactory.GetParserInstance("SFFeedback");
            Console.WriteLine(parser.Parse());
        }
    }
}