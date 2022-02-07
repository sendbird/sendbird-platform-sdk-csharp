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
    /// InlineResponse20039Message
    /// </summary>
    [DataContract]
    public partial class InlineResponse20039Message :  IEquatable<InlineResponse20039Message>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20039Message" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="customType">customType.</param>
        /// <param name="userId">userId.</param>
        /// <param name="content">content.</param>
        /// <param name="data">data.</param>
        public InlineResponse20039Message(string type = default(string), string customType = default(string), string userId = default(string), string content = default(string), string data = default(string))
        {
            this.Type = type;
            this.CustomType = customType;
            this.UserId = userId;
            this.Content = content;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets CustomType
        /// </summary>
        [DataMember(Name="custom_type", EmitDefaultValue=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20039Message {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CustomType: ").Append(CustomType).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as InlineResponse20039Message);
        }

        /// <summary>
        /// Returns true if InlineResponse20039Message instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20039Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20039Message input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CustomType == input.CustomType ||
                    (this.CustomType != null &&
                    this.CustomType.Equals(input.CustomType))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CustomType != null)
                    hashCode = hashCode * 59 + this.CustomType.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
