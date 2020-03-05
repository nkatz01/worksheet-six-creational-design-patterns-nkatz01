using System;

namespace QuestionFive
{
    public class StaticSingleton// : ICloneable
    {
        //With this solution, everytime 

        private StaticSingleton()
        {

        }
        //Here we have less control over instantiation, as this is initialized by the .NET envorinment the first time a memebr of this class, such as the GetInstance method, is referenced
        //but it's safer for the purpose of multi-threading because it's handeled by the CLR. Still, unlike the LasySingleton, it doesn't allow for a non-defualt constructor.
        private static StaticSingleton _LSInstance = new StaticSingleton();


        public static StaticSingleton GetInstnace()  
        {

             
            return _LSInstance;}
                
       
        public StaticSingleton ShallowCopy()
        {
            return (StaticSingleton)this.MemberwiseClone();
        }

        public StaticSingleton getinstance()
        {

            return _LSInstance;
        }


      


        //public   Object Clone()
        //{

        //    return base.MemberwiseClone();
        //}

        
    }

    


}