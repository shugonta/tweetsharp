using System;
using Newtonsoft.Json;

namespace TweetSharp
{
    // [DC]: All converters must be public for Silverlight to construct them correctly.

    /// <summary>
    /// A converter for parsing multiple Twitter API date formats.
    /// </summary>
    public class TwitterDateTimeConverter : TwitterConverterBase
    {
        /// <summary>
        /// Writes the JSON.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (value is TwitterDateTime)
            {
                writer.WriteValue(value.ToString());
            }

            if (value is DateTime)
            {
                var dateTime = (DateTime) value;
                var converted = TwitterDateTime.ConvertFromDateTime(dateTime, TwitterDateFormat.RestApi);

                writer.WriteValue(converted);
            }
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

            var value = reader.Value.ToString();
            var date = TwitterDateTime.ConvertToDateTime(value);

            return date;
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
#if !Smartphone && !NET20
            return typeof (DateTime).IsAssignableFrom(t) || typeof (DateTimeOffset).IsAssignableFrom(t);
#else
            return typeof (DateTime).IsAssignableFrom(t);
#endif
        }
    }
}