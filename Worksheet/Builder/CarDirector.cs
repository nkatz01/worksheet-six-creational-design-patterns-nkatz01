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


            _CarBuilder.BodyStyl("External dimensions: overall length(inches): 202.9, overall width(inches): 76.2, overall height(inches): 60.7, wheelbase(inches): 112.9, front track(inches): 65.3, rear track(inches): 65.5 and curb to curb turning circle(feet): 39.5");


            _CarBuilder.SetPower("285 hp @ 6, 500 rpm; 253 ft lb of torque @ 4,000 rpm");






            _CarBuilder.AddEngine(" 3.5L Duramax V 6 DOHC");






            _CarBuilder.InstallBrakes("Four - wheel disc brakes: two ventilated. Electronic brake distribution");
            _CarBuilder.PutSeats("Front seat centre armrest.Rear seat centre armrest.Split - folding rear seats");

            _CarBuilder.InsertWindows("Laminated side windows.Fixed rear window with defroster");
            _CarBuilder.ConfigureFuelType("Petrol 19 MPG city, 29 MPG motorway, 23 MPG combined and 437 mi.range");
           // _CarBuilder.BrandCarType();


        }

    }
}