namespace Passenger.Core.Domain
{
    // punkt zabrania pasazera - DailyRoute bedzie miał ich liste

    // powiązanie Node - czyli w jakim miejscu zabrac pasazera i jakiego pasażera
    public class PassengerNode
    {
   
        public Node Node { get; protected set; }
        public Passenger Passenger { get; protected set; }
    }
}
