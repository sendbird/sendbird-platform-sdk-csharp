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
    /// SendBirdThreadInfo
    /// </summary>
    [DataContract]
    public partial class SendBirdThreadInfo :  IEquatable<SendBirdThreadInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdThreadInfo" /> class.
        /// </summary>
        /// <param name="lastRepliedAt">lastRepliedAt.</param>
        /// <param name="mostRepliedUsers">mostRepliedUsers.</param>
        /// <param name="replyCount">replyCount.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public SendBirdThreadInfo(decimal lastRepliedAt = default(decimal), List<SendBirdUser> mostRepliedUsers = default(List<SendBirdUser>), decimal replyCount = default(decimal), decimal updatedAt = default(decimal))
        {
            this.LastRepliedAt = lastRepliedAt;
            this.MostRepliedUsers = mostRepliedUsers;
            this.ReplyCount = replyCount;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets LastRepliedAt
        /// </summary>
        [DataMember(Name="last_replied_at", EmitDefaultValue=false)]
        public decimal LastRepliedAt { get; set; }

        /// <summary>
        /// Gets or Sets MostRepliedUsers
        /// </summary>
        [DataMember(Name="most_replied_users", EmitDefaultValue=false)]
        public List<SendBirdUser> MostRepliedUsers { get; set; }

        /// <summary>
        /// Gets or Sets ReplyCount
        /// </summary>
        [DataMember(Name="reply_count", EmitDefaultValue=false)]
        public decimal ReplyCount { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public decimal UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdThreadInfo {\n");
            sb.Append("  LastRepliedAt: ").Append(LastRepliedAt).Append("\n");
            sb.Append("  MostRepliedUsers: ").Append(MostRepliedUsers).Append("\n");
            sb.Append("  ReplyCount: ").Append(ReplyCount).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as SendBirdThreadInfo);
        }

        /// <summary>
        /// Returns true if SendBirdThreadInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdThreadInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdThreadInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastRepliedAt == input.LastRepliedAt ||
                    (this.LastRepliedAt != null &&
                    this.LastRepliedAt.Equals(input.LastRepliedAt))
                ) && 
                (
                    this.MostRepliedUsers == input.MostRepliedUsers ||
                    this.MostRepliedUsers != null &&
                    input.MostRepliedUsers != null &&
                    this.MostRepliedUsers.SequenceEqual(input.MostRepliedUsers)
                ) && 
                (
                    this.ReplyCount == input.ReplyCount ||
                    (this.ReplyCount != null &&
                    this.ReplyCount.Equals(input.ReplyCount))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.LastRepliedAt != null)
                    hashCode = hashCode * 59 + this.LastRepliedAt.GetHashCode();
                if (this.MostRepliedUsers != null)
                    hashCode = hashCode * 59 + this.MostRepliedUsers.GetHashCode();
                if (this.ReplyCount != null)
                    hashCode = hashCode * 59 + this.ReplyCount.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
