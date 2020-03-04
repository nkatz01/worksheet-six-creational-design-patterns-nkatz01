using static QuestionTwo.Car;
using static QuestionTwo.ConcreteCar;
namespace QuestionTwo
{
    public class SportsCarBuilder : ICarBuilder
    {
        private ICar _car = new ConcreteCar("SPORTS");//is it better to use highest level up and interface? (obviously needed to do so here becuase of how teacher did getResults method)
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
        public void DesignBodyStyl() { _car.BodyStyle = "External dimensions: overall length(inches): 192.3, overall width(inches): 75.5, overall height(inches): 54.2, wheelbase(inches): 112.3, front track(inches): 63.7, rear track(inches): 64.1 and curb to curb turning circle(feet): 37.7"; }
        public void SetPower()
        {
            _car.Power = "323 hp @ 6,800 rpm; 278 ft lb of torque @ 4,800 rpm";
        }

        public void AddEngine()
        {
            _car.Engine = "3.6L V 6 DOHC and variable valve timing";
        }

        public void InstallBrakes()
        {
            _car.Brakes = "Four - wheel disc brakes: two ventilated. Electronic brake distribution.StabiliTrak stability control";
            ;
        }
        public void PutSeats() { _car.Seats = "Driver sports front seat with one power adjustments manual height, front passenger seat sports front seat with one power adjustments"; }
        public void InsertWindows() { _car.Windows = "Front windows with one-touch on two windows"; }
        public void ConfigureFuelType() { _car.FuelType = "Petrol 17 MPG city, 28 MPG motorway, 20 MPG combined and 380 mi.range"; }

    }
}