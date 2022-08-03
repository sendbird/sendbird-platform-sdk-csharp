/*
 * Sendbird Platform SDK
 *
 * Sendbird Platform API Javascript SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
    /// GetStatisticsDailyResponse
    /// </summary>
    [DataContract]
    public partial class GetStatisticsDailyResponse :  IEquatable<GetStatisticsDailyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticsDailyResponse" /> class.
        /// </summary>
        /// <param name="statistics">statistics.</param>
        /// <param name="week">week.</param>
        public GetStatisticsDailyResponse(List<GetStatisticsDailyResponseStatisticsInner> statistics = default(List<GetStatisticsDailyResponseStatisticsInner>), decimal week = default(decimal))
        {
            this.Statistics = statistics;
            this.Week = week;
        }

        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public List<GetStatisticsDailyResponseStatisticsInner> Statistics { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public decimal Week { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetStatisticsDailyResponse {\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
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
            return this.Equals(input as GetStatisticsDailyResponse);
        }

        /// <summary>
        /// Returns true if GetStatisticsDailyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStatisticsDailyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatisticsDailyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Statistics == input.Statistics ||
                    this.Statistics != null &&
                    input.Statistics != null &&
                    this.Statistics.SequenceEqual(input.Statistics)
                ) && 
                (
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
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
                if (this.Statistics != null)
                    hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
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
