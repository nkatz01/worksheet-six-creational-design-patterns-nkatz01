using System;
using System.Collections.Generic;
using System.Text;
 using System.Diagnostics;
using System.Reflection;
using Autofac;

namespace QuestionOne
{
    class SFFactory : AbstractParserFactory
    {
         

        public override IXMLParser GetParserInstance(string parserType)
        {
            if (parserType.StartsWith("sf", StringComparison.InvariantCultureIgnoreCase))

                

                    if (parserType.Contains("Order", StringComparison.OrdinalIgnoreCase))
                    {

                        return base.GetParserInstance("SFOrder");
                    }
                    else if (parserType.Contains("Feedback", StringComparison.OrdinalIgnoreCase))
                        return base.GetParserInstance("SFFeedback");
                    else if (parserType.Contains("Response", StringComparison.OrdinalIgnoreCase))
                        return base.GetParserInstance("SFResponse");
                    else
                        return base.GetParserInstance("SFCError");
                

             else
            {
                throw new ArgumentException("Not a parser that this client recognizes");
            }

          
          
        }
    }
}
