using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
//using static QuestionFour.AccessControl;
namespace QuestionFour
{
    public static class AccessControlProvider
    {
        private static  IDictionary<string, AccessControl> _AccessCtrlPerUserLevelMap;




      private static IDictionary<string, AccessControl> CreateACObjects() {

            if (_AccessCtrlPerUserLevelMap == null)
            {
                Console.WriteLine("Fetching data from external resources and creating access control objects...");

                _AccessCtrlPerUserLevelMap = new ConcurrentDictionary<string, AccessControl>(
                    new Dictionary<string, AccessControl>()
               {
            {"USER", new AccessControl(Access.DoWork, "USER") },
              {"MANAGER",  new AccessControl(Access.Generate, "MANAGER") }
                  });


            }
             
                return _AccessCtrlPerUserLevelMap;
              
}

    

     


        public static AccessControl GetAccessControlObject(string controlLevel) {





            CreateACObjects().TryGetValue(controlLevel, out AccessControl AC);

            

            return  AC.Clone();

         }
    }
}