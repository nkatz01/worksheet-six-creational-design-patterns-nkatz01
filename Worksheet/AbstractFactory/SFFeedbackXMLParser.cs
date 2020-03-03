namespace QuestionOne
{
    public class SFFeedbackXMLParser : IXMLParser
    {
        public string Parse()
        {
            return "SF Feedback XML Message";
        }
        public override string ToString()
        {
            return "Parsing feedback XML...\n";
        }
    }
}