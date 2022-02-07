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
using OpenAPIDateConverter = sendbird-platform-sdk.Client.OpenAPIDateConverter;

namespace sendbird-platform-sdk.Model
{
    /// <summary>
    /// MarkAllMessagesAsReadData
    /// </summary>
    [DataContract]
    public partial class MarkAllMessagesAsReadData :  IEquatable<MarkAllMessagesAsReadData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkAllMessagesAsReadData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarkAllMessagesAsReadData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkAllMessagesAsReadData" /> class.
        /// </summary>
        /// <param name="userId">Specifies the unique ID of the target user. (required).</param>
        /// <param name="channelUrls">Specifies an array of one or more group channel URLs to mark all of the unread messages in as read. If not specified, all of the unread messages in the joined group channels are marked as read. (required).</param>
        public MarkAllMessagesAsReadData(string userId = default(string), List<string> channelUrls = default(List<string>))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for MarkAllMessagesAsReadData and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            // to ensure "channelUrls" is required (not null)
            if (channelUrls == null)
            {
                throw new InvalidDataException("channelUrls is a required property for MarkAllMessagesAsReadData and cannot be null");
            }
            else
            {
                this.ChannelUrls = channelUrls;
            }

        }

        /// <summary>
        /// Specifies the unique ID of the target user.
        /// </summary>
        /// <value>Specifies the unique ID of the target user.</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Specifies an array of one or more group channel URLs to mark all of the unread messages in as read. If not specified, all of the unread messages in the joined group channels are marked as read.
        /// </summary>
        /// <value>Specifies an array of one or more group channel URLs to mark all of the unread messages in as read. If not specified, all of the unread messages in the joined group channels are marked as read.</value>
        [DataMember(Name="channel_urls", EmitDefaultValue=true)]
        public List<string> ChannelUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarkAllMessagesAsReadData {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ChannelUrls: ").Append(ChannelUrls).Append("\n");
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
            return this.Equals(input as MarkAllMessagesAsReadData);
        }

        /// <summary>
        /// Returns true if MarkAllMessagesAsReadData instances are equal
        /// </summary>
        /// <param name="input">Instance of MarkAllMessagesAsReadData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarkAllMessagesAsReadData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ChannelUrls == input.ChannelUrls ||
                    this.ChannelUrls != null &&
                    input.ChannelUrls != null &&
                    this.ChannelUrls.SequenceEqual(input.ChannelUrls)
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ChannelUrls != null)
                    hashCode = hashCode * 59 + this.ChannelUrls.GetHashCode();
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
