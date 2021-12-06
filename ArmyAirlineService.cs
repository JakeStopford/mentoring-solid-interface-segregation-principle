namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    class ArmyAirlineService
    {
        public FighterJet GetAirCraft()
        {
            return new FighterJet
            {
                Capacity = 2
            };
        }
    }
}
