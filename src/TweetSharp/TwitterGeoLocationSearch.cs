namespace TweetSharp
{
    /// <summary>
    ///     Used for Twitter searches where it takes a geocode paramater
    /// </summary>
    public class TwitterGeoLocationSearch : TwitterGeoLocation
    {
        public enum RadiusType
        {
            Mi,
            Km
        }

        public TwitterGeoLocationSearch()
        {
        }

        public TwitterGeoLocationSearch(double latitutde, double longitude, int radius, RadiusType unitOfMeasurement)
            : base(latitutde, longitude)
        {
            Radius = radius;
            UnitOfMeasurement = unitOfMeasurement;
        }

        /// <summary>
        ///     Radius in specified <see cref="RadiusType" />
        /// </summary>
        /// <seealso cref="" />
        public int Radius { get; set; }

        public RadiusType UnitOfMeasurement { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}{3}", Coordinates.Latitude, Coordinates.Longitude, Radius,
                                 UnitOfMeasurement.ToString().ToLower());
        }
    }
}