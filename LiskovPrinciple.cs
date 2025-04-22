namespace C_;

public class LiskovPrinciple
{
    // Define a base interface for common behavior
    public interface IBike
    {
        void Accelerate();
    }

    // Define an interface for vehicles with engines
    public interface IEngineBike : IBike
    {
        void TurnOnEngine();
    }

    // Motorcycle implements IEngineVehicle because it has an engine
    public class Motorcycle : IEngineBike
    {
        private bool isEngineOn = false;
        private int speed = 0;

        public void TurnOnEngine()
        {
            isEngineOn = true;
        }

        public void Accelerate()
        {
            speed += 1;
        }
    }

    // Cycle only implements IVehicle because it has no engine
    public class Cycle : IBike
    {
        private int speed = 0;

        public void Accelerate()
        {
            speed += 1;
        }
    }
}
