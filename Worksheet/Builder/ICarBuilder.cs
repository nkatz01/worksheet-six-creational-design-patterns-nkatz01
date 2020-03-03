namespace QuestionTwo
{
    public interface ICarBuilder
    {
        ICar GetCar();
    
    void BodyStyl(string bs);
        void SetPower(string pow);
        void AddEngine(string eng);
        void InstallBrakes(string brks);
        void PutSeats(string seats);
        void InsertWindows(string wins);
        void ConfigureFuelType(string ft);
        void BrandCarType(string ct);
    }        
}