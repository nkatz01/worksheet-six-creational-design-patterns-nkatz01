using static QuestionTwo.Car;
using static QuestionTwo.ConcreteCar;
namespace QuestionTwo
{
    public class SportsCarBuilder: ICarBuilder
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
        public void BodyStyl(string bs) { _car.BodyStyle = bs; }
public void   SetPower(string pow) {
_car.Power = pow;
}

public void AddEngine(string eng) {
_car.Engine = eng;
}

public void InstallBrakes(string brks) { _car.Brakes = brks; }
public void PutSeats(string seats) { _car.Seats = seats; }
public void InsertWindows(string wins) { _car.Windows = wins; }
public void ConfigureFuelType(string ft) { _car.FuelType = ft; }
        public void BrandCarType(string carType)//do we need this method? are we even allowed this?
        {
            _car.CarType = carType;
        }
    }
}