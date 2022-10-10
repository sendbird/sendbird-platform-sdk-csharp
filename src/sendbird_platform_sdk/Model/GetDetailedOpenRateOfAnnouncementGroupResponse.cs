/*
 * Sendbird Platform SDK
 *
 * Sendbird Platform API SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@sendbird.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = sendbird_platform_sdk.Client.OpenAPIDateConverter;

namespace sendbird_platform_sdk.Model
{
    /// <summary>
    /// GetDetailedOpenRateOfAnnouncementGroupResponse
    /// </summary>
    [DataContract]
    public partial class GetDetailedOpenRateOfAnnouncementGroupResponse :  IEquatable<GetDetailedOpenRateOfAnnouncementGroupResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDetailedOpenRateOfAnnouncementGroupResponse" /> class.
        /// </summary>
        /// <param name="uniqueId">uniqueId.</param>
        /// <param name="announcementGroup">announcementGroup.</param>
        /// <param name="openCounts">openCounts.</param>
        /// <param name="openRates">openRates.</param>
        /// <param name="cumulativeOpenCounts">cumulativeOpenCounts.</param>
        /// <param name="cumulativeOpenRates">cumulativeOpenRates.</param>
        public GetDetailedOpenRateOfAnnouncementGroupResponse(string uniqueId = default(string), string announcementGroup = default(string), List<decimal> openCounts = default(List<decimal>), List<decimal> openRates = default(List<decimal>), List<decimal> cumulativeOpenCounts = default(List<decimal>), List<decimal> cumulativeOpenRates = default(List<decimal>))
        {
            this.UniqueId = uniqueId;
            this.AnnouncementGroup = announcementGroup;
            this.OpenCounts = openCounts;
            this.OpenRates = openRates;
            this.CumulativeOpenCounts = cumulativeOpenCounts;
            this.CumulativeOpenRates = cumulativeOpenRates;
        }

        /// <summary>
        /// Gets or Sets UniqueId
        /// </summary>
        [DataMember(Name="unique_id", EmitDefaultValue=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets or Sets AnnouncementGroup
        /// </summary>
        [DataMember(Name="announcement_group", EmitDefaultValue=false)]
        public string AnnouncementGroup { get; set; }

        /// <summary>
        /// Gets or Sets OpenCounts
        /// </summary>
        [DataMember(Name="open_counts", EmitDefaultValue=false)]
        public List<decimal> OpenCounts { get; set; }

        /// <summary>
        /// Gets or Sets OpenRates
        /// </summary>
        [DataMember(Name="open_rates", EmitDefaultValue=false)]
        public List<decimal> OpenRates { get; set; }

        /// <summary>
        /// Gets or Sets CumulativeOpenCounts
        /// </summary>
        [DataMember(Name="cumulative_open_counts", EmitDefaultValue=false)]
        public List<decimal> CumulativeOpenCounts { get; set; }

        /// <summary>
        /// Gets or Sets CumulativeOpenRates
        /// </summary>
        [DataMember(Name="cumulative_open_rates", EmitDefaultValue=false)]
        public List<decimal> CumulativeOpenRates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDetailedOpenRateOfAnnouncementGroupResponse {\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  AnnouncementGroup: ").Append(AnnouncementGroup).Append("\n");
            sb.Append("  OpenCounts: ").Append(OpenCounts).Append("\n");
            sb.Append("  OpenRates: ").Append(OpenRates).Append("\n");
            sb.Append("  CumulativeOpenCounts: ").Append(CumulativeOpenCounts).Append("\n");
            sb.Append("  CumulativeOpenRates: ").Append(CumulativeOpenRates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetDetailedOpenRateOfAnnouncementGroupResponse);
        }

        /// <summary>
        /// Returns true if GetDetailedOpenRateOfAnnouncementGroupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDetailedOpenRateOfAnnouncementGroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDetailedOpenRateOfAnnouncementGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
                ) && 
                (
                    this.AnnouncementGroup == input.AnnouncementGroup ||
                    (this.AnnouncementGroup != null &&
                    this.AnnouncementGroup.Equals(input.AnnouncementGroup))
                ) && 
                (
                    this.OpenCounts == input.OpenCounts ||
                    this.OpenCounts != null &&
                    input.OpenCounts != null &&
                    this.OpenCounts.SequenceEqual(input.OpenCounts)
                ) && 
                (
                    this.OpenRates == input.OpenRates ||
                    this.OpenRates != null &&
                    input.OpenRates != null &&
                    this.OpenRates.SequenceEqual(input.OpenRates)
                ) && 
                (
                    this.CumulativeOpenCounts == input.CumulativeOpenCounts ||
                    this.CumulativeOpenCounts != null &&
                    input.CumulativeOpenCounts != null &&
                    this.CumulativeOpenCounts.SequenceEqual(input.CumulativeOpenCounts)
                ) && 
                (
                    this.CumulativeOpenRates == input.CumulativeOpenRates ||
                    this.CumulativeOpenRates != null &&
                    input.CumulativeOpenRates != null &&
                    this.CumulativeOpenRates.SequenceEqual(input.CumulativeOpenRates)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.AnnouncementGroup != null)
                    hashCode = hashCode * 59 + this.AnnouncementGroup.GetHashCode();
                if (this.OpenCounts != null)
                    hashCode = hashCode * 59 + this.OpenCounts.GetHashCode();
                if (this.OpenRates != null)
                    hashCode = hashCode * 59 + this.OpenRates.GetHashCode();
                if (this.CumulativeOpenCounts != null)
                    hashCode = hashCode * 59 + this.CumulativeOpenCounts.GetHashCode();
                if (this.CumulativeOpenRates != null)
                    hashCode = hashCode * 59 + this.CumulativeOpenRates.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
