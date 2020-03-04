using System;

namespace QuestionFour
{
    public class AccessControl : IPrototype
    {
        public Access Access { get; set; }//eg see or not see?
      public string controlLevel { get; set; }//eg modify or not?

        public AccessControl(Access access, string controlLevel)
        {

            Access = access;
            this.controlLevel = controlLevel;

        }
        public AccessControl(AccessControl source)
        {
            this.Access = source.Access;
            this.controlLevel = source.controlLevel;


        }
        object ICloneable.Clone()
        {
            return Clone();
        }

        public AccessControl Clone()
        {
            return new AccessControl(this);    
        }
    }
}
//IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string>> 