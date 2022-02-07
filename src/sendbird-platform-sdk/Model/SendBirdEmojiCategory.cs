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
    /// SendBirdEmojiCategory
    /// </summary>
    [DataContract]
    public partial class SendBirdEmojiCategory :  IEquatable<SendBirdEmojiCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdEmojiCategory" /> class.
        /// </summary>
        /// <param name="emojis">emojis.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        public SendBirdEmojiCategory(List<SendBirdEmoji> emojis = default(List<SendBirdEmoji>), decimal id = default(decimal), string name = default(string), string url = default(string))
        {
            this.Emojis = emojis;
            this.Id = id;
            this.Name = name;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Emojis
        /// </summary>
        [DataMember(Name="emojis", EmitDefaultValue=false)]
        public List<SendBirdEmoji> Emojis { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public decimal Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdEmojiCategory {\n");
            sb.Append("  Emojis: ").Append(Emojis).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as SendBirdEmojiCategory);
        }

        /// <summary>
        /// Returns true if SendBirdEmojiCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdEmojiCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdEmojiCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Emojis == input.Emojis ||
                    this.Emojis != null &&
                    input.Emojis != null &&
                    this.Emojis.SequenceEqual(input.Emojis)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Emojis != null)
                    hashCode = hashCode * 59 + this.Emojis.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
