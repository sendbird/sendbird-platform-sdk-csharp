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
using OpenAPIDateConverter = sendbird_platform_sdk.Client.OpenAPIDateConverter;

namespace sendbird_platform_sdk.Model
{
    /// <summary>
    /// ListRegistrationOrDeviceTokensResponse
    /// </summary>
    [DataContract]
    public partial class ListRegistrationOrDeviceTokensResponse :  IEquatable<ListRegistrationOrDeviceTokensResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListRegistrationOrDeviceTokensResponse" /> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="tokens">tokens.</param>
        /// <param name="type">type.</param>
        /// <param name="user">user.</param>
        public ListRegistrationOrDeviceTokensResponse(List<string> token = default(List<string>), List<string> tokens = default(List<string>), string type = default(string), SendBirdUser user = default(SendBirdUser))
        {
            this.Token = token;
            this.Tokens = tokens;
            this.Type = type;
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public List<string> Token { get; set; }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name="tokens", EmitDefaultValue=false)]
        public List<string> Tokens { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SendBirdUser User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRegistrationOrDeviceTokensResponse {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as ListRegistrationOrDeviceTokensResponse);
        }

        /// <summary>
        /// Returns true if ListRegistrationOrDeviceTokensResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListRegistrationOrDeviceTokensResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListRegistrationOrDeviceTokensResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Token == input.Token ||
                    this.Token != null &&
                    input.Token != null &&
                    this.Token.SequenceEqual(input.Token)
                ) && 
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    input.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Tokens != null)
                    hashCode = hashCode * 59 + this.Tokens.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
