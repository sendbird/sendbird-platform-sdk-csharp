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
    /// OcFreezeChannelData
    /// </summary>
    [DataContract]
    public partial class OcFreezeChannelData :  IEquatable<OcFreezeChannelData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcFreezeChannelData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OcFreezeChannelData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OcFreezeChannelData" /> class.
        /// </summary>
        /// <param name="channelUrl">Specifies the URL of the channel to freeze. (required).</param>
        /// <param name="freeze">Determines whether to freeze the channel. (Default: false) (required).</param>
        public OcFreezeChannelData(string channelUrl = default(string), bool freeze = default(bool))
        {
            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for OcFreezeChannelData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "freeze" is required (not null)
            if (freeze == null)
            {
                throw new InvalidDataException("freeze is a required property for OcFreezeChannelData and cannot be null");
            }
            else
            {
                this.Freeze = freeze;
            }

        }

        /// <summary>
        /// Specifies the URL of the channel to freeze.
        /// </summary>
        /// <value>Specifies the URL of the channel to freeze.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Determines whether to freeze the channel. (Default: false)
        /// </summary>
        /// <value>Determines whether to freeze the channel. (Default: false)</value>
        [DataMember(Name="freeze", EmitDefaultValue=true)]
        public bool Freeze { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcFreezeChannelData {\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  Freeze: ").Append(Freeze).Append("\n");
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
            return this.Equals(input as OcFreezeChannelData);
        }

        /// <summary>
        /// Returns true if OcFreezeChannelData instances are equal
        /// </summary>
        /// <param name="input">Instance of OcFreezeChannelData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcFreezeChannelData input)
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
                    this.Freeze == input.Freeze ||
                    (this.Freeze != null &&
                    this.Freeze.Equals(input.Freeze))
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
                if (this.Freeze != null)
                    hashCode = hashCode * 59 + this.Freeze.GetHashCode();
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
