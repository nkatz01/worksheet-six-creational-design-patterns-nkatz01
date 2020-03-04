namespace QuestionThree
{
    public class ConcreteCreator : ICreator
    {
       
        public   IProduct FactoryMethod() 
        {
           
            return new ConcreteProduct();//always returns ConcreteProduct

        }

    
    }
}