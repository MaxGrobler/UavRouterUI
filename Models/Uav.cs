namespace UavRouteUI.Models
{
    public class Uav {
        public int UavId { get; set; }
        public required string Make { get; set; }
        public required string Model { get; set; }
        public required string Name { get; set; }
        public double WeightKg { get; set; }
        public double FuelCapacityKg { get; set; }
        public double RangeKm { get; set; }
        public double TopSpeedKph { get; set; }
        public double CruiseSpeedKph { get; set; }
        public double MaxAltitudeMeters { get; set; }
        public double PayLoadCapacityKg { get; set; }
    }
}