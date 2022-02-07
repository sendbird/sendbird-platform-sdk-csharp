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
    /// UpdateChannelInvitationPreferenceData
    /// </summary>
    [DataContract]
    public partial class UpdateChannelInvitationPreferenceData :  IEquatable<UpdateChannelInvitationPreferenceData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelInvitationPreferenceData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateChannelInvitationPreferenceData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelInvitationPreferenceData" /> class.
        /// </summary>
        /// <param name="autoAccept">Determines for the user whether or not to automatically join a [private](/docs/chat/v3/platform-api/guides/group-channel#-3-private-vs-public) group channel promptly from an invitation without having to accept it. (Default: true) (required).</param>
        public UpdateChannelInvitationPreferenceData(bool autoAccept = default(bool))
        {
            // to ensure "autoAccept" is required (not null)
            if (autoAccept == null)
            {
                throw new InvalidDataException("autoAccept is a required property for UpdateChannelInvitationPreferenceData and cannot be null");
            }
            else
            {
                this.AutoAccept = autoAccept;
            }

        }

        /// <summary>
        /// Determines for the user whether or not to automatically join a [private](/docs/chat/v3/platform-api/guides/group-channel#-3-private-vs-public) group channel promptly from an invitation without having to accept it. (Default: true)
        /// </summary>
        /// <value>Determines for the user whether or not to automatically join a [private](/docs/chat/v3/platform-api/guides/group-channel#-3-private-vs-public) group channel promptly from an invitation without having to accept it. (Default: true)</value>
        [DataMember(Name="auto_accept", EmitDefaultValue=true)]
        public bool AutoAccept { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateChannelInvitationPreferenceData {\n");
            sb.Append("  AutoAccept: ").Append(AutoAccept).Append("\n");
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
            return this.Equals(input as UpdateChannelInvitationPreferenceData);
        }

        /// <summary>
        /// Returns true if UpdateChannelInvitationPreferenceData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateChannelInvitationPreferenceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateChannelInvitationPreferenceData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoAccept == input.AutoAccept ||
                    (this.AutoAccept != null &&
                    this.AutoAccept.Equals(input.AutoAccept))
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
                if (this.AutoAccept != null)
                    hashCode = hashCode * 59 + this.AutoAccept.GetHashCode();
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
