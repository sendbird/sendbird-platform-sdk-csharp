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
    /// SendBirdPollUpdatedVoteCount
    /// </summary>
    [DataContract]
    public partial class SendBirdPollUpdatedVoteCount :  IEquatable<SendBirdPollUpdatedVoteCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdPollUpdatedVoteCount" /> class.
        /// </summary>
        /// <param name="optionId">optionId.</param>
        /// <param name="voteCount">voteCount.</param>
        public SendBirdPollUpdatedVoteCount(decimal optionId = default(decimal), decimal voteCount = default(decimal))
        {
            this.OptionId = optionId;
            this.VoteCount = voteCount;
        }

        /// <summary>
        /// Gets or Sets OptionId
        /// </summary>
        [DataMember(Name="option_id", EmitDefaultValue=false)]
        public decimal OptionId { get; set; }

        /// <summary>
        /// Gets or Sets VoteCount
        /// </summary>
        [DataMember(Name="vote_count", EmitDefaultValue=false)]
        public decimal VoteCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdPollUpdatedVoteCount {\n");
            sb.Append("  OptionId: ").Append(OptionId).Append("\n");
            sb.Append("  VoteCount: ").Append(VoteCount).Append("\n");
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
            return this.Equals(input as SendBirdPollUpdatedVoteCount);
        }

        /// <summary>
        /// Returns true if SendBirdPollUpdatedVoteCount instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdPollUpdatedVoteCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdPollUpdatedVoteCount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OptionId == input.OptionId ||
                    (this.OptionId != null &&
                    this.OptionId.Equals(input.OptionId))
                ) && 
                (
                    this.VoteCount == input.VoteCount ||
                    (this.VoteCount != null &&
                    this.VoteCount.Equals(input.VoteCount))
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
                if (this.OptionId != null)
                    hashCode = hashCode * 59 + this.OptionId.GetHashCode();
                if (this.VoteCount != null)
                    hashCode = hashCode * 59 + this.VoteCount.GetHashCode();
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
