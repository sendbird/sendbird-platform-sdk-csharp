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
    /// BanUsersInChannelsWithCustomChannelTypeData
    /// </summary>
    [DataContract]
    public partial class BanUsersInChannelsWithCustomChannelTypeData :  IEquatable<BanUsersInChannelsWithCustomChannelTypeData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BanUsersInChannelsWithCustomChannelTypeData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BanUsersInChannelsWithCustomChannelTypeData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BanUsersInChannelsWithCustomChannelTypeData" /> class.
        /// </summary>
        /// <param name="bannedList">bannedList (required).</param>
        /// <param name="onDemandUpsert">onDemandUpsert.</param>
        public BanUsersInChannelsWithCustomChannelTypeData(List<BanUsersInChannelsWithCustomChannelTypeDataBannedListInner> bannedList = default(List<BanUsersInChannelsWithCustomChannelTypeDataBannedListInner>), bool onDemandUpsert = default(bool))
        {
            // to ensure "bannedList" is required (not null)
            if (bannedList == null)
            {
                throw new InvalidDataException("bannedList is a required property for BanUsersInChannelsWithCustomChannelTypeData and cannot be null");
            }
            else
            {
                this.BannedList = bannedList;
            }

            this.OnDemandUpsert = onDemandUpsert;
        }

        /// <summary>
        /// Gets or Sets BannedList
        /// </summary>
        [DataMember(Name="banned_list", EmitDefaultValue=true)]
        public List<BanUsersInChannelsWithCustomChannelTypeDataBannedListInner> BannedList { get; set; }

        /// <summary>
        /// Gets or Sets OnDemandUpsert
        /// </summary>
        [DataMember(Name="on_demand_upsert", EmitDefaultValue=false)]
        public bool OnDemandUpsert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BanUsersInChannelsWithCustomChannelTypeData {\n");
            sb.Append("  BannedList: ").Append(BannedList).Append("\n");
            sb.Append("  OnDemandUpsert: ").Append(OnDemandUpsert).Append("\n");
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
            return this.Equals(input as BanUsersInChannelsWithCustomChannelTypeData);
        }

        /// <summary>
        /// Returns true if BanUsersInChannelsWithCustomChannelTypeData instances are equal
        /// </summary>
        /// <param name="input">Instance of BanUsersInChannelsWithCustomChannelTypeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BanUsersInChannelsWithCustomChannelTypeData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BannedList == input.BannedList ||
                    this.BannedList != null &&
                    input.BannedList != null &&
                    this.BannedList.SequenceEqual(input.BannedList)
                ) && 
                (
                    this.OnDemandUpsert == input.OnDemandUpsert ||
                    (this.OnDemandUpsert != null &&
                    this.OnDemandUpsert.Equals(input.OnDemandUpsert))
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
                if (this.BannedList != null)
                    hashCode = hashCode * 59 + this.BannedList.GetHashCode();
                if (this.OnDemandUpsert != null)
                    hashCode = hashCode * 59 + this.OnDemandUpsert.GetHashCode();
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
