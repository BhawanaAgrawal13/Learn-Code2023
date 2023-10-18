namespace LocationProximityFinder
{
    public class LocationClusterCalculator
    {
        public LocationClusterCalculator(List<Location> locations)
        {
            double latitudeRadius = 1113.2; // Specify the latitude radius in km

            List<List<Location>> clusters = CreateClusters(locations, latitudeRadius);

            DisplayResult(clusters);
        }

        public void DisplayResult(List<List<Location>> clusters)
        {
            int clusterNumber = 1;
            foreach (List<Location> cluster in clusters)
            {
                Console.WriteLine($"\nCluster {clusterNumber}:");
                foreach (Location location in cluster)
                {
                    Console.WriteLine($"{location.Name} - Latitude: {location.Latitude}, Longitude: {location.Longitude}");
                }
                clusterNumber++;
            }
        }
        private double CalculateHaversineDistance(double latitudeOne, double longitudeOne,
                        double latitudeTwo, double longitudeTwo)
        {
            double latitudeDifference = ToRadians(latitudeTwo - latitudeOne);
            double longitudeDifference = ToRadians(longitudeTwo - longitudeOne);

            latitudeOne = ToRadians(latitudeOne);
            latitudeTwo = ToRadians(latitudeTwo);

            double centralAngle = Math.Pow(Math.Sin(latitudeDifference / 2), 2) +
                    Math.Pow(Math.Sin(longitudeDifference / 2), 2) *
                    Math.Cos(latitudeOne) * Math.Cos(latitudeTwo);

            double earthRadius = 6371;
            
            double distance = 2 * Math.Asin(Math.Sqrt(centralAngle));
            
            return earthRadius * distance;
        }

        private double ToRadians(double value)
        {
            return (Math.PI / 180) * value;
        }

        public List<List<Location>> CreateClusters(List<Location> locations, double latitudeRadius)
        {
            List<List<Location>> clusters = new List<List<Location>>();

            foreach (Location location in locations)
            {
                if (location.IsClustered)
                {
                    continue;
                }

                List<Location> cluster = new List<Location>();
                location.IsClustered = true;

                foreach(var otherLocation in locations)
                {
                    var distance = CalculateHaversineDistance(location.Latitude, location.Longitude, otherLocation.Latitude, otherLocation.Longitude);
                    if(!otherLocation.IsClustered && distance <= latitudeRadius) {
                        cluster.Add(otherLocation);
                        otherLocation.IsClustered = true;
                    }
                }

                clusters.Add(cluster);
            }

            return clusters;
        }
    }
}
