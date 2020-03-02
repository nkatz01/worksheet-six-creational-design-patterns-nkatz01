using System.Configuration;
using System;

namespace QuestionOne
{
    public static class ParserFactoryProducer
    {

        internal static IAbstractParserFactory specificCompanyFactory { get; set; }

     
        
        
        public static IAbstractParserFactory GetFactory(string nyFactory)
        {    var appSettings = ConfigurationManager.AppSettings;
            var companyFactory = appSettings[nyFactory];
            var t = Type.GetType(companyFactory);
             specificCompanyFactory = Activator.CreateInstance(t) as IAbstractParserFactory;
            return specificCompanyFactory;
           
        }
    }
}