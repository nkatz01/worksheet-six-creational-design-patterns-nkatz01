namespace QuestionOne
{
    public class NYCOrderXMLParser : IXMLParser
    {
        public string Parse()
        {
           return "NY Order XML Message";
        }
        public override string ToString()
        {
            return "NY Parsing order XML...\n" ; //put it in parser
        }
     
    }
}