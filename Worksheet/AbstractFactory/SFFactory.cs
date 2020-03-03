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

            return base.GetParserInstance(parserType);
          
        }
    }
}
