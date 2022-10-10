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
    /// CreateChannelMetadataData
    /// </summary>
    [DataContract]
    public partial class CreateChannelMetadataData :  IEquatable<CreateChannelMetadataData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelMetadataData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateChannelMetadataData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelMetadataData" /> class.
        /// </summary>
        /// <param name="channelType">Specifies the type of the channel. Either open_channels or group_channels. (required).</param>
        /// <param name="channelUrl">Specifies the URL of the channel to store the metadata in. (required).</param>
        /// <param name="metadata">Specifies a &#x60;JSON&#x60; object that stores key-value items. The key must not have a comma (,) and its length is limited to 128 characters. The value must be a string and its length is limited to 190 characters. This property can have up to 5 items. (required).</param>
        /// <param name="includeTs">Determines whether to include the timestamp of when a metadata has been created in the response. (Default: false).</param>
        public CreateChannelMetadataData(string channelType = default(string), string channelUrl = default(string), Object metadata = default(Object), bool includeTs = default(bool))
        {
            // to ensure "channelType" is required (not null)
            if (channelType == null)
            {
                throw new InvalidDataException("channelType is a required property for CreateChannelMetadataData and cannot be null");
            }
            else
            {
                this.ChannelType = channelType;
            }

            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for CreateChannelMetadataData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for CreateChannelMetadataData and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }

            this.IncludeTs = includeTs;
        }

        /// <summary>
        /// Specifies the type of the channel. Either open_channels or group_channels.
        /// </summary>
        /// <value>Specifies the type of the channel. Either open_channels or group_channels.</value>
        [DataMember(Name="channel_type", EmitDefaultValue=true)]
        public string ChannelType { get; set; }

        /// <summary>
        /// Specifies the URL of the channel to store the metadata in.
        /// </summary>
        /// <value>Specifies the URL of the channel to store the metadata in.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies a &#x60;JSON&#x60; object that stores key-value items. The key must not have a comma (,) and its length is limited to 128 characters. The value must be a string and its length is limited to 190 characters. This property can have up to 5 items.
        /// </summary>
        /// <value>Specifies a &#x60;JSON&#x60; object that stores key-value items. The key must not have a comma (,) and its length is limited to 128 characters. The value must be a string and its length is limited to 190 characters. This property can have up to 5 items.</value>
        [DataMember(Name="metadata", EmitDefaultValue=true)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Determines whether to include the timestamp of when a metadata has been created in the response. (Default: false)
        /// </summary>
        /// <value>Determines whether to include the timestamp of when a metadata has been created in the response. (Default: false)</value>
        [DataMember(Name="include_ts", EmitDefaultValue=false)]
        public bool IncludeTs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChannelMetadataData {\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  IncludeTs: ").Append(IncludeTs).Append("\n");
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
            return this.Equals(input as CreateChannelMetadataData);
        }

        /// <summary>
        /// Returns true if CreateChannelMetadataData instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateChannelMetadataData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateChannelMetadataData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelType == input.ChannelType ||
                    (this.ChannelType != null &&
                    this.ChannelType.Equals(input.ChannelType))
                ) && 
                (
                    this.ChannelUrl == input.ChannelUrl ||
                    (this.ChannelUrl != null &&
                    this.ChannelUrl.Equals(input.ChannelUrl))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.IncludeTs == input.IncludeTs ||
                    (this.IncludeTs != null &&
                    this.IncludeTs.Equals(input.IncludeTs))
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
                if (this.ChannelType != null)
                    hashCode = hashCode * 59 + this.ChannelType.GetHashCode();
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.IncludeTs != null)
                    hashCode = hashCode * 59 + this.IncludeTs.GetHashCode();
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
