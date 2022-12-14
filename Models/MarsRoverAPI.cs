// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using NASA_Demo.Models;
//
//    var nasaPhotos = NasaPhotos.FromJson(jsonString);

namespace NASA_Demo.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NasaPhotos
    {
        [JsonProperty("photos")]
        public List<Photo> Photos { get; set; }
    }

    public partial class Photo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("sol")]
        public long Sol { get; set; }

        [JsonProperty("camera")]
        public Camera Camera { get; set; }

        [JsonProperty("img_src")]
        public string ImgSrc { get; set; }

        [JsonProperty("earth_date")]
        public DateTimeOffset EarthDate { get; set; }

        [JsonProperty("rover")]
        public Rover Rover { get; set; }
    }

    public partial class Camera
    {
        [JsonProperty("id")]
        
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rover_id")]
        public long RoverId { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    public partial class Rover
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("landing_date")]
        public DateTimeOffset LandingDate { get; set; }

        [JsonProperty("launch_date")]
        public DateTimeOffset LaunchDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class NasaPhotos
    {
        public static NasaPhotos FromJson(string json) => JsonConvert.DeserializeObject<NasaPhotos>(json, NASA_Demo.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this NasaPhotos self) => JsonConvert.SerializeObject(self, NASA_Demo.Models.Converter.Settings);
    }
     
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
