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
       

    
               public override IXMLParser GetParserInstance(string parserType)//chcek that it belongs to NYC
        {

            return base.GetParserInstance(parserType);

        }



    
    }
}
