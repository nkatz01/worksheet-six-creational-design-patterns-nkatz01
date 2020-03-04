namespace QuestionTwo
{
    public class CarDirector : ICarDirector
    {
        private ICarBuilder _CarBuilder { set; get; }
        public CarDirector(ICarBuilder cb)
        {
            _CarBuilder = cb; 
        }

        public void Build()
        { 
            _CarBuilder.DesignBodyStyl(); 
            _CarBuilder.SetPower(); 
            _CarBuilder.AddEngine(); 
            _CarBuilder.InstallBrakes();
            _CarBuilder.PutSeats(); 
            _CarBuilder.InsertWindows();
            _CarBuilder.ConfigureFuelType();
 
 
 
 


        }

    }
}