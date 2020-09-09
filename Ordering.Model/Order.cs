using System;
using Newtonsoft.Json;


namespace Ordering.Model
{
    public class Order
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "restaurant")]
        public Restaurant Restaurant { get; set; }

        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }

    }
    public class Restaurant
    {
        [JsonProperty(PropertyName = "restaurantId")]
        public string RestaurantId { get; set; }

        [JsonProperty(PropertyName = "restaurantName")]
        public string RestaurantName { get; set; }

        [JsonProperty(PropertyName = "isDelivering")]
        public bool IsDelivering { get; set; }
    }
    public class User
    {
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "contactNumber")]
        public string ContactNumber { get; set; }
    }
}
