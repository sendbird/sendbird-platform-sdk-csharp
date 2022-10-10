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
    /// CreateUserTokenData
    /// </summary>
    [DataContract]
    public partial class CreateUserTokenData :  IEquatable<CreateUserTokenData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserTokenData" /> class.
        /// </summary>
        /// <param name="expiresAt">Specifies the expiration time of the new session token in Unix milliseconds format. By default, the expiration time of a session token is seven days from the timestamp when the token was issued..</param>
        public CreateUserTokenData(decimal expiresAt = default(decimal))
        {
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Specifies the expiration time of the new session token in Unix milliseconds format. By default, the expiration time of a session token is seven days from the timestamp when the token was issued.
        /// </summary>
        /// <value>Specifies the expiration time of the new session token in Unix milliseconds format. By default, the expiration time of a session token is seven days from the timestamp when the token was issued.</value>
        [DataMember(Name="expires_at", EmitDefaultValue=false)]
        public decimal ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserTokenData {\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
            return this.Equals(input as CreateUserTokenData);
        }

        /// <summary>
        /// Returns true if CreateUserTokenData instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserTokenData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserTokenData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
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
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
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