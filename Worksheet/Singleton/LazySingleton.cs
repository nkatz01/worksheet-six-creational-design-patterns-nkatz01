using System;

namespace QuestionFive
{
    [Serializable]
    public class LazySingleton
    {

        private static LazySingleton _LSInstance { get; set; } 

        public string SomeString { get; set; }
        private LazySingleton()
        {

        }

        private LazySingleton(string SomeString)
        {
            this.SomeString = SomeString;
        }
        //Not thread safe but only instanciates it on demend thus avoiding instanciation everytime the class is loaded. 
        //The reason I may choose to do this is because I have full control over instantiation and can do tasks beforehand and use a non-defualt constroctor.
        public  static LazySingleton GetInstnace() {  
            
       

            if (_LSInstance == null)
            
                _LSInstance = new LazySingleton("What's up");

            

            return _LSInstance;
             
        }

        public LazySingleton ShallowCopy()
        {
            return (LazySingleton)this.MemberwiseClone();
        }
    }

 
}