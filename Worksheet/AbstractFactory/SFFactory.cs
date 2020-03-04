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
                return base.GetParserInstance(parserType);
            else
            {
                throw new ArgumentException("Not a parser that this client recognizes");
            }

          
          
        }
    }
}
