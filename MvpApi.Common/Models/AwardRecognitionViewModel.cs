// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using System;
using Newtonsoft.Json;

namespace MvpApi.Common.Models
{
    public partial class AwardRecognitionViewModel
    {
        /// <summary>
        /// Initializes a new instance of the AwardRecognitionViewModel class.
        /// </summary>
        public AwardRecognitionViewModel() { }

        /// <summary>
        /// Initializes a new instance of the AwardRecognitionViewModel class.
        /// </summary>
        public AwardRecognitionViewModel(string title, DateTime dateEarned, int? privateSiteId = default(int?), string description = default(string), string referenceUrl = default(string), VisibilityViewModel awardRecognitionVisibility = default(VisibilityViewModel))
        {
            PrivateSiteId = privateSiteId;
            Title = title;
            Description = description;
            DateEarned = dateEarned;
            ReferenceUrl = referenceUrl;
            AwardRecognitionVisibility = awardRecognitionVisibility;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrivateSiteId")]
        public int? PrivateSiteId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateEarned")]
        public DateTime DateEarned { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceUrl")]
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AwardRecognitionVisibility")]
        public VisibilityViewModel AwardRecognitionVisibility { get; set; }
    }
}
