namespace UavRouteUI.Models
{
    public class WayPoint
    {
        
        public int WaypointId { get; set; }
        public int RouteId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double AltitudeMeters { get; set; }

    }
}