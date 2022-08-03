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
    /// GcRegisterOperatorsData
    /// </summary>
    [DataContract]
    public partial class GcRegisterOperatorsData :  IEquatable<GcRegisterOperatorsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcRegisterOperatorsData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GcRegisterOperatorsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcRegisterOperatorsData" /> class.
        /// </summary>
        /// <param name="channelUrl">Specifies the URL of the channel to register operators to. (required).</param>
        /// <param name="operatorIds">Specifies an array of one or more IDs of users to register as operators of the channel. If the operators are not members of the channel yet, they need an [invitation](#2-invite-as-members) to [join](#2-join-a-channel) a privte group channel while they don&#39;t need any to join a [public](#-3-private-vs-public) group channel. The maximum allowed number of operators per channel is 100. (required).</param>
        public GcRegisterOperatorsData(string channelUrl = default(string), List<string> operatorIds = default(List<string>))
        {
            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for GcRegisterOperatorsData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "operatorIds" is required (not null)
            if (operatorIds == null)
            {
                throw new InvalidDataException("operatorIds is a required property for GcRegisterOperatorsData and cannot be null");
            }
            else
            {
                this.OperatorIds = operatorIds;
            }

        }

        /// <summary>
        /// Specifies the URL of the channel to register operators to.
        /// </summary>
        /// <value>Specifies the URL of the channel to register operators to.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies an array of one or more IDs of users to register as operators of the channel. If the operators are not members of the channel yet, they need an [invitation](#2-invite-as-members) to [join](#2-join-a-channel) a privte group channel while they don&#39;t need any to join a [public](#-3-private-vs-public) group channel. The maximum allowed number of operators per channel is 100.
        /// </summary>
        /// <value>Specifies an array of one or more IDs of users to register as operators of the channel. If the operators are not members of the channel yet, they need an [invitation](#2-invite-as-members) to [join](#2-join-a-channel) a privte group channel while they don&#39;t need any to join a [public](#-3-private-vs-public) group channel. The maximum allowed number of operators per channel is 100.</value>
        [DataMember(Name="operator_ids", EmitDefaultValue=true)]
        public List<string> OperatorIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcRegisterOperatorsData {\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  OperatorIds: ").Append(OperatorIds).Append("\n");
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
            return this.Equals(input as GcRegisterOperatorsData);
        }

        /// <summary>
        /// Returns true if GcRegisterOperatorsData instances are equal
        /// </summary>
        /// <param name="input">Instance of GcRegisterOperatorsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcRegisterOperatorsData input)
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
                    this.OperatorIds == input.OperatorIds ||
                    this.OperatorIds != null &&
                    input.OperatorIds != null &&
                    this.OperatorIds.SequenceEqual(input.OperatorIds)
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
                if (this.OperatorIds != null)
                    hashCode = hashCode * 59 + this.OperatorIds.GetHashCode();
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
