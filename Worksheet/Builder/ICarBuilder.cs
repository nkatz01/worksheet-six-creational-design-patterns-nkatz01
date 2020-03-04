namespace QuestionTwo
{
    public interface ICarBuilder
    {
        ICar GetCar();
    
    void DesignBodyStyl();
        void SetPower();
        void AddEngine();
        void InstallBrakes();
        void PutSeats();
        void InsertWindows();
        void ConfigureFuelType();
       
    }        
}