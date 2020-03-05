using System;
namespace QuestionFive

{
    [Serializable]
    public class LazySingletonProt1
    {
        
        private static LazySingletonProt1 _LSInstance { get; set; } 

        public string SomeString { get; set; }
       
        private LazySingletonProt1()
        {
            if (_LSInstance != null)
            {
                throw new Exception("Cannot create singleton instance through reflection");//https://www.csharpstar.com/singleton-design-pattern-csharp/
            }
        }

        private LazySingletonProt1(string SomeString)
        {
            if (_LSInstance != null)
            {
                throw new Exception("Cannot create singleton instance through reflection");
            }
            this.SomeString = SomeString;
        }
        //Not thread safe but only instanciates it on demend thus avoiding instanciation everytime the class is loaded. 
        //The reason I may choose to do this is because I have full control over instantiation and can do tasks beforehand and use a non-defualt constroctor.
       
        public  static LazySingletonProt1 GetInstnace() {  
            
       

            if (_LSInstance == null)
            
                _LSInstance = new LazySingletonProt1("What's up");

            

            return _LSInstance;
             
        }

        public LazySingletonProt1 ShallowCopy()
        {
            throw new System.Exception("Sorry matey, this is supposed to be a singleton, remember?");
        }

        public Object readResolve()
        {
            return GetInstnace();
        }
    }

 
}