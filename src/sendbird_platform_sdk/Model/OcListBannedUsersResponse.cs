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
    /// OcListBannedUsersResponse
    /// </summary>
    [DataContract]
    public partial class OcListBannedUsersResponse :  IEquatable<OcListBannedUsersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcListBannedUsersResponse" /> class.
        /// </summary>
        /// <param name="bannedList">bannedList.</param>
        /// <param name="totalBanCount">totalBanCount.</param>
        /// <param name="next">next.</param>
        public OcListBannedUsersResponse(List<OcListBannedUsersResponseBannedListInner> bannedList = default(List<OcListBannedUsersResponseBannedListInner>), decimal totalBanCount = default(decimal), string next = default(string))
        {
            this.BannedList = bannedList;
            this.TotalBanCount = totalBanCount;
            this.Next = next;
        }

        /// <summary>
        /// Gets or Sets BannedList
        /// </summary>
        [DataMember(Name="banned_list", EmitDefaultValue=false)]
        public List<OcListBannedUsersResponseBannedListInner> BannedList { get; set; }

        /// <summary>
        /// Gets or Sets TotalBanCount
        /// </summary>
        [DataMember(Name="total_ban_count", EmitDefaultValue=false)]
        public decimal TotalBanCount { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcListBannedUsersResponse {\n");
            sb.Append("  BannedList: ").Append(BannedList).Append("\n");
            sb.Append("  TotalBanCount: ").Append(TotalBanCount).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
            return this.Equals(input as OcListBannedUsersResponse);
        }

        /// <summary>
        /// Returns true if OcListBannedUsersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OcListBannedUsersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcListBannedUsersResponse input)
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
                    this.TotalBanCount == input.TotalBanCount ||
                    (this.TotalBanCount != null &&
                    this.TotalBanCount.Equals(input.TotalBanCount))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
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
                if (this.TotalBanCount != null)
                    hashCode = hashCode * 59 + this.TotalBanCount.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
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
