using System;
using System.Collections.Generic;
using System.Text;
 using System.Diagnostics;
using System.Reflection;
using Autofac;

namespace QuestionOne
{
    class NYCFactory :  AbstractParserFactory
    {
       

    
               public override IXMLParser GetParserInstance(string parserType)
        {
            if (parserType.StartsWith("nyc",StringComparison.InvariantCultureIgnoreCase))
            return base.GetParserInstance(parserType);//could chip off first 3 chars, turn them to CAPS, turn rest to lower, so to allow this method also to be called with a not exact name of parser instance, as in teacher's demo...
            else
            {
                throw new ArgumentException("Not a parser that this client recognizes");
            }

        }



    
    }
}
