// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using System;
using Newtonsoft.Json;

namespace MvpApi.Common.Models
{
    public partial class SocialNetworkViewModel
    {
        /// <summary>
        /// Initializes a new instance of the SocialNetworkViewModel class.
        /// </summary>
        public SocialNetworkViewModel() { }

        /// <summary>
        /// Initializes a new instance of the SocialNetworkViewModel class.
        /// </summary>
        public SocialNetworkViewModel(Guid id, string name = default(string), string iconUrl = default(string), bool? systemCollectionEnabled = default(bool?))
        {
            Id = id;
            Name = name;
            IconUrl = iconUrl;
            SystemCollectionEnabled = systemCollectionEnabled;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public Guid Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconUrl")]
        public string IconUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SystemCollectionEnabled")]
        public bool? SystemCollectionEnabled { get; set; }
    }
}
