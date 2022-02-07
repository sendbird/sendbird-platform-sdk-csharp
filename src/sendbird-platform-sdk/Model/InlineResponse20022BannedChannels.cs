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
    /// InlineResponse20022BannedChannels
    /// </summary>
    [DataContract]
    public partial class InlineResponse20022BannedChannels :  IEquatable<InlineResponse20022BannedChannels>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20022BannedChannels" /> class.
        /// </summary>
        /// <param name="startAt">startAt.</param>
        /// <param name="endAt">endAt.</param>
        /// <param name="description">description.</param>
        /// <param name="channel">channel.</param>
        public InlineResponse20022BannedChannels(decimal startAt = default(decimal), decimal endAt = default(decimal), string description = default(string), SendBirdChannelResponse channel = default(SendBirdChannelResponse))
        {
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.Description = description;
            this.Channel = channel;
        }

        /// <summary>
        /// Gets or Sets StartAt
        /// </summary>
        [DataMember(Name="start_at", EmitDefaultValue=false)]
        public decimal StartAt { get; set; }

        /// <summary>
        /// Gets or Sets EndAt
        /// </summary>
        [DataMember(Name="end_at", EmitDefaultValue=false)]
        public decimal EndAt { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public SendBirdChannelResponse Channel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20022BannedChannels {\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
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
            return this.Equals(input as InlineResponse20022BannedChannels);
        }

        /// <summary>
        /// Returns true if InlineResponse20022BannedChannels instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20022BannedChannels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20022BannedChannels input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartAt == input.StartAt ||
                    (this.StartAt != null &&
                    this.StartAt.Equals(input.StartAt))
                ) && 
                (
                    this.EndAt == input.EndAt ||
                    (this.EndAt != null &&
                    this.EndAt.Equals(input.EndAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
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
                if (this.StartAt != null)
                    hashCode = hashCode * 59 + this.StartAt.GetHashCode();
                if (this.EndAt != null)
                    hashCode = hashCode * 59 + this.EndAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
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