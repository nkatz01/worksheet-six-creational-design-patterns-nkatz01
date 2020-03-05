using System;
using System.IO;
using System.Reflection;
 //using static QuestionFive.LazySingletonProt;
namespace QuestionFive
{
    public static class TestSingletons
    {
        public static void Main(string[] args)
        {  
             StaticSingleton S1 = StaticSingleton.GetInstnace();
            StaticSingleton S2 = StaticSingleton.GetInstnace();
          //  Console.WriteLine( S1 ==  S2);//prints true

           StaticSingleton S3 = S2.ShallowCopy();//breaking static init by clonning 
          //  Console.WriteLine(S3 == S2); //prints false
          //=====================================================================================

            LazySingleton LS1 = LazySingleton.GetInstnace();
            LazySingleton LS2 = LazySingleton.GetInstnace();
         //   Console.WriteLine(LS1 == LS2); // prints true
            // Console.WriteLine(LS1.SomeString);//Benefits of none-default constructor

            LazySingleton LS3 = LS2.ShallowCopy();//breaking lazy by cloning             //   Console.WriteLine(LS3 == LS2);//prints false

            LazySingleton LS4 = (LazySingleton) typeof(LazySingleton).InvokeMember("LazySingleton", BindingFlags.CreateInstance | BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);// breaking static init by reflection
           // Console.WriteLine(LS4 == LS2);//prints false 
           
             var BinaryFormatter =  new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream stream = File.Open(@"..\..\..\..\LazySingltonBinary.txt", FileMode.Create);
          BinaryFormatter.Serialize(stream, LS2);
            stream.Close();

              stream = File.Open(@"..\..\..\..\LazySingltonBinary.txt", FileMode.Open);
            
               BinaryFormatter  = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();//breaking lazy by serialization //https://stackoverflow.com/questions/6115721/how-to-save-restore-serializable-object-to-from-file
            LazySingleton  LS5  =(LazySingleton)(object) BinaryFormatter.Deserialize(stream);
            Console.WriteLine(LS5 == LS2);//prints false
             

             LazySingletonProt  LSP1 = LazySingletonProt.GetInstnace();
            ////  LazySingletonProt LSP2 = LSP1.ShallowCopy();//Fix against cloning - throws exception

            //// LazySingletonProt LSP3 = (LazySingletonProt)typeof(LazySingletonProt).InvokeMember("LazySingletonProt", BindingFlags.CreateInstance | BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);//Fix against reflection -  throws exception


            

            BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            stream = File.Open(@"..\..\..\..\LazySingltonProtBinary.txt", FileMode.Create);
            BinaryFormatter.Serialize(stream, LSP1);
           // stream.Close();

            stream = File.Open(@"..\..\..\..\LazySingltonProtBinary.txt", FileMode.Open);

            BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();//https://stackoverflow.com/questions/6115721/how-to-save-restore-serializable-object-to-from-file
            LazySingletonProt LSP4 = (LazySingletonProt)(object)BinaryFormatter.Deserialize(stream);
            // Console.WriteLine(LSP4.GetType());
            Console.WriteLine(LSP4 == LSP1);//prints true








        }
    }
}