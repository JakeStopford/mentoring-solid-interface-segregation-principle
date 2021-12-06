namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    public class FighterJet : IFighterJet
    {
        public int Capacity { get; set; }

        public void Fly()
        {
        }

        public bool HasWings()
        {
            return true;
        }

        public void Break()
        {
        }

        public void Accelerate()
        {
        }

        public void TurnLeft()
        {
        }

        public void TurnRight()
        {
        }

        public void FireMissiles()
        {
        }

        public void TrackTarget()
        {
        }

        public void EjectPilot()
        {
        }
    }
}
