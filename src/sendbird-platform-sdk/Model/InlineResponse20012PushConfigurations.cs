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
    /// InlineResponse20012PushConfigurations
    /// </summary>
    [DataContract]
    public partial class InlineResponse20012PushConfigurations :  IEquatable<InlineResponse20012PushConfigurations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20012PushConfigurations" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="pushType">pushType.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="apiKey">apiKey.</param>
        /// <param name="senderId">senderId.</param>
        /// <param name="pushSound">pushSound.</param>
        public InlineResponse20012PushConfigurations(string id = default(string), string pushType = default(string), decimal createdAt = default(decimal), string apiKey = default(string), string senderId = default(string), string pushSound = default(string))
        {
            this.Id = id;
            this.PushType = pushType;
            this.CreatedAt = createdAt;
            this.ApiKey = apiKey;
            this.SenderId = senderId;
            this.PushSound = pushSound;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PushType
        /// </summary>
        [DataMember(Name="push_type", EmitDefaultValue=false)]
        public string PushType { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets SenderId
        /// </summary>
        [DataMember(Name="sender_id", EmitDefaultValue=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// Gets or Sets PushSound
        /// </summary>
        [DataMember(Name="push_sound", EmitDefaultValue=false)]
        public string PushSound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20012PushConfigurations {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PushType: ").Append(PushType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  PushSound: ").Append(PushSound).Append("\n");
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
            return this.Equals(input as InlineResponse20012PushConfigurations);
        }

        /// <summary>
        /// Returns true if InlineResponse20012PushConfigurations instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20012PushConfigurations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20012PushConfigurations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PushType == input.PushType ||
                    (this.PushType != null &&
                    this.PushType.Equals(input.PushType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.PushSound == input.PushSound ||
                    (this.PushSound != null &&
                    this.PushSound.Equals(input.PushSound))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PushType != null)
                    hashCode = hashCode * 59 + this.PushType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.PushSound != null)
                    hashCode = hashCode * 59 + this.PushSound.GetHashCode();
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
