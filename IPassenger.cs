namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    public interface IPassenger : IAirCraft
    {
        bool HasOnboardMeal { get; set; }

        void StartBeverageService();
    }
}
