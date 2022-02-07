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
    /// GcResetChatHistoryData
    /// </summary>
    [DataContract]
    public partial class GcResetChatHistoryData :  IEquatable<GcResetChatHistoryData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcResetChatHistoryData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GcResetChatHistoryData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcResetChatHistoryData" /> class.
        /// </summary>
        /// <param name="channelUrl">Specifies the URL of the target channel to reset chat history. (required).</param>
        /// <param name="userId">Specifies the unique ID of the user whose chat history to reset in the channel. If this user_id property is specified, the reset_all property is not required. (required).</param>
        /// <param name="resetAll">Determines whether to reset all users&#39; chat history in the channel. If this reset_all property is specified, the user_id property is not required. (required).</param>
        public GcResetChatHistoryData(string channelUrl = default(string), string userId = default(string), bool resetAll = default(bool))
        {
            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for GcResetChatHistoryData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for GcResetChatHistoryData and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            // to ensure "resetAll" is required (not null)
            if (resetAll == null)
            {
                throw new InvalidDataException("resetAll is a required property for GcResetChatHistoryData and cannot be null");
            }
            else
            {
                this.ResetAll = resetAll;
            }

        }

        /// <summary>
        /// Specifies the URL of the target channel to reset chat history.
        /// </summary>
        /// <value>Specifies the URL of the target channel to reset chat history.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies the unique ID of the user whose chat history to reset in the channel. If this user_id property is specified, the reset_all property is not required.
        /// </summary>
        /// <value>Specifies the unique ID of the user whose chat history to reset in the channel. If this user_id property is specified, the reset_all property is not required.</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Determines whether to reset all users&#39; chat history in the channel. If this reset_all property is specified, the user_id property is not required.
        /// </summary>
        /// <value>Determines whether to reset all users&#39; chat history in the channel. If this reset_all property is specified, the user_id property is not required.</value>
        [DataMember(Name="reset_all", EmitDefaultValue=true)]
        public bool ResetAll { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcResetChatHistoryData {\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ResetAll: ").Append(ResetAll).Append("\n");
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
            return this.Equals(input as GcResetChatHistoryData);
        }

        /// <summary>
        /// Returns true if GcResetChatHistoryData instances are equal
        /// </summary>
        /// <param name="input">Instance of GcResetChatHistoryData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcResetChatHistoryData input)
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
                    this.ResetAll == input.ResetAll ||
                    (this.ResetAll != null &&
                    this.ResetAll.Equals(input.ResetAll))
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
                if (this.ResetAll != null)
                    hashCode = hashCode * 59 + this.ResetAll.GetHashCode();
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
