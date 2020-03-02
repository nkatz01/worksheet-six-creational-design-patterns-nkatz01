using System;
using System.Collections.Generic;
using System.Text;
 using System.Diagnostics;
using System.Reflection;
using Autofac;

namespace QuestionOne
{
    class NYCFactory : IAbstractParserFactory
    {
        private static IContainer Container { get; set; }

        public IXMLParser GetParserInstance(string parserType)
        {

            var dataAccess = Assembly.GetExecutingAssembly();
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(dataAccess)
                    .Where(t => t.Name.StartsWith(parserType))
                    .AsImplementedInterfaces();
            //builder.RegisterAssemblyTypes(dataAccess)
            //        .Where(t => t.Name.EndsWith("MessageRenderer"))
            //        .AsImplementedInterfaces();

            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var specificTypeParser = scope.Resolve<IXMLParser>();
                //var mp = scope.Resolve<IMessageProvider>();
                //mr.MessageProvider = mp;
                //mr.Render();

                    return specificTypeParser;
            }



















          
        }
    }
}
