namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    public class PassengerAirlinesService
    {
        private readonly PassengerAirlineRequest _passengerAirlineRequest;

        public PassengerAirlinesService(PassengerAirlineRequest passengerAirlineRequest)
        {
            _passengerAirlineRequest = passengerAirlineRequest;
        }

        public Passenger GetAirCraft()
        {
            return new Passenger
            {
                Capacity = _passengerAirlineRequest.Capacity,
                HasOnboardMeal = _passengerAirlineRequest.HasMeal,
            };
        }
    }
}
