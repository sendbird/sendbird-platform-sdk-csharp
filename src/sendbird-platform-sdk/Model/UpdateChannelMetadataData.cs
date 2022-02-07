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
    /// UpdateChannelMetadataData
    /// </summary>
    [DataContract]
    public partial class UpdateChannelMetadataData :  IEquatable<UpdateChannelMetadataData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelMetadataData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateChannelMetadataData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelMetadataData" /> class.
        /// </summary>
        /// <param name="metadata">Specifies a &#x60;JSON&#x60; object which has key-value items to update. A key can&#39;t contain a comma (,) and its length is limited to 128 characters. A value must be a string and its length is limited to 190 characters. This property can have up to 5 items. (required).</param>
        /// <param name="upsert">upsert (required).</param>
        public UpdateChannelMetadataData(string metadata = default(string), bool upsert = default(bool))
        {
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for UpdateChannelMetadataData and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }

            // to ensure "upsert" is required (not null)
            if (upsert == null)
            {
                throw new InvalidDataException("upsert is a required property for UpdateChannelMetadataData and cannot be null");
            }
            else
            {
                this.Upsert = upsert;
            }

        }

        /// <summary>
        /// Specifies a &#x60;JSON&#x60; object which has key-value items to update. A key can&#39;t contain a comma (,) and its length is limited to 128 characters. A value must be a string and its length is limited to 190 characters. This property can have up to 5 items.
        /// </summary>
        /// <value>Specifies a &#x60;JSON&#x60; object which has key-value items to update. A key can&#39;t contain a comma (,) and its length is limited to 128 characters. A value must be a string and its length is limited to 190 characters. This property can have up to 5 items.</value>
        [DataMember(Name="metadata", EmitDefaultValue=true)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Upsert
        /// </summary>
        [DataMember(Name="upsert", EmitDefaultValue=true)]
        public bool Upsert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateChannelMetadataData {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Upsert: ").Append(Upsert).Append("\n");
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
            return this.Equals(input as UpdateChannelMetadataData);
        }

        /// <summary>
        /// Returns true if UpdateChannelMetadataData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateChannelMetadataData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateChannelMetadataData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Upsert == input.Upsert ||
                    (this.Upsert != null &&
                    this.Upsert.Equals(input.Upsert))
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Upsert != null)
                    hashCode = hashCode * 59 + this.Upsert.GetHashCode();
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
