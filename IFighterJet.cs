namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    public interface IFighterJet : IAirCraft
    {
        void FireMissiles();

        public void TrackTarget();

        public void EjectPilot();
    }
}
