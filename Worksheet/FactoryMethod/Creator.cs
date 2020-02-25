using System;

namespace QuestionThree
{
    public class Creator : ICreator
    {
        public IProduct FactoryMethod(string s) // some type of argument - you might change this
        {
            throw new NotImplementedException();
        }

        public IProduct FactoryMethod()
        {
            throw new NotImplementedException();
        }
    }
}