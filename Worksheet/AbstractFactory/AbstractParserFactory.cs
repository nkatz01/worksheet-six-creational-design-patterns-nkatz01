using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using Autofac;

namespace QuestionOne
{
    abstract class AbstractParserFactory : IAbstractParserFactory
    {
        private static IContainer Container { get; set; }
        public virtual IXMLParser GetParserInstance(string parserType) {

  
        var dataAccess = Assembly.GetExecutingAssembly();
        var builder = new ContainerBuilder();

        builder.RegisterAssemblyTypes(dataAccess)
                    .Where(t => t.Name.StartsWith(parserType))
                    .AsImplementedInterfaces();
     

        Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var specificTypeParser = scope.Resolve<IXMLParser>();

                Console.WriteLine(specificTypeParser.ToString());
                return specificTypeParser;
            }
         }


      
    }
}


 