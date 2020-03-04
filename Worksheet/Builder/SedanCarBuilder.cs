namespace QuestionTwo
{
    public class SedanCarBuilder : ICarBuilder
    {


        private ICar _car = new ConcreteCar("ESTATE");//is it better to use highest level up and interface? (obviously needed to do so here becuase of how teacher did getResults method)
        public ICar GetCar()
        {
            ICar car = _car;
            this.Reset();
            return car;
        }

        public void Reset()
        {
            _car = new ConcreteCar("");
        }
        public void DesignBodyStyl() { _car.BodyStyle = "External dimensions: overall length(inches): 202.9, overall width(inches): 76.2, overall height(inches): 60.7, wheelbase(inches): 112.9, front track(inches): 65.3, rear track(inches): 65.5 and curb to curb turning circle(feet): 39.5"; }
        public void SetPower()
        {
            _car.Power = "285 hp @ 6, 500 rpm; 253 ft lb of torque @ 4,000 rpm";
        }

        public void AddEngine()
        {
            _car.Engine = "3.5L Duramax V 6 DOHC";
        }

        public void InstallBrakes() { _car.Brakes = "Four - wheel disc brakes: two ventilated. Electronic brake distribution"; }
        public void PutSeats() { _car.Seats = "Front seat centre armrest.Rear seat centre armrest.Split - folding rear seats"; }
        public void InsertWindows() { _car.Windows = "Laminated side windows.Fixed rear window with defroster"; }
        public void ConfigureFuelType() { _car.FuelType = "Petrol 19 MPG city, 29 MPG motorway, 23 MPG combined and 437 mi.range"; }

    }
}