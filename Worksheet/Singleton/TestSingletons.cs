using Autofac;
using Autofac.Configuration;
 
using System.Diagnostics;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using Microsoft.Extensions.Configuration;

namespace QuestionFive
{
    public static class TestSingletons
    {
        private static IContainer Container { get; set; }
        public static void Main(string[] args)
        {
            StaticSingleton S1 = StaticSingleton.GetInstnace();
            StaticSingleton S2 = StaticSingleton.GetInstnace();
            //  Console.WriteLine( S1 ==  S2);//prints true
            //breaking static init by clonning 
            StaticSingleton S3 = S2.ShallowCopy();
            //  Console.WriteLine(S3 == S2); //prints false
            //=====================================================================================

            LazySingleton LS1 = LazySingleton.GetInstnace();
            LazySingleton LS2 = LazySingleton.GetInstnace();
            //   Console.WriteLine(LS1 == LS2); // prints true
            //Benefits of none-default constructor
            // Console.WriteLine(LS1.SomeString);

            //breaking lazy by cloning    
            LazySingleton LS3 = LS2.ShallowCopy();
            //Console.WriteLine(LS3 == LS2);//prints false

            LazySingleton LS4 = (LazySingleton)typeof(LazySingleton).InvokeMember("LazySingleton", BindingFlags.CreateInstance | BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);// breaking static init by reflection
                                                                                                                                                                                                          // Console.WriteLine(LS4 == LS2);//prints false 

            var BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream stream = File.Open(@"..\..\..\..\LazySingltonBinary.txt", FileMode.Create);
            BinaryFormatter.Serialize(stream, LS2);
            stream.Close();

            stream = File.Open(@"..\..\..\..\LazySingltonBinary.txt", FileMode.Open); BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter(); //https://stackoverflow.com/questions/6115721/how-to-save-restore-serializable-object-to-from-file
                                                                                                                                                                              //breaking lazy by serialization
            LazySingleton LS5 = (LazySingleton)(object)BinaryFormatter.Deserialize(stream);
            //Console.WriteLine(LS5 == LS2);//prints false


            LazySingletonProt LSP1 = LazySingletonProt.GetInstnace();
            //Fix against cloning - throws exception - LazySingletonProt implements shallow copy method
            //  LazySingletonProt LSP2 = LSP1.ShallowCopy();

            //Fix against reflection -  throws exception
            // LazySingletonProt LSP3 = (LazySingletonProt)typeof(LazySingletonProt).InvokeMember("LazySingletonProt", BindingFlags.CreateInstance | BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);

            BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            stream = File.Open(@"..\..\..\..\LazySingltonProtBinary.txt", FileMode.Create);
            //Fix against serialization - LazySingletonProt returns same instance
            BinaryFormatter.Serialize(stream, LSP1);
            stream.Close();

            stream = File.Open(@"..\..\..\..\LazySingltonProtBinary.txt", FileMode.Open);

            BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();//https://stackoverflow.com/questions/6115721/how-to-save-restore-serializable-object-to-from-file
            LazySingletonProt LSP4 = (LazySingletonProt)(object)BinaryFormatter.Deserialize(stream);
            // Console.WriteLine(LSP4 == LSP1);//prints true

            //I assume that even LazySingletonProt will not be a cross domain singleton; I don't know how to implement it in a way so to make sure that it is.




        }


    }
}

