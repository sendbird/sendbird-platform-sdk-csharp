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
    /// SendBirdGroupChannelDisappearingMessage
    /// </summary>
    [DataContract]
    public partial class SendBirdGroupChannelDisappearingMessage :  IEquatable<SendBirdGroupChannelDisappearingMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdGroupChannelDisappearingMessage" /> class.
        /// </summary>
        /// <param name="messageSurvivalSeconds">messageSurvivalSeconds.</param>
        /// <param name="isTriggeredByMessageRead">isTriggeredByMessageRead.</param>
        public SendBirdGroupChannelDisappearingMessage(decimal messageSurvivalSeconds = default(decimal), bool isTriggeredByMessageRead = default(bool))
        {
            this.MessageSurvivalSeconds = messageSurvivalSeconds;
            this.IsTriggeredByMessageRead = isTriggeredByMessageRead;
        }

        /// <summary>
        /// Gets or Sets MessageSurvivalSeconds
        /// </summary>
        [DataMember(Name="message_survival_seconds", EmitDefaultValue=false)]
        public decimal MessageSurvivalSeconds { get; set; }

        /// <summary>
        /// Gets or Sets IsTriggeredByMessageRead
        /// </summary>
        [DataMember(Name="is_triggered_by_message_read", EmitDefaultValue=false)]
        public bool IsTriggeredByMessageRead { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdGroupChannelDisappearingMessage {\n");
            sb.Append("  MessageSurvivalSeconds: ").Append(MessageSurvivalSeconds).Append("\n");
            sb.Append("  IsTriggeredByMessageRead: ").Append(IsTriggeredByMessageRead).Append("\n");
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
            return this.Equals(input as SendBirdGroupChannelDisappearingMessage);
        }

        /// <summary>
        /// Returns true if SendBirdGroupChannelDisappearingMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdGroupChannelDisappearingMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdGroupChannelDisappearingMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageSurvivalSeconds == input.MessageSurvivalSeconds ||
                    (this.MessageSurvivalSeconds != null &&
                    this.MessageSurvivalSeconds.Equals(input.MessageSurvivalSeconds))
                ) && 
                (
                    this.IsTriggeredByMessageRead == input.IsTriggeredByMessageRead ||
                    (this.IsTriggeredByMessageRead != null &&
                    this.IsTriggeredByMessageRead.Equals(input.IsTriggeredByMessageRead))
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
                if (this.MessageSurvivalSeconds != null)
                    hashCode = hashCode * 59 + this.MessageSurvivalSeconds.GetHashCode();
                if (this.IsTriggeredByMessageRead != null)
                    hashCode = hashCode * 59 + this.IsTriggeredByMessageRead.GetHashCode();
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
