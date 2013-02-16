using System;
using System.Globalization;
using Newtonsoft.Json;

namespace TweetSharp
{
    // [DC]: All converters must be public for Silverlight to construct them correctly.

    /// <summary>
    /// This converter exists to convert geo-spatial coordinates.
    /// </summary>
    internal class TwitterGeoConverter : TwitterConverterBase
    {
        private const string GeoTemplate = "\"geo\":{{\"type\":\"Point\",\"coordinates\":[{0}, {1}]}}";

        /// <summary>
        /// Writes the JSON.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (!(value is TwitterGeoLocation.GeoCoordinates))
            {
                return;
            }

            var location = (TwitterGeoLocation.GeoCoordinates)value;
            var latitude = location.Latitude.ToString(CultureInfo.InvariantCulture);
            var longitude = location.Longitude.ToString(CultureInfo.InvariantCulture);
            var json = string.Format(GeoTemplate, latitude, longitude);
            writer.WriteRawValue(json);
        }

        /// <summary>
        /// Reads the JSON.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value.</param>
        /// <param name="serializer">The serializer.</param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            if (reader.TokenType != JsonToken.StartArray)
            {
                return null;
            }
            reader.Read();
            var coords = new double[2];
            if (reader.TokenType == JsonToken.Float || reader.TokenType == JsonToken.Integer)
            {
                coords[0] = (double)reader.Value;
                reader.Read();
            }
            if (reader.TokenType == JsonToken.Float || reader.TokenType == JsonToken.Integer)
            {
                coords[1] = (double)reader.Value;
                reader.Read();
            }

            var latitude = coords[0];
            var longitude = coords[1];

            return new TwitterGeoLocation.GeoCoordinates { Latitude = latitude, Longitude = longitude };
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// 	<c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            var t = (IsNullableType(objectType))
                        ? Nullable.GetUnderlyingType(objectType)
                        : objectType;

            return typeof(TwitterGeoLocation.GeoCoordinates).IsAssignableFrom(t);
        }
    }
}
