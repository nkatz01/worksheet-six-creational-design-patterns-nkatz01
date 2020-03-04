using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using static QuestionFour.AccessControl;
namespace QuestionFour
{
    public static class AccessControlProvider
    {
        private static IEnumerable<KeyValuePair<string, AccessControl>> _AccessCtrlPerUserLevelMap;
        public static AccessControl GetAccessControlObject(string controlLevel) {
          
            var ac = (AccessControl)_AccessCtrlPerUserLevelMap.Where(i => i.Key == controlLevel).Select(i => i.Value);
              return ac;
           
            
        }
    }
}