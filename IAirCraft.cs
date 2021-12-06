namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    public interface IAirCraft
    {
        int Capacity { get; set; }

        void Fly();

        void Break();

        void Accelerate();

        void TurnLeft();
        void TurnRight();
    }
}