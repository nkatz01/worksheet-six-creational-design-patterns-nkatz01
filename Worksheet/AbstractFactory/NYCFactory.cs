using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOne
{
    class NYCFactory : IAbstractParserFactory
    {

        public IXMLParser GetParserInstance(string parserType)
        {

            return new NYCFeedbackXMLParser();
        }
    }
}
