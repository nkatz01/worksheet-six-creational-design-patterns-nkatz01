using System;

namespace QuestionFive
{
    public static class TestSingletons
    {
        public static void Main(string[] args)
        {
            LazySingleton LS1 = LazySingleton.GetInstnace();
            LazySingleton LS2 = LazySingleton.GetInstnace();

            Console.WriteLine(LS1 == LS2);
           // Console.WriteLine(LS1.SomeString);

            StaticSingleton S1 = StaticSingleton.GetInstnace();
            StaticSingleton S2 = StaticSingleton.GetInstnace();


            Console.WriteLine( S1 ==  S2);

            StaticSingleton S3 = (StaticSingleton)S2.Clone();
            Console.WriteLine(S3 == S2);

            //LazySingleton ReflectedSS1 = (LazySingleton) Activator.CreateInstance(typeof(LazySingleton));
            //LazySingleton ReflectedSS2 = (LazySingleton)Activator.CreateInstance(typeof(LazySingleton));
            //LazySingleton ReflectedSS1 = (LazySingleton) typeof(LazySingleton).GetInstnace();
            //LazySingleton ReflectedSS2 = (LazySingleton) typeof(LazySingleton).GetInstnace();

            //Console.WriteLine(ReflectedSS1 == ReflectedSS2);


        }
    }
}