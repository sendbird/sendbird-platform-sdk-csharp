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
    /// GcBanUserData
    /// </summary>
    [DataContract]
    public partial class GcBanUserData :  IEquatable<GcBanUserData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcBanUserData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GcBanUserData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcBanUserData" /> class.
        /// </summary>
        /// <param name="channelUrl">Specifies the URL of the channel where to ban a user. (required).</param>
        /// <param name="userId">Specifies the unique ID of the user to ban. (required).</param>
        /// <param name="agentId">Specifies the ID of the agent (operator) who bans the user. (required).</param>
        /// <param name="seconds">Specifies the ban duration. If set to -1, the user will be banned permanently (10 years, technically). (Default: -1) (required).</param>
        /// <param name="description">Specifies a reason for the banning. The length is limited to 250 characters. (required).</param>
        public GcBanUserData(string channelUrl = default(string), string userId = default(string), string agentId = default(string), int seconds = default(int), string description = default(string))
        {
            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for GcBanUserData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for GcBanUserData and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            // to ensure "agentId" is required (not null)
            if (agentId == null)
            {
                throw new InvalidDataException("agentId is a required property for GcBanUserData and cannot be null");
            }
            else
            {
                this.AgentId = agentId;
            }

            // to ensure "seconds" is required (not null)
            if (seconds == null)
            {
                throw new InvalidDataException("seconds is a required property for GcBanUserData and cannot be null");
            }
            else
            {
                this.Seconds = seconds;
            }

            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for GcBanUserData and cannot be null");
            }
            else
            {
                this.Description = description;
            }

        }

        /// <summary>
        /// Specifies the URL of the channel where to ban a user.
        /// </summary>
        /// <value>Specifies the URL of the channel where to ban a user.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies the unique ID of the user to ban.
        /// </summary>
        /// <value>Specifies the unique ID of the user to ban.</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Specifies the ID of the agent (operator) who bans the user.
        /// </summary>
        /// <value>Specifies the ID of the agent (operator) who bans the user.</value>
        [DataMember(Name="agent_id", EmitDefaultValue=true)]
        public string AgentId { get; set; }

        /// <summary>
        /// Specifies the ban duration. If set to -1, the user will be banned permanently (10 years, technically). (Default: -1)
        /// </summary>
        /// <value>Specifies the ban duration. If set to -1, the user will be banned permanently (10 years, technically). (Default: -1)</value>
        [DataMember(Name="seconds", EmitDefaultValue=true)]
        public int Seconds { get; set; }

        /// <summary>
        /// Specifies a reason for the banning. The length is limited to 250 characters.
        /// </summary>
        /// <value>Specifies a reason for the banning. The length is limited to 250 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcBanUserData {\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as GcBanUserData);
        }

        /// <summary>
        /// Returns true if GcBanUserData instances are equal
        /// </summary>
        /// <param name="input">Instance of GcBanUserData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcBanUserData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelUrl == input.ChannelUrl ||
                    (this.ChannelUrl != null &&
                    this.ChannelUrl.Equals(input.ChannelUrl))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.Seconds == input.Seconds ||
                    (this.Seconds != null &&
                    this.Seconds.Equals(input.Seconds))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.Seconds != null)
                    hashCode = hashCode * 59 + this.Seconds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
