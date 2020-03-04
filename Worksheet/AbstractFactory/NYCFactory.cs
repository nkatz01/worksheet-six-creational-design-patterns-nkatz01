using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using Autofac;

namespace QuestionOne
{
    class NYCFactory : AbstractParserFactory
    {



        public override IXMLParser GetParserInstance(string parserType)
        {
            if (parserType.StartsWith("nyc", StringComparison.InvariantCultureIgnoreCase))
            {

                if (parserType.Contains("Order", StringComparison.OrdinalIgnoreCase))
                {

                    return base.GetParserInstance("NYCOrder");
                }
                else if (parserType.Contains("Feedback", StringComparison.OrdinalIgnoreCase))
                    return base.GetParserInstance("NYCFeedback");
                else if (parserType.Contains("Response", StringComparison.OrdinalIgnoreCase))
                    return base.GetParserInstance("NYCResponse");
                else
                    return base.GetParserInstance("NYCError");
            }
            else
            {
                throw new ArgumentException("Not a parser that this client recognizes");
            }

        }




    }
}
