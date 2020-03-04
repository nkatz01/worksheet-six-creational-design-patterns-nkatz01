using System;

namespace QuestionThree
{
    public class Creator : ICreator
    {

     
       

        public   IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }

        public IProduct FactoryMethod(string s)  
        {
            return new ConcreteProduct();//may create someProduct that also implements Iproduct
        }
    }
}