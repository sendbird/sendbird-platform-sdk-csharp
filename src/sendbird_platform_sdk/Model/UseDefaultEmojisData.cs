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
    /// UseDefaultEmojisData
    /// </summary>
    [DataContract]
    public partial class UseDefaultEmojisData :  IEquatable<UseDefaultEmojisData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UseDefaultEmojisData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UseDefaultEmojisData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UseDefaultEmojisData" /> class.
        /// </summary>
        /// <param name="useDefaultEmoji">Determines whether to use the 7 default emojis initially provided. (required).</param>
        public UseDefaultEmojisData(bool useDefaultEmoji = default(bool))
        {
            // to ensure "useDefaultEmoji" is required (not null)
            if (useDefaultEmoji == null)
            {
                throw new InvalidDataException("useDefaultEmoji is a required property for UseDefaultEmojisData and cannot be null");
            }
            else
            {
                this.UseDefaultEmoji = useDefaultEmoji;
            }

        }

        /// <summary>
        /// Determines whether to use the 7 default emojis initially provided.
        /// </summary>
        /// <value>Determines whether to use the 7 default emojis initially provided.</value>
        [DataMember(Name="use_default_emoji", EmitDefaultValue=true)]
        public bool UseDefaultEmoji { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UseDefaultEmojisData {\n");
            sb.Append("  UseDefaultEmoji: ").Append(UseDefaultEmoji).Append("\n");
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
            return this.Equals(input as UseDefaultEmojisData);
        }

        /// <summary>
        /// Returns true if UseDefaultEmojisData instances are equal
        /// </summary>
        /// <param name="input">Instance of UseDefaultEmojisData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UseDefaultEmojisData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UseDefaultEmoji == input.UseDefaultEmoji ||
                    (this.UseDefaultEmoji != null &&
                    this.UseDefaultEmoji.Equals(input.UseDefaultEmoji))
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
                if (this.UseDefaultEmoji != null)
                    hashCode = hashCode * 59 + this.UseDefaultEmoji.GetHashCode();
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
