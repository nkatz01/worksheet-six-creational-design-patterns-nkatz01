using System;
using System.Runtime.Serialization;

namespace QuestionFive

{
    [Serializable]
    public class LazySingletonProt : ISerializable
    {
        
        private static LazySingletonProt _LSInstance { get; set; } 

        public string SomeString { get; set; }
       
        private LazySingletonProt()
        {
            if (_LSInstance != null)
            {
                throw new Exception("Cannot create singleton instance through reflection");//https://www.csharpstar.com/singleton-design-pattern-csharp/
            }
        }

    
        
       
        public  static LazySingletonProt GetInstnace() {  
            
       

            if (_LSInstance == null)
            
                _LSInstance = new LazySingletonProt();

            

            return _LSInstance;
             
        }

        public LazySingletonProt ShallowCopy()
        {
            throw new System.Exception("Sorry matey, this is supposed to be a singleton, remember?");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.SetType(typeof(LazySingletonProtHelper));
        }

        [Serializable]//http://geekswithblogs.net/maziar/archive/2012/07/19/serializing-singleton-objects-c.aspx
        private class LazySingletonProtHelper : IObjectReference
        {
            public object GetRealObject(StreamingContext context)
            {
                return LazySingletonProt.GetInstnace();
            }
        }
    }

   

}