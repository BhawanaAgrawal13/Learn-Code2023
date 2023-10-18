namespace LocationProximityFinder
{
    public class Location
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsClustered { get; set; }

        public Location(string name, string latitude, string longitude)
        {
            Name = name;
            Latitude = ToDegreeDecimal(latitude);
            Longitude = ToDegreeDecimal(longitude);
        }

        private double ToDegreeDecimal(string latitudeString)
        {
            try
            {
                string[] parts = latitudeString.Split('°', '\'');

                if (parts.Length == 3)
                {
                    int degrees = int.Parse(parts[0]);
                    int minutes = int.Parse(parts[1]);

                    double decimalDegrees = Math.Round(degrees + (minutes / 60.0), 4);

                    if (latitudeString.Contains("S"))
                    {
                        decimalDegrees = -decimalDegrees;
                    }

                    return decimalDegrees;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting latitude string: {ex.Message}");
            }

            return double.NaN;
        }
    }
}
